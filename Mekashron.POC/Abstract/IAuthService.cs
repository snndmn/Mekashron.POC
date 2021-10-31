using Mekashron.POC.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mekashron.POC.Abstract
{
    public interface IAuthService
    {
        Task<GenericResponse> SignIn(string username, string password, string IP);
    }
}
