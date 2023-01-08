using System.ComponentModel.DataAnnotations;
using Domain.Repositories.Implementations;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Model.Entities;
using WebGui.Areas.Identity.Pages.Account;

namespace WebGui.Areas.Models;

public class LogInInfo
{
    public string UserName { get; set; }
    public string Password { get; set; }
}

public class LogInInfoValidator : AbstractValidator<LogInInfo>
{
    private UserRepository userRepository { get; set; }
    public LogInInfoValidator(UserRepository userRepository)
    {
        this.userRepository = userRepository;

        RuleFor(x => x.UserName)
            .NotEmpty()
            .Must((value, cancellationToken) => DoesUserNameExist(value.UserName))
            .WithMessage("The username does not exist.");


        RuleFor(x => x.Password)
            .NotEmpty();
        
    }

    private bool DoesUserNameExist(string username)
    {
        return this.userRepository.CheckIfUserExists(username);
    }

    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<LogInInfo>.CreateWithOptions((LogInInfo)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}

