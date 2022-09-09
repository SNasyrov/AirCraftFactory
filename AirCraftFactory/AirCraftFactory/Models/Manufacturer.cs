using System.ComponentModel.DataAnnotations;

namespace AirCraftFactory.Models
{
    /// <summary>
    /// Класс производителя
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// Ид производителя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название производителя
        /// </summary>
        [MaxLength(30)]
        [Required(ErrorMessage = "Поле название производителя не может быть пустым")]
        [Display(Name = "Название производителя")]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// ИНН производителя
        /// </summary>
        [MaxLength(11)]
        [Required(ErrorMessage = "Поле ИНН не может быть пустым")]
        [Display(Name = "ИНН производителя")]
        public string Inn { get; set; }

        /// <summary>
        /// Почта производителя
        /// </summary>
        [Required(ErrorMessage = "Поле почта не может быть пустым")]
        [MaxLength(30)]
        [Display(Name = "Почта производителя")]
        public string Email { get; set; }

        /// <summary>
        /// Номер телефона производителя
        /// </summary>
        [Phone]
        [MaxLength(11)]
        [Required(ErrorMessage = "Поле номер телефона не может быть пустым")]
        [Display(Name = "Номер телефона производителя")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Адрес производителя
        /// </summary>
        [MaxLength(90)]
        [Display(Name = "Адрес производителя")]
        public string Address { get; set; }

        /// <summary>
        /// Подтвержден? 
        /// </summary>
        [Display(Name = "Подтвержден")]
        public bool IsConfirmed { get; set; } = false;
    }
}
