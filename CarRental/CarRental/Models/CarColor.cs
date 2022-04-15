using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class CarColor
    {
        [Key]
        public byte CarColorId { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez"),
        Display(Name = "Renk"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} Karakter Olmalı!")]
        public string  CarColorName { get; set; }

    }
}