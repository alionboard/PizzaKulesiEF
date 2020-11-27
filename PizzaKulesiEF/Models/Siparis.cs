using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesiEF.Models
{
    [Table("Siparisler")]
    public class Siparis
    {
        public int Id { get; set; }
        public int PizzaCesitId { get; set; }
        [Required, MaxLength(50)]
        public string MusteriAdSoyad { get; set; }
        [Required, MaxLength(200)]
        public string Adres { get; set; }
        [Required]
        public bool TeslimDurumu { get; set; }
        public string VirgulluMalzemeler
        {
            get { return $"{EkstraMalzemeler.Select(x => x.MalzemeAd).Virgulle()}"; }
        }

        public string TeslimEdildiMi
        {
            get { return TeslimDurumu ? "Evet" : "Hayır"; }
        }

        public virtual PizzaCesit PizzaCesit { get; set; }

        public virtual ICollection<EkstraMalzeme> EkstraMalzemeler { get; set; }
    }
}
