using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace WebGui.Areas.Identity.Controller;

public class AccountController : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly UserManager<User> UserManager;
    private readonly SignInManager<User> SignInManager;

    public static IDictionary<Guid, string> Logins { get; private set; }
        = new ConcurrentDictionary<Guid, string>();
    
    public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
    {
        UserManager = userManager;
        SignInManager = signInManager;
    }

    public static Guid GenerateToken(string username)
    {
        var token = Guid.NewGuid();
        AccountController.Logins[token] = username; 
        return token;
    }

    public static string? RedeemToken(Guid token)
    {
        try
        {
            string username = Logins[token];
            Logins.Remove(token);
            return username;
        }
        catch
        {
            return null;
        }
    }

    [HttpGet("/Identity/AccountController/Login")]
    public async Task<IActionResult> SignIn()
    {
        string? username;
        try
        {
            string token = Request.Query["token"];
            Guid tokenGuid = Guid.Parse(token);
            username = RedeemToken(tokenGuid);
        }
        catch
        {
            return Redirect("/");
        }

        if (username != null)
        {
            var requestedUser = await UserManager.FindByNameAsync(username); 
            if (requestedUser != null)
            {
                await SignInManager.SignInAsync(requestedUser,true);
            }
        }
        
        return Redirect("/");
    }

    [Authorize]
    [HttpGet("/Identity/AccountController/LogOut")]
    public async Task<IActionResult> SignOut()
    {
        await SignInManager.SignOutAsync();

        return Redirect("/");
    }
} 