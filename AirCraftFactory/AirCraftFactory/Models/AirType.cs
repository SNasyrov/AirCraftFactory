using System.ComponentModel.DataAnnotations;

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
        /// Название типа самолета
        /// </summary>
        [MaxLength(30)]
        [Display(Name = "Название типа самолета")]
        public string TypeName { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        [MaxLength(30)]
        [Display(Name = "Кодовое название самолета")]
        public string Code { get; set; }

        /// <summary>
        /// Масса
        /// </summary>
        [Display(Name = "Масса")]
        public int Weight { get; set; }

        /// <summary>
        /// Длина
        /// </summary>
        [Display(Name = "Длина")]
        public int Length { get; set; }

        /// <summary>
        /// Количество мест
        /// </summary>
        [Display(Name = "Количество мест")]
        public int NumberOfSeats { get; set; }

        /// <summary>
        /// Количество двигателей
        /// </summary>
        [Display(Name = "Количество двигателей")]
        public int NumberOfEngines { get; set; }

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        [Display(Name = "Максимальная скорость")]
        public float MaxSpeed { get; set; }

        /// <summary>
        /// Крейсерская скорость 
        /// </summary>
        [Display(Name = "Крейсерская скорость")]
        public float CruisingSpeed { get; set; }

        /// <summary>
        /// Тип двигателя
        /// </summary>
        [MaxLength(15)]
        [Display(Name = "Тип двигателя")]
        public string TypeEngine { get; set; }

        /// <summary>
        /// Максимальная взлетная масса, кг
        /// </summary>
        [Display(Name = "Максимальная взлетная масса, кг")]
        public int MaximumTakeoffWeight { get; set; }

        /// <summary>
        /// Экипаж, чел
        /// </summary>
        [Display(Name = "Экипаж, чел")]
        public int Crew { get; set; }

        /// <summary>
        /// Количество самолетов данного типа
        /// </summary>
        [Display(Name = "Количество самолетов данного типа")]
        public int NumberOfAircraft { get; set; }
    }
}