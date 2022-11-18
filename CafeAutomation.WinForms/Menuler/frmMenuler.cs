using CafeAutomation.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomation.WinForms.Menuler
{
    public partial class frmMenuler : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();

        public frmMenuler()
        {
            InitializeComponent();
            context.Menu.Load();
            gridControl1.DataSource = context.Menu.Local.ToBindingList();
        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan menü silinecek, emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}