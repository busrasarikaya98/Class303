using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Brand
    {
        [Key]
        public byte BrandId { get; set; }
        

        [Required(ErrorMessage ="{0} Boş Geçilemez"),
        Display(Name ="Marka"),StringLength(20,MinimumLength =3,ErrorMessage ="{0} {2}-{1} Karakter Olmalı!")]//marka ekleme sayfasında görülür.//display marka label yani müşterinin gördüğü
        public string BrandName { get; set; }
    }
}