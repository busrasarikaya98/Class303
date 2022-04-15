using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class BodyType
    {
        [Key]
        public byte BodyTypeId { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez"),
         Display(Name = "Kasa Türü"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} Karakter Olmalı!")]
        public String BodyTypeName { get; set; }
    }
}