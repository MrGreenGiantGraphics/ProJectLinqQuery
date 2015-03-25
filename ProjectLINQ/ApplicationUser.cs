using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLINQ
{
    class ApplicationUser
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public ApplicationUser(string fullName, string email, bool emailConfrimed)
        {
            this.FullName = fullName;
            this.Email = email;
            this.EmailConfirmed = emailConfrimed;
        }
    }
}
