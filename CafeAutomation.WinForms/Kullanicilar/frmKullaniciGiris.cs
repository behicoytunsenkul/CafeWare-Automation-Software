using CafeAutomation.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomation.WinForms.Kullanicilar
{
    public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        private bool giris;
        private CafeContext context = new CafeContext();
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void frmKullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(context.Kullacilar.Any(k=>k.KullaniciAdi==txtKullaniciAdi.Text && k.Parola==txtSifre.Text))
            {
                giris = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınızı ya da Şifrenizi yanlış girdiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}