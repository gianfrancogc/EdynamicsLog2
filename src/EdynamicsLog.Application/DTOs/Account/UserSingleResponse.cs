using System;
using System.Collections.Generic;
using System.Text;

namespace EdynamicsLog.Application.DTOs.Account
{
    public class UserSingleResponse
    {
        public string Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string Photo { get; set; }
        public Domain.Common.Enums.Status Status { get; set; }
        public Domain.Common.Enums.Gender Sexo { get; set; }
    }
}
