using System.ComponentModel.DataAnnotations;
using Domain.Repositories.Implementations;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Model.Entities;

namespace WebGui.Areas.Models;

public class RegisterInfo
{
    public string UserName { get; set; }
    public string Password { get; set; }
    
    public string Password2 { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class RegisterInfoValidator : AbstractValidator<RegisterInfo>
{
    private UserRepository userRepository { get; set; }
    private UserManager<User> UserManager { get; set; }
    public RegisterInfoValidator(UserRepository userRepository,UserManager<User> userManager)
    {
        this.userRepository = userRepository;
        this.UserManager = userManager;

        RuleFor(x => x.UserName)
            .NotEmpty()
            .Must((value, cancellationToken) => IsUniqueUserName(value.Password))
            .WithMessage("The username is already taken.");

        RuleFor(x => x.Password)
            .NotEmpty()
            .MustAsync((value, cancellationToken) => IsValidPassword(value))
            .WithMessage("The password is to weak.");
        
        RuleFor(x => x.Password2)
            .NotEmpty()
            .Equal(x => x.Password)
            .WithMessage("The passwords do not match.");

        RuleFor(x => x.FirstName)
            .NotEmpty()
            .Length(1,100);
        RuleFor(x => x.LastName)
            .NotEmpty()
            .Length(1,100);
    }

    private bool IsUniqueUserName(string username)
    {
        return this.userRepository.CheckIfUserExists(username) == false;
        
        // Problems with concurrency
        //return (await this.UserManager.FindByNameAsync(username)) == null;
    }
    
    private async Task<bool> IsValidPassword(string password)
    {
        foreach (var passwordValidator in UserManager.PasswordValidators)
        {
            var result = await passwordValidator.ValidateAsync(UserManager, new User(), password);
            
            if (!result.Succeeded)
            {
                return false;
            }
        }

        return true;
    }

    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<RegisterInfo>.CreateWithOptions((RegisterInfo)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}
