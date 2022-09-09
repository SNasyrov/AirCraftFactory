#nullable disable
namespace AirCraftFactory.Models
{
    /// <summary>
    /// Класс самолета
    /// </summary>
    public class Air
    {
        /// <summary>
        /// Ид самолета
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название самолета
        /// </summary>
        public string AirName { get; set; }

        /// <summary>
        /// Ид производителя
        /// </summary>
        public int ManufacturerId { get; set; }

        /// <summary>
        /// Ид типа самолета
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Create { get; set; }

        /// <summary>
        /// Готов?
        /// </summary>
        public bool IsReady { get; set; }
    }
}
