

using System.ComponentModel.DataAnnotations;

namespace CarRental.ViewModel
{
    public class UserrViewModel //burası giris yaparken kullanılacak user
    {
        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "E-Posta"), StringLength(50, MinimumLength = 6, ErrorMessage = "{0} , {2} - {1} Karakter Olmalı"), DataType(DataType.EmailAddress, ErrorMessage = "{0} Uygun formatta değil!")]
        public string Emaill { get; set; }

        [Required(ErrorMessage = "{0} Gerekli"), Display(Name = "Şifre"), StringLength(20, MinimumLength = 6, ErrorMessage = "{0} , {2} - {1} Karakter Olmalı"), DataType(DataType.Password)]
        public string Passwordd { get; set; }
    }
}
