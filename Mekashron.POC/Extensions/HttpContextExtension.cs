using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mekashron.POC.Extensions
{
    public class HttpContextExtension
    {
        public static string GetUserIP(HttpRequest req)
        {
            var ip = req.Headers["X-Forwarded-For"].FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(ip)) ip = ip.Split(',')[0];

            if (string.IsNullOrWhiteSpace(ip)) ip = Convert.ToString(req.HttpContext.Connection.RemoteIpAddress);

            if (string.IsNullOrWhiteSpace(ip)) ip = req.Headers["REMOTE_ADDR"].FirstOrDefault();

            return ip;
        }
    }
}
