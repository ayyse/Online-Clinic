﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Online_Clinic.Common.ConstantsModels;
using Online_Clinic.Data.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Clinic.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Visitor> _signInManager;
        private readonly UserManager<Visitor> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        //private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<Visitor> userManager,
            SignInManager<Visitor> signInManager,
            ILogger<RegisterModel> logger)
            //IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            //_emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Kullanıcı Adı")]
            public string KullanıcıAdı { get; set; } 

            [Required]
            [Display(Name = "Ad")]
            public string Ad { get; set; }

            [Required]
            [Display(Name = "Soyad")]
            public string Soyad { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [Display(Name = "Doğum Tarihi")]
            public DateTime DoğumTarihi { get; set; }

            [Required]
            [Display(Name = "Cinsiyet")]
            public string Cinsiyet { get; set; }

            [Required]
            [Display(Name = "Üyelik Tipi")]
            public string Role { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Şifre")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Şifreyi Doğrula")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new Visitor { 
                    UserName = Input.KullanıcıAdı, 
                    Email = Input.Email,
                    Ad = Input.Ad, 
                    Soyad = Input.Soyad,
                    DoğumTarihi = Input.DoğumTarihi,
                    Cinsiyet = Input.Cinsiyet,
                    Şifre = Input.Password,
                    Role = Input.Role,
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    //_userManager.AddToRoleAsync(user, ResultConstant.DoktorRole).Wait();
                    //_userManager.AddToRoleAsync(user, ResultConstant.HastaRole).Wait();
                    //_userManager.AddToRoleAsync(user, ResultConstant.BağışçıRole).Wait();


                    if (user.Role == ResultConstant.DoktorRole)
                    {
                        await _userManager.AddToRoleAsync(user, ResultConstant.DoktorRole);
                    }
                    if (user.Role == ResultConstant.HastaRole)
                    {
                        await _userManager.AddToRoleAsync(user, ResultConstant.HastaRole);
                    }
                    if (user.Role == ResultConstant.BağışçıRole)
                    {
                        await _userManager.AddToRoleAsync(user, ResultConstant.BağışçıRole);
                    }


                    _logger.LogInformation("User created a new account with password.");

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    //var callbackUrl = Url.Page(
                    //    "/Account/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new { area = "Identity", userId = user.Id, code = code },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
