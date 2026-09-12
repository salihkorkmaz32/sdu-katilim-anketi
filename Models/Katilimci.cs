using System.ComponentModel.DataAnnotations;

namespace anket.Models
{
    public class Katilimci
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Soyad alanı zorunludur.")]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Öğrenci Numarası zorunludur.")]
        public string OgrenciNumarasi { get; set; }

        [Required(ErrorMessage = "Fakülte / Yüksekokul / Meslek Yüksekokulu zorunludur.")]
        public string Fakulte { get; set; }

        [Required(ErrorMessage = "Bölüm alanı zorunludur.")]
        public string Bolum { get; set; }

        [Required(ErrorMessage = "İletişim Numarası zorunludur.")]
        public string IletisimNumarasi { get; set; }

        [Required(ErrorMessage = "Topluluk Üyelik Bilgisi zorunludur.")]
        public string ToplulukUyeligi { get; set; }

        [Required(ErrorMessage = "E posta Adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Eposta { get; set; }

        [Required(ErrorMessage = "Gün seçimi zorunludur.")]
        public string KatilimGunu { get; set; }

        [Required(ErrorMessage = "Kalkış noktası seçimi zorunludur.")]
        public string KalkisNoktasi { get; set; }

        [Required(ErrorMessage = "QR kod onayı zorunludur.")]
        public bool QrKodOlusturulduMu { get; set; }
    }
}