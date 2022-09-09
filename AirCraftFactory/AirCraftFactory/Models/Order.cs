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
        public int ManufacturerId { get; set; }

        /// <summary>
        /// Ид заказчика
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Ид типа самолета
        /// </summary>
        public int AirTypeId { get; set; }
    }
}
