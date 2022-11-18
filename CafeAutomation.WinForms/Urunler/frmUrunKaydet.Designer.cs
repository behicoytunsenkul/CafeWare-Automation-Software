
namespace CafeAutomation.WinForms.Urunler
{
    partial class frmUrunKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunKaydet));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpMenu = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.calcBirimFiyati3 = new DevExpress.XtraEditors.CalcEdit();
            this.calcBirimFiyati2 = new DevExpress.XtraEditors.CalcEdit();
            this.calcBirimFiyati1 = new DevExpress.XtraEditors.CalcEdit();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunKodu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(987, 108);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ürün Kayıt Ekranı";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.LightGreen;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnUrunKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 508);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(987, 163);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlemler";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(851, 41);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(123, 50);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunKaydet.ImageOptions.Image")));
            this.btnUrunKaydet.Location = new System.Drawing.Point(12, 41);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(123, 50);
            this.btnUrunKaydet.TabIndex = 0;
            this.btnUrunKaydet.Text = "Kaydet";
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(36, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(391, 31);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Menü :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(36, 150);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(391, 28);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ürün Kodu:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(36, 187);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(391, 29);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Ürün Adı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(36, 222);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(391, 30);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Birim Fiyatı1 :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(36, 258);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(391, 29);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Birim Fiyatı 2 :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(36, 293);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(391, 29);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Birim Fiyatı 3 :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.labelControl8.Appearance.Options.UseBackColor = true;
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(36, 328);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(391, 102);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Açıklama :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelControl9.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.labelControl9.Appearance.Options.UseBackColor = true;
            this.labelControl9.Appearance.Options.UseBorderColor = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(36, 436);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(391, 32);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Tarih :";
            // 
            // lookUpMenu
            // 
            this.lookUpMenu.Location = new System.Drawing.Point(444, 114);
            this.lookUpMenu.Name = "lookUpMenu";
            this.lookUpMenu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lookUpMenu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.2F);
            this.lookUpMenu.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpMenu.Properties.Appearance.Options.UseFont = true;
            this.lookUpMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMenu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuAdi", "Menü")});
            this.lookUpMenu.Properties.DisplayMember = "MenuAdi";
            this.lookUpMenu.Properties.NullText = "Bir Menü Seçiniz";
            this.lookUpMenu.Properties.NullValuePrompt = "Bir Menü Seçiniz";
            this.lookUpMenu.Properties.ValueMember = "Id";
            this.lookUpMenu.Size = new System.Drawing.Size(274, 24);
            this.lookUpMenu.TabIndex = 11;
            this.lookUpMenu.EditValueChanged += new System.EventHandler(this.lookUpMenu_EditValueChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(735, 111);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.NullText = "Buradan Resim Ekleyebilirsiniz";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(190, 211);
            this.pictureEdit1.TabIndex = 10;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(444, 441);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(232, 22);
            this.dateEdit1.TabIndex = 9;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(444, 328);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAciklama.Properties.Appearance.Options.UseBackColor = true;
            this.txtAciklama.Size = new System.Drawing.Size(481, 102);
            this.txtAciklama.TabIndex = 8;
            // 
            // calcBirimFiyati3
            // 
            this.calcBirimFiyati3.Location = new System.Drawing.Point(444, 300);
            this.calcBirimFiyati3.Name = "calcBirimFiyati3";
            this.calcBirimFiyati3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calcBirimFiyati3.Properties.Appearance.Options.UseBackColor = true;
            this.calcBirimFiyati3.Properties.Appearance.Options.UseTextOptions = true;
            this.calcBirimFiyati3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcBirimFiyati3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBirimFiyati3.Properties.DisplayFormat.FormatString = "C2";
            this.calcBirimFiyati3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcBirimFiyati3.Properties.NullText = "0,00";
            this.calcBirimFiyati3.Size = new System.Drawing.Size(274, 22);
            this.calcBirimFiyati3.TabIndex = 7;
            this.calcBirimFiyati3.EditValueChanged += new System.EventHandler(this.calcBirimFiyati3_EditValueChanged);
            // 
            // calcBirimFiyati2
            // 
            this.calcBirimFiyati2.Location = new System.Drawing.Point(444, 262);
            this.calcBirimFiyati2.Name = "calcBirimFiyati2";
            this.calcBirimFiyati2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calcBirimFiyati2.Properties.Appearance.Options.UseBackColor = true;
            this.calcBirimFiyati2.Properties.Appearance.Options.UseTextOptions = true;
            this.calcBirimFiyati2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcBirimFiyati2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBirimFiyati2.Properties.DisplayFormat.FormatString = "C2";
            this.calcBirimFiyati2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcBirimFiyati2.Properties.NullText = "0,00";
            this.calcBirimFiyati2.Size = new System.Drawing.Size(274, 22);
            this.calcBirimFiyati2.TabIndex = 7;
            this.calcBirimFiyati2.EditValueChanged += new System.EventHandler(this.calcBirimFiyati2_EditValueChanged);
            // 
            // calcBirimFiyati1
            // 
            this.calcBirimFiyati1.Location = new System.Drawing.Point(444, 226);
            this.calcBirimFiyati1.Name = "calcBirimFiyati1";
            this.calcBirimFiyati1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calcBirimFiyati1.Properties.Appearance.Options.UseBackColor = true;
            this.calcBirimFiyati1.Properties.Appearance.Options.UseTextOptions = true;
            this.calcBirimFiyati1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcBirimFiyati1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBirimFiyati1.Properties.DisplayFormat.FormatString = "C2";
            this.calcBirimFiyati1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcBirimFiyati1.Properties.NullText = "0,00";
            this.calcBirimFiyati1.Size = new System.Drawing.Size(274, 22);
            this.calcBirimFiyati1.TabIndex = 7;
            this.calcBirimFiyati1.EditValueChanged += new System.EventHandler(this.calcBirimFiyati1_EditValueChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(444, 191);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUrunAdi.Properties.Appearance.Options.UseBackColor = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(274, 22);
            this.txtUrunAdi.TabIndex = 6;
            this.txtUrunAdi.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(444, 156);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUrunKodu.Properties.Appearance.Options.UseBackColor = true;
            this.txtUrunKodu.Size = new System.Drawing.Size(274, 22);
            this.txtUrunKodu.TabIndex = 6;
            this.txtUrunKodu.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // frmUrunKaydet
            // 
            this.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 671);
            this.Controls.Add(this.lookUpMenu);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.calcBirimFiyati3);
            this.Controls.Add(this.calcBirimFiyati2);
            this.Controls.Add(this.calcBirimFiyati1);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmUrunKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kaydetme";
            this.Load += new System.EventHandler(this.frmUrunKaydet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunKodu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnUrunKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtUrunKodu;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati1;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati2;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati3;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpMenu;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
    }
}