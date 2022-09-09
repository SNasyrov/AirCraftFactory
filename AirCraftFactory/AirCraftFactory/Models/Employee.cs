using System.ComponentModel.DataAnnotations;

namespace AirCraftFactory.Models
{
    /// <summary>
    /// Модель работника
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Ид работника
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя работника
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
        /// Ид самолета который собирает работник
        /// </summary>
        public int? AirId { get; set; }
    }
}
