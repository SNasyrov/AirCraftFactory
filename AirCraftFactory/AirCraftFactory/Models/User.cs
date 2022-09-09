using System.ComponentModel.DataAnnotations;

namespace AirCraftFactory.Models
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class User
    {
        /// <summary>
        /// Ид пользователя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        [Required(ErrorMessage = "Поле логин не может быть пустым")]
        public string Login { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        [Required(ErrorMessage = "Поле почта не может быть пустым")]
        public string Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Required(ErrorMessage = "Поле пароль не может быть пустым")]
        public string Password { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Required(ErrorMessage = "Поле имя не может быть пустым")]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Required(ErrorMessage = "Поле фамилия не может быть пустым")]
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Фамилия И.О
        /// </summary>
        public string ComposedName { get; set; }

        /// <summary>
        /// Создан
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Обновлен
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Подтвержден? 
        /// </summary>
        public bool IsConfirmed { get; set; }
    }
}
