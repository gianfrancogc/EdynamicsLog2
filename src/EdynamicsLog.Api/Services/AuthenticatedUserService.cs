﻿using EdynamicsLog.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace EdynamicsLog.Services
{
    public class AuthenticatedUserService : IAuthenticatedUserService
    {
        public AuthenticatedUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue("uid");
        }

        public string UserId { get; }
    }
}
