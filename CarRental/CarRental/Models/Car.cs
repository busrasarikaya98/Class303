using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Required(ErrorMessage = "{0} Boş Geçilemez"), Display(Name = "Marka")]
        public byte BrandId { get; set; }//marka

        [Required(ErrorMessage = "{0} Boş Geçilemez"), Display(Name = "Renk")]
        public byte CarColorId { get; set; }

        [Required(ErrorMessage = "{0} Boş Geçilemez"), Display(Name = "Araba Modeli"), StringLength(50, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} Karakter Olmalı!")]
        public string CarModel { get; set; }

        [Required(ErrorMessage = "{0} Boş Geçilemez"), Display(Name = "YakıtTürü")]
        public byte FuelTypeId { get; set; }//yakıt

        [Required(ErrorMessage = "{0} Boş Geçilemez"), Display(Name = "Vites Türü")]
        public byte GearTypeId { get; set; }//vites

        [Required(ErrorMessage = "{0} Boş Geçilemez"), Display(Name = "Koltuk sayısı")]
        public byte SeatNumber { get; set; }//koltuk sayısı

        [Required(ErrorMessage = "{0} Boş Geçilemez"), Display(Name = "Kasa Tipi")]
        public byte BodyTypeId { get; set; }//kasa türü

        [Required(ErrorMessage = "{0} Boş Geçilemez"), Display(Name = "Model Yılı")]
        public short ModelYear { get; set; }

        [Required(ErrorMessage = "{0} Boş Geçilemez"), Display(Name = "Bagaj Hacmi")]
        public short LuggageVolume { get; set; }//bagaj hacmi


        public Brand Brand { get; set; }
        public CarColor Carcolor { get; set; }
        public FuelType FuelType { get; set; }
        public GearType GearType { get; set; }
        public BodyType BodyType { get; set; }
    }
}
