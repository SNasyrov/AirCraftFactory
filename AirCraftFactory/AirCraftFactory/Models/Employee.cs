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
        [MaxLength(15)]
        [Display(Name = "Имя работника")]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия работника
        /// </summary>
        [Required(ErrorMessage = "Поле фамилия не может быть пустым")]
        [MaxLength(15)]
        [Display(Name = "Фамилия работника")]
        public string LastName { get; set; }

        /// <summary>
        /// Отчество работника
        /// </summary>
        [MaxLength(15)]
        [Display(Name = "Отчество работника")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Фамилия И.О
        /// </summary>
        [MaxLength(20)]
        [Display(Name = "Фамилия И.О")]
        public string ComposedName { get; set; }

        /// <summary>
        /// Ид самолета который собирает работник
        /// </summary>
        [Display(Name = "Ид самолета который собирает работник")]
        public int? AirId { get; set; }
    }
}
