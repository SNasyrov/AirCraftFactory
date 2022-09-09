namespace AirCraftFactory.Models
{
    /// <summary>
    /// Модель типа самолета
    /// </summary>
    public class AirType
    {
        /// <summary>
        /// Ид типа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название типа
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Масса
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Длина
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Количество мест
        /// </summary>
        public int NumberOfSeats { get; set; }

        /// <summary>
        /// Количество двигателей
        /// </summary>
        public int NumberOfEngines { get; set; }

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public float MaxSpeed { get; set; }

        /// <summary>
        /// Крейсерская скорость 
        /// </summary>
        public float CruisingSpeed { get; set; }

        /// <summary>
        /// Тип двигателя
        /// </summary>
        public string TypeEngine { get; set; }

        /// <summary>
        /// Максимальная взлетная масса, кг
        /// </summary>
        public int MaximumTakeoffWeight { get; set; }

        /// <summary>
        /// Экипаж, чел
        /// </summary>
        public int Crew { get; set; }

        /// <summary>
        /// Количество самолетов данного типа
        /// </summary>
        public int NumberOfAircraft { get; set; }
    }
}