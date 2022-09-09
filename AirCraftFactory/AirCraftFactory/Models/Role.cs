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
        /// Отображаемое имя
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Код роли
        /// </summary>
        public string Code { get; set; }
    }
}