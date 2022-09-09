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
        [MaxLength(20)]
        [Display(Name = "Логин")]
        public string Login { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        [Required(ErrorMessage = "Поле почта не может быть пустым")]
        [MaxLength(40)]
        [Display(Name = "Почта")]
        public string Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Required(ErrorMessage = "Поле пароль не может быть пустым")]
        [MaxLength(15)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Required(ErrorMessage = "Поле имя не может быть пустым")]
        [MaxLength(20)]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Required(ErrorMessage = "Поле фамилия не может быть пустым")]
        [MaxLength(20)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [MaxLength(20)]
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Фамилия И.О
        /// </summary>
        [MaxLength(20)]
        [Display(Name = "Фамилия И.О")]
        public string ComposedName { get; set; }

        /// <summary>
        /// Создан
        /// </summary>
        [Display(Name = "Дата создания")]
        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Обновлен
        /// </summary>
        [Display(Name = "Дата обновления")]
        [DataType(DataType.Date)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Подтвержден? 
        /// </summary>
        [Display(Name = "Подтвержден")]
        public bool IsConfirmed { get; set; } = false;
    }
}
