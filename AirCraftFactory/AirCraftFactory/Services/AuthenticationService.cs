using AirCraftFactory.Data;

namespace AirCraftFactory.Services
{
    public class AuthenticationService
    {
        private readonly ApplicationContext _db;

        public AuthenticationService(ApplicationContext context)
        {
            _db = context;
        }
        public static bool CheckAuthentication(HttpRequest request)
        {
            request.Cookies.TryGetValue("Authorization", out string? value);

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
