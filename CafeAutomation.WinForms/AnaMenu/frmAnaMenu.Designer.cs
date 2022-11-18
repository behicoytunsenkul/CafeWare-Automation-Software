
namespace CafeAutomation.WinForms.AnaMenu
{
    partial class frmAnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMasalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMasaHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuler = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunlerr = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullanicilar = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoller = new DevExpress.XtraBars.BarButtonItem();
            this.btnDobiz = new DevExpress.XtraBars.BarButtonItem();
            this.btnYardim = new DevExpress.XtraBars.BarButtonItem();
            this.btnHakkimizda = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Masalar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnMasalar,
            this.btnMasaHareketleri,
            this.btnMenuler,
            this.btnMenuHareketleri,
            this.btnUrunlerr,
            this.btnUrunHareketleri,
            this.btnKullanicilar,
            this.btnKullaniciHareketleri,
            this.btnRoller,
            this.btnDobiz,
            this.btnYardim,
            this.btnHakkimizda});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1586, 209);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnMasalar
            // 
            this.btnMasalar.Caption = "Masalar";
            this.btnMasalar.Id = 1;
            this.btnMasalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMasalar.ImageOptions.Image")));
            this.btnMasalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMasalar.ImageOptions.LargeImage")));
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMasalar_ItemClick);
            // 
            // btnMasaHareketleri
            // 
            this.btnMasaHareketleri.Caption = "Masa Hareketlleri";
            this.btnMasaHareketleri.Id = 2;
            this.btnMasaHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMasaHareketleri.ImageOptions.Image")));
            this.btnMasaHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMasaHareketleri.ImageOptions.LargeImage")));
            this.btnMasaHareketleri.Name = "btnMasaHareketleri";
            // 
            // btnMenuler
            // 
            this.btnMenuler.Caption = "Menuler";
            this.btnMenuler.Id = 3;
            this.btnMenuler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenuler.ImageOptions.SvgImage")));
            this.btnMenuler.Name = "btnMenuler";
            this.btnMenuler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenuler_ItemClick);
            // 
            // btnMenuHareketleri
            // 
            this.btnMenuHareketleri.Caption = "Menu Hareketleri";
            this.btnMenuHareketleri.Id = 4;
            this.btnMenuHareketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenuHareketleri.ImageOptions.SvgImage")));
            this.btnMenuHareketleri.Name = "btnMenuHareketleri";
            this.btnMenuHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenuHareketleri_ItemClick);
            // 
            // btnUrunlerr
            // 
            this.btnUrunlerr.Caption = "Ürünler";
            this.btnUrunlerr.Id = 5;
            this.btnUrunlerr.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunlerr.ImageOptions.Image")));
            this.btnUrunlerr.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunlerr.ImageOptions.LargeImage")));
            this.btnUrunlerr.Name = "btnUrunlerr";
            this.btnUrunlerr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunlerr_ItemClick);
            // 
            // btnUrunHareketleri
            // 
            this.btnUrunHareketleri.Caption = "Ürün Hareketleri";
            this.btnUrunHareketleri.Id = 6;
            this.btnUrunHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunHareketleri.ImageOptions.Image")));
            this.btnUrunHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunHareketleri.ImageOptions.LargeImage")));
            this.btnUrunHareketleri.Name = "btnUrunHareketleri";
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Caption = "Kullanıcıllar";
            this.btnKullanicilar.Id = 7;
            this.btnKullanicilar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanicilar.ImageOptions.Image")));
            this.btnKullanicilar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullanicilar.ImageOptions.LargeImage")));
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullanicilar_ItemClick);
            // 
            // btnKullaniciHareketleri
            // 
            this.btnKullaniciHareketleri.Caption = "Kullanıcı Hareketleri";
            this.btnKullaniciHareketleri.Id = 8;
            this.btnKullaniciHareketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKullaniciHareketleri.ImageOptions.SvgImage")));
            this.btnKullaniciHareketleri.Name = "btnKullaniciHareketleri";
            // 
            // btnRoller
            // 
            this.btnRoller.Caption = "Gorev Tanımla";
            this.btnRoller.Id = 9;
            this.btnRoller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoller.ImageOptions.Image")));
            this.btnRoller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRoller.ImageOptions.LargeImage")));
            this.btnRoller.Name = "btnRoller";
            // 
            // btnDobiz
            // 
            this.btnDobiz.Caption = "Döviz İşlemleri";
            this.btnDobiz.Id = 10;
            this.btnDobiz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDobiz.ImageOptions.Image")));
            this.btnDobiz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDobiz.ImageOptions.LargeImage")));
            this.btnDobiz.Name = "btnDobiz";
            // 
            // btnYardim
            // 
            this.btnYardim.Caption = "Yardım Aracı";
            this.btnYardim.Id = 11;
            this.btnYardim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYardim.ImageOptions.Image")));
            this.btnYardim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYardim.ImageOptions.LargeImage")));
            this.btnYardim.Name = "btnYardim";
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Caption = "Bilgi Servisi";
            this.btnHakkimizda.Id = 12;
            this.btnHakkimizda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHakkimizda.ImageOptions.Image")));
            this.btnHakkimizda.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHakkimizda.ImageOptions.LargeImage")));
            this.btnHakkimizda.Name = "btnHakkimizda";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Masalar,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cafe İşlemleri";
            // 
            // Masalar
            // 
            this.Masalar.ItemLinks.Add(this.btnMasalar);
            this.Masalar.ItemLinks.Add(this.btnMasaHareketleri);
            this.Masalar.Name = "Masalar";
            this.Masalar.Text = "Masalar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMenuler);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMenuHareketleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Menuler";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnUrunlerr);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnUrunHareketleri);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Urunler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKullanicilar);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKullaniciHareketleri);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnRoller);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Kullanıcılar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ayarlar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDobiz);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYardim);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHakkimizda);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ayarkar";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 738);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1586, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::CafeAutomation.WinForms.Properties.Resources.coffee_cup;
            this.IsMdiContainer = true;
            this.Name = "frmAnaMenu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "CafeWare";
            this.Load += new System.EventHandler(this.frmAnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnMasalar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Masalar;
        private DevExpress.XtraBars.BarButtonItem btnMasaHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnMenuler;
        private DevExpress.XtraBars.BarButtonItem btnMenuHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnUrunlerr;
        private DevExpress.XtraBars.BarButtonItem btnUrunHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnKullanicilar;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnRoller;
        private DevExpress.XtraBars.BarButtonItem btnDobiz;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnYardim;
        private DevExpress.XtraBars.BarButtonItem btnHakkimizda;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.Label label1;
    }
}