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
        public int UserId { get; set; }

        /// <summary>
        /// Баланс
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Подтвержден? 
        /// </summary>
        public bool IsConfirmed { get; set; }
    }
}
