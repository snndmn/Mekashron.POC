using System;
using ICUTechService;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Mekashron.POC.Abstract;
using Mekashron.POC.Models.Messages;
using Mekashron.POC.Models.Infrastructure;

namespace Mekashron.POC.Services
{
    public class AuthService : IAuthService
    {
        public async Task<GenericResponse> SignIn(string username, string password, string IP)
        {
            var response = new GenericResponse();

            try
            {
                using (var client = new ICUTechClient())
                {
                    var loginResponse = await client.LoginAsync(username, password, IP);
                    var user = JsonConvert.DeserializeObject<SignInResponse>(loginResponse.@return);
                    response.HasError = false;
                    response.ResultMessage = Constants.ReturnMessages.LOGIN_SUCCESS_MESSAGE;

                    if (user.EntityId == 0)
                    {
                        response = JsonConvert.DeserializeObject<GenericResponse>(loginResponse.@return);
                        response.HasError = true;
                    }
                }
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.ResultCode = -1;
                response.ResultMessage = $"Error: {ex.Message}";
            }

            return response;
        }
    }
}
