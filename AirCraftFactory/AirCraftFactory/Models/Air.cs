#nullable disable
using System.ComponentModel.DataAnnotations;

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
        [MaxLength(20)]
        [Display(Name = "Название самолета")]
        public string AirName { get; set; }

        /// <summary>
        /// Ид производителя
        /// </summary>
        [Display(Name = "Ид производителя")]
        public int ManufacturerId { get; set; }

        /// <summary>
        /// Ид типа самолета
        /// </summary>
        [Display(Name = "Ид типа самолета")]
        public int TypeId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        [Display(Name = "Дата создания")]
        [DataType(DataType.Date)]
        public DateTime Create { get; set; }

        /// <summary>
        /// Готов?
        /// </summary>
        [Display(Name = "Готов")]
        public bool IsReady { get; set; } = false;
    }
}
