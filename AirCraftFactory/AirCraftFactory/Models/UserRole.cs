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
        public int UserId { get; set; }

        /// <summary>
        /// Ид роли
        /// </summary>
        public int RoleId { get; set; }
    }
}
