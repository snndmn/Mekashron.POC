using ICUTechService;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mekashron.POC.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace Mekashron.POC.Controllers
{
    public class AuthorizationController : Controller
    {
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<bool> SignIn(string username, string password)
        {
            var IP = HttpContextExtension.GetUserIP(HttpContext.Request);

            using (var client = new ICUTechClient())
            {
                var response = await client.LoginAsync(username, password, IP);
            }

            return false;
        }





    }
}
