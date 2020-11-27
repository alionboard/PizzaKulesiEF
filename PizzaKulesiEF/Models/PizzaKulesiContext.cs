using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesiEF.Models
{
    public class PizzaKulesiContext : DbContext
    {
        public PizzaKulesiContext() : base("name=PizzaKulesiContext")
        {
            Database.SetInitializer(new MyInitializationStrategy());
        }

        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public DbSet<PizzaCesit> PizzaCesitler { get; set; }
        
    }
}
