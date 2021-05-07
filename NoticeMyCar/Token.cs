using System;

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
