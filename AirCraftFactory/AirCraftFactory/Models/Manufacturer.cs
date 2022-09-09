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
        public string ManufacturerName { get; set; }

        /// <summary>
        /// ИНН производителя
        /// </summary>
        [MaxLength(11)]
        [Required(ErrorMessage = "Поле ИНН не может быть пустым")]
        public string Inn { get; set; }

        /// <summary>
        /// Почта производителя
        /// </summary>
        [Required(ErrorMessage = "Поле почта не может быть пустым")]
        public string Email { get; set; }

        /// <summary>
        /// Номер телефона производителя
        /// </summary>
        [Phone]
        [MaxLength(11)]
        [Required(ErrorMessage = "Поле номер телефона не может быть пустым")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Адрес производителя
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Подтвержден? 
        /// </summary>
        public bool IsConfirmed { get; set; }
    }
}
