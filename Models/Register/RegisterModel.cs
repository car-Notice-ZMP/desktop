using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Register
{
    public class RegisterModel : IRegisterModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public string password_confirmation { get; set; }
        public string name { get; set; }
    }
}
