using System.ComponentModel.DataAnnotations;

namespace AirCraftFactory.Models
{
    /// <summary>
    /// Модель заказа
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Ид заказа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ид производителя
        /// </summary>
        [Display(Name = "Ид производителя")]
        public int ManufacturerId { get; set; }

        /// <summary>
        /// Ид заказчика
        /// </summary>
        [Display(Name = "Ид заказчика")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Ид типа самолета
        /// </summary>
        [Display(Name = "Ид типа самолета")]
        public int AirTypeId { get; set; }
    }
}
