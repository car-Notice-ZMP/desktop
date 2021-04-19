using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar
{
    public class Token
    {
        static string token;

        public static void addToken(String addToken)
        {
            token = addToken;
        }

        public static string returnToken()
        {
            return token;
        }
    }
}
