using AirCraftFactory.Data;
using AirCraftFactory.Models;

namespace AirCraftFactory.Helpers
{
    public class CookiesHelper
    {
        private static string KeyGeneration()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[15];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return (finalString);
        }

        public static void SetCookieValue(User user, HttpResponse response)
        {
            var options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(7),
            };
            string cookieName = "Authorization";
            string cookieValue = KeyGeneration();

            user.AuthorizationCode = cookieValue;

            response.Cookies.Append(cookieName, cookieValue, options);
        }
    }
}
