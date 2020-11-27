using PizzaKulesiEF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaKulesiEF
{
    public partial class PizzaCesitForm : Form
    {
        public event EventHandler IcerikDuzenlendi;
        PizzaKulesiContext db = new PizzaKulesiContext();
        public PizzaCesitForm()
        {
            InitializeComponent();
            PizzaCesitleriListele();

        }
        protected virtual void IcerikDuzenlendinde(EventArgs args) 
        {
            if (IcerikDuzenlendi!=null)
            {
                IcerikDuzenlendi(this, args);
            }
        }

        private void PizzaCesitleriListele()
        {
            cboPizzaCesidi.DataSource = db.PizzaCesitler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtCesitAd.Text == "")
            {
                MessageBox.Show("Pizza Adı boş bırakılamaz");
                return;
            }

            db.PizzaCesitler.Add(new PizzaCesit { PizzaAd = txtCesitAd.Text });
            db.SaveChanges();
            txtCesitAd.Clear();
            PizzaCesitleriListele();

            IcerikDuzenlendinde(EventArgs.Empty);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            PizzaCesit secilen = (PizzaCesit)cboPizzaCesidi.SelectedItem;

            foreach (var item in db.Siparisler.ToList())
            {
                if (item.PizzaCesitId == secilen.Id)
                {
                    MessageBox.Show("Bu Pizzayı içeren sipariş var.");
                    return;
                }
            }

            db.PizzaCesitler.Remove(secilen);
            db.SaveChanges();
            PizzaCesitleriListele();
            IcerikDuzenlendinde(EventArgs.Empty);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
            btnDuzenle.Enabled = false;
            btnIptal.Visible = true;
            btnKaydet.Visible = true;
            btnEkle.Visible = false;
            txtCesitAd.Text = cboPizzaCesidi.SelectedItem.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtCesitAd.Text == "")
            {
                MessageBox.Show("Pizza Adı boş bırakılamaz");
                return;
            }
            PizzaCesit pizza = (PizzaCesit)cboPizzaCesidi.SelectedItem;
            pizza.PizzaAd = txtCesitAd.Text;
            db.SaveChanges();
            PizzaCesitleriListele();
            DuzenlemeModundanCik();

            IcerikDuzenlendinde(EventArgs.Empty);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            PizzaCesitleriListele();
            DuzenlemeModundanCik();
        }

        private void DuzenlemeModundanCik()
        {
            btnEkle.Visible = true;
            btnIptal.Visible = false;
            btnKaydet.Visible = false;
            btnSil.Enabled = true;
            btnDuzenle.Enabled = true;
            txtCesitAd.Clear();

        }

        private void cboPizzaCesidi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DuzenlemeModundanCik();
        }



    }
}
