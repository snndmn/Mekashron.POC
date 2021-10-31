using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mekashron.POC.Models.Infrastructure
{
    public class AppSettings
    {
        public SeedUser seedUser { get; set; }
    }

    public class SeedUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string mobile { get; set; }
        public int countryId { get; set; }
        public int aId { get; set; }
        public string singupIp {get;set;}
    }
}
