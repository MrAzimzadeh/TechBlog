using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Models
{
    public class User : IdentityUser
    {

        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhotoUrl { get; set; }
        public string AboutAuther { get; set; }
        public List<Article> Articles { get; set; }
        public List<UserAds> UserAds { get; set; }
    }
}