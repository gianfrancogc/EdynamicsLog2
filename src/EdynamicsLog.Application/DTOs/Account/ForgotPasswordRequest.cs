﻿using System.ComponentModel.DataAnnotations;

namespace EdynamicsLog.Application.DTOs.Account
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
