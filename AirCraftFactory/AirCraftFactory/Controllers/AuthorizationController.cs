using AirCraftFactory.Data;
using AirCraftFactory.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirCraftFactory.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly ApplicationContext _db;

        public AuthorizationController(ApplicationContext context)
        {
            _db = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User model)
        {
            try
            {
                #region Validation
                if (string.IsNullOrWhiteSpace(model.Login))
                    ModelState.AddModelError("Login", "Поле логин не может быть пустым");
                if (string.IsNullOrWhiteSpace(model.Password))
                    ModelState.AddModelError("Password", "Поле пароль не может быть пустым");

                if (!ModelState.IsValid)
                    return View(model);
                #endregion

                var user = _db.User.FirstOrDefault(x => x.Login == model.Login);

                if (user.Password != model.Password)
                    ModelState.AddModelError("Password", "Неверный пароль");

                if (user == null)
                    throw new Exception();

                if (!ModelState.IsValid)
                    return View(model);

                var authorized = true;
                // Добавляем в куки ключ - логин пользователя, значение - авторизован или нет
                Response.Cookies.Append(model.Login, authorized.ToString());
                return RedirectToAction("Index","Home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Такого пользователя не существует";
                return View(model);
            }
        }
    }
}
