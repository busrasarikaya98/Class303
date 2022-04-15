using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class FuelType
    {
        [Key]
        public byte FuelTypeId { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez"),
        Display(Name = "YakıtTürü"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} Karakter Olmalı!")]
        public string FuelTypeName { get; set; }
    }
}