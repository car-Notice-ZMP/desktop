using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Login
{
    public class LoginModel : ILoginModel
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
