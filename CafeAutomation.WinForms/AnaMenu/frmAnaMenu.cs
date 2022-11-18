using CafeAutomation.WinForms.Kullanicilar;
using CafeAutomation.WinForms.Masalar;
using CafeAutomation.WinForms.Menuler;
using CafeAutomation.WinForms.Urunler;
using DevExpress.XtraBars;
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

namespace CafeAutomation.WinForms.AnaMenu
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        public frmAnaMenu()
        {
            InitializeComponent();
            frmKullaniciGiris frm = new frmKullaniciGiris();
            frm.ShowDialog();
        }

        private void btnUrunlerr_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUrunler frm = new frmUrunler();
            FormGetir(frm);
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuler_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMenuler frm = new frmMenuler();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMasalar_ItemClick(object sender, ItemClickEventArgs e)//MASA EKRANINA GECIS SAGLAR
        {
            frmMasalar frm = new frmMasalar();
            FormGetir(frm);
        }

        private void btnKullanicilar_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnMenuHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}