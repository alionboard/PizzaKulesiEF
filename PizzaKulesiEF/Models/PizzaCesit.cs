using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesiEF.Models
{
    [Table("PizzaCesitler")]
    public class PizzaCesit
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string PizzaAd { get; set; }

        public override string ToString()
        {
            return PizzaAd;
        }
    }
}
