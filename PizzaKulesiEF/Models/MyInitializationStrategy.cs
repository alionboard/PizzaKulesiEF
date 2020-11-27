using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesiEF.Models
{
    public class MyInitializationStrategy : CreateDatabaseIfNotExists<PizzaKulesiContext>
    {
        protected override void Seed(PizzaKulesiContext context)
        {
            PizzaCesit pizzaCesit1 = new PizzaCesit { PizzaAd = "Karışık" };
            PizzaCesit pizzaCesit2 = new PizzaCesit { PizzaAd = "Margarita" };
            PizzaCesit pizzaCesit3 = new PizzaCesit { PizzaAd = "Peynirli" };

            EkstraMalzeme ekstraMalzeme1 = new EkstraMalzeme { MalzemeAd = "Mozzarella" };
            EkstraMalzeme ekstraMalzeme2 = new EkstraMalzeme { MalzemeAd = "Biber" };
            EkstraMalzeme ekstraMalzeme3 = new EkstraMalzeme { MalzemeAd = "Küp Sucuk" };

            Siparis siparis1 = new Siparis { MusteriAdSoyad = "Ali Özbek", Adres = "Ankara Keçiören 06300", TeslimDurumu = true, EkstraMalzemeler = new List<EkstraMalzeme> { ekstraMalzeme3 }, PizzaCesit = pizzaCesit1 };
            Siparis siparis2 = new Siparis { MusteriAdSoyad = "Alex Adams", Adres = "Lublin Nadbystrzycka Dom Studencki", TeslimDurumu = false, EkstraMalzemeler = new List<EkstraMalzeme> { ekstraMalzeme1, ekstraMalzeme2, ekstraMalzeme3 }, PizzaCesit = pizzaCesit2 };
            Siparis siparis3 = new Siparis { MusteriAdSoyad = "Chester", Adres = "Newyork Manhattan 019860", TeslimDurumu = false, PizzaCesit = pizzaCesit3 };

            context.PizzaCesitler.AddRange(new PizzaCesit[] { pizzaCesit1, pizzaCesit2, pizzaCesit3 });
            context.EkstraMalzemeler.AddRange(new EkstraMalzeme[] { ekstraMalzeme1, ekstraMalzeme2, ekstraMalzeme3 });
            context.Siparisler.AddRange(new Siparis[] { siparis1, siparis2, siparis3 });
        }
    }
}
