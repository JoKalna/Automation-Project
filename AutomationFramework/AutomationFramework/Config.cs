using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Config file is used for vairables that are used in multiple places and
 * through out the framework. E.g username, we can all anywhere in our classess as they are public static s
 */


namespace AutomationFramework
{
    class Config
    {
        public static string BaseURL = "http://testing.todvachev.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf123!";
                public static string RepeatPassword = "asdf123";
                public static string Email = "example@example.com";

            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "Asdf";
                    public static string ThirteenCharacters = "AsdfAsdfAsdfAsdf";
                    

                }
                public static class Password
                {
                    public static string PasswordJustNumbersInvalid = "1234";
                    public static string PasswordIncorrect = "testing123";


                }
                public static class Email
                {
                    public static string IncorrectEmail = "11@example.com"
                    public static string IncorrectSecondEmail = "two@example.com";

                }
            }
        }
    }
}
