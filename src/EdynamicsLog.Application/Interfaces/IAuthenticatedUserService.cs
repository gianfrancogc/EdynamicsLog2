using System;
using System.Collections.Generic;
using System.Text;

namespace EdynamicsLog.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
