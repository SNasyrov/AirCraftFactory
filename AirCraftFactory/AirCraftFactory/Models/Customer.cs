using System.ComponentModel.DataAnnotations;

namespace AirCraftFactory.Models
{
    /// <summary>
    /// Модель заказчика
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Ид заказчика
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ид пользователя
        /// </summary>
        [Display(Name = "Ид пользователя")]
        public int UserId { get; set; }

        /// <summary>
        /// Баланс
        /// </summary>
        [Display(Name = "Баланс")]
        public decimal Balance { get; set; }

        /// <summary>
        /// Подтвержден? 
        /// </summary>
        [Display(Name = "Подтвержден")]
        public bool IsConfirmed { get; set; } = false;
    }
}
