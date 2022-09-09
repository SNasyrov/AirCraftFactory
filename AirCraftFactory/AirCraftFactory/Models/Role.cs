using System.ComponentModel.DataAnnotations;

namespace AirCraftFactory.Models
{
    /// <summary>
    /// Модель роли
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Ид роли
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Отображаемое имя роли
        /// </summary>
        [MaxLength(20)]
        [Display(Name = "Отображаемое имя роли")]
        public string RoleName { get; set; }

        /// <summary>
        /// Код роли
        /// </summary>
        [MaxLength(15)]
        [Display(Name = "Код роли")]
        public string Code { get; set; }
    }
}