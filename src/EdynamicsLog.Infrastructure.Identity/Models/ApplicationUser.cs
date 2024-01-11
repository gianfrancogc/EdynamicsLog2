using Microsoft.AspNetCore.Identity;
using EdynamicsLog.Application.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Text;
using EdynamicsLog.Domain.Common;

namespace EdynamicsLog.Infrastructure.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string Photo { get; set; }
        public Enums.Status Status { get; set; }
        public Enums.Gender Sexo { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}
