using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class GearType
    {
        [Key]
        public byte GearTypeId { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez"),
       Display(Name = "Vites Türü"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} Karakter Olmalı!")]
        public string GearTypeName { get; set; }
    }
}