using ICUTechService;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mekashron.POC.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Mekashron.POC.Models.Messages;
using Mekashron.POC.Abstract;

namespace Mekashron.POC.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly IAuthService _authService;

        public AuthorizationController(IAuthService  authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                throw new System.ArgumentNullException("ssss");

            var IP = HttpContextExtension.GetUserIP(HttpContext.Request);
            var response = await _authService.SignIn(username, password, IP);

            return Json(response);
        }


    }
}
