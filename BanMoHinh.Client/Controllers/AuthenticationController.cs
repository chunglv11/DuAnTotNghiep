﻿using BanMoHinh.Client.IServices;
using BanMoHinh.Client.Services;
using BanMoHinh.Share.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using System.Net.Http;
using System.Security.Policy;
using System.Net.WebSockets;

namespace BanMoHinh.Client.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IServices.IAuthenticationService _authenticationService;
        private readonly HttpClient _httpClient;

        public AuthenticationController(IServices.IAuthenticationService authenticationService,HttpClient httpClient)
        {
            _authenticationService = authenticationService;
            _httpClient = httpClient;

        }
        public IActionResult Login()
        {
            var checkLogin = User.Identity.IsAuthenticated;
            if (checkLogin)
            {
                var user = User.Claims.FirstOrDefault(c=>c.Type == ClaimTypes.NameIdentifier).Value;
                var role = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value;
                if (role== "Admin")
                {
                    return Redirect("Admin/Home/Index");
                }
                if (role == "User")
                {
                    return RedirectToAction("Index","Home");
                }
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var url = "https://localhost:7007/api/authentication/login";
            var result = await _authenticationService.Login(model, url);
            if (result.IsSuccess)
            {
                var token = result.Token;
                var handler = new JwtSecurityTokenHandler();
                var jwt = handler.ReadJwtToken(token);
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, jwt.Claims.FirstOrDefault(u => u.Type == ClaimTypes.Name).Value));
                identity.AddClaim(new Claim(ClaimTypes.Role, jwt.Claims.FirstOrDefault(u => u.Type == ClaimTypes.Role).Value));
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, jwt.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value));
                identity.AddClaim(new Claim(ClaimTypes.Email, jwt.Claims.FirstOrDefault(u => u.Type == ClaimTypes.Email).Value));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                string role = jwt.Claims.FirstOrDefault(u => u.Type == ClaimTypes.Role).Value;
                if (role == "User") { return RedirectToAction("Index", "Home"); }
                else
                {
                    return Redirect("Admin/Home/Index");
                }
            }
            else
            {
                ViewBag.Message = result.Messages;
                return View();
            }
        }
        public async Task<IActionResult> LogOut()
        {
           var sd = await _authenticationService.Logout();
            if (sd.IsSuccess)
            {
                Response.Cookies.Delete("Cookie_Cua_Trung");
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Indexs", "Home");
        }
        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var urlRegister = "https://localhost:7007/api/authentication/register";
            var result = await _authenticationService.Register(model, urlRegister);
            if (result.IsSuccess)
            {
                var LoginModel = new LoginViewModel()
                {
                    UserName = model.UserName,
                    Password = model.Password
                };
               return await Login(LoginModel);
            }
            else
            {
                ViewBag.Message = result.Messages;
                return View();
            }
        }
    }
}
