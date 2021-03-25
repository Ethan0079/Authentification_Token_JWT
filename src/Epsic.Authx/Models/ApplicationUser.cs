using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace Epsic.Authx.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool isMedecin { get; set; }
    }
}
