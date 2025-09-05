//Installing Package Microsoft.AspNetCore.Authentication.Cookies

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using BusinessServiceContract.Services;
using DomainModel.DTO.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

//using Microsoft.AspNetCore.Http.Authentication;


namespace Business.IMP
{
    public class AuthHelper : IAuthHelper
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public AuthHelper(IHttpContextAccessor contextAccessor)
        {

            _contextAccessor = contextAccessor;
        }


        public void SignOut()
        {
            _contextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        public UserInfo GetCurrentUserInfo()
        {

            if (_contextAccessor.HttpContext.User.Claims.FirstOrDefault() == null)
            {
                return new UserInfo();
            }

            var claims = _contextAccessor.HttpContext.User.Claims.ToList();
            var UserId = int.Parse(claims.First(x => x.Type == "UserId").Value);
            var UserName = claims.First(x => x.Type == ClaimTypes.Name).Value;
            var RoleId = int.Parse(claims.First(x => x.Type == "RoleId").Value);
            var RoleName = claims.First(x => x.Type == "RoleName").Value;
            var FullName = claims.First(x => x.Type == "FullName").Value;
            return new UserInfo { FullName = FullName, RoleId = RoleId, RoleName = RoleName, UserId = UserId, UserName = UserName };
        }

        public void Signin(UserInfo UserInfo)
        {
            var claims = new List<Claim>
            {
                new Claim("UserId", UserInfo.UserId.ToString()),
                new Claim(ClaimTypes.Name, UserInfo.UserName),
                new Claim("RoleId", UserInfo.RoleId.ToString()),
                new Claim("RoleName", UserInfo.RoleName),
                new Claim("FullName", UserInfo.FullName)
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                //AllowRefresh = <bool>,
                // Refreshing the authentication session should be allowed.
                AllowRefresh = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(20)
                ,
                IsPersistent = true

                // The time at which the authentication ticket expires. A 
                // value set here overrides the ExpireTimeSpan option of 
                // CookieAuthenticationOptions set with AddCookie.

                //IsPersistent = true,
                // Whether the authentication session is persisted across 
                // multiple requests. When used with cookies, controls
                // whether the cookie's lifetime is absolute (matching the
                // lifetime of the authentication ticket) or session-based.

                //IssuedUtc = <DateTimeOffset>,
                // The time at which the authentication ticket was issued.

                //RedirectUri = <string>
                // The full path or absolute URI to be used as an http 
                // redirect response value.
            };

            var m = _contextAccessor.HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }
    }
} 