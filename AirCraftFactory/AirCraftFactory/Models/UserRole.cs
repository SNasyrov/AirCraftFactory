using System.ComponentModel.DataAnnotations;

namespace AirCraftFactory.Models
{
    /// <summary>
    /// Моджель связи роли и пользователя
    /// </summary>
    public class UserRole
    {
        /// <summary>
        /// Ид пользователя
        /// </summary>
        [Display(Name = "Ид пользователя")]
        public int UserId { get; set; }

        /// <summary>
        /// Ид роли
        /// </summary>
        [Display(Name = "Ид роли")]
        public int RoleId { get; set; }
    }
}
