namespace KentKart_OOP
{
    partial class Form1
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
            this.GBoxKartOlustur = new System.Windows.Forms.GroupBox();
            this.RadioBtnTam = new System.Windows.Forms.RadioButton();
            this.RadioBtnOgrenci = new System.Windows.Forms.RadioButton();
            this.RadioBtnOgretmen = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblYolcular = new System.Windows.Forms.Label();
            this.LstBoxYolcular = new System.Windows.Forms.ListBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.TxtOkulAdi = new System.Windows.Forms.TextBox();
            this.GBoxOkulAdi = new System.Windows.Forms.GroupBox();
            this.GBoxKartOlustur.SuspendLayout();
            this.GBoxOkulAdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxKartOlustur
            // 
            this.GBoxKartOlustur.Controls.Add(this.GBoxOkulAdi);
            this.GBoxKartOlustur.Controls.Add(this.button1);
            this.GBoxKartOlustur.Controls.Add(this.RadioBtnOgrenci);
            this.GBoxKartOlustur.Controls.Add(this.RadioBtnOgretmen);
            this.GBoxKartOlustur.Controls.Add(this.RadioBtnTam);
            this.GBoxKartOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBoxKartOlustur.Location = new System.Drawing.Point(0, 0);
            this.GBoxKartOlustur.Name = "GBoxKartOlustur";
            this.GBoxKartOlustur.Size = new System.Drawing.Size(332, 163);
            this.GBoxKartOlustur.TabIndex = 0;
            this.GBoxKartOlustur.TabStop = false;
            this.GBoxKartOlustur.Text = "Kart Oluştur";
            // 
            // RadioBtnTam
            // 
            this.RadioBtnTam.AutoSize = true;
            this.RadioBtnTam.Location = new System.Drawing.Point(0, 62);
            this.RadioBtnTam.Name = "RadioBtnTam";
            this.RadioBtnTam.Size = new System.Drawing.Size(49, 17);
            this.RadioBtnTam.TabIndex = 0;
            this.RadioBtnTam.TabStop = true;
            this.RadioBtnTam.Text = "Tam";
            this.RadioBtnTam.UseVisualStyleBackColor = true;
            // 
            // RadioBtnOgrenci
            // 
            this.RadioBtnOgrenci.AutoSize = true;
            this.RadioBtnOgrenci.Location = new System.Drawing.Point(0, 16);
            this.RadioBtnOgrenci.Name = "RadioBtnOgrenci";
            this.RadioBtnOgrenci.Size = new System.Drawing.Size(69, 17);
            this.RadioBtnOgrenci.TabIndex = 0;
            this.RadioBtnOgrenci.TabStop = true;
            this.RadioBtnOgrenci.Text = "Öğrenci";
            this.RadioBtnOgrenci.UseVisualStyleBackColor = true;
            // 
            // RadioBtnOgretmen
            // 
            this.RadioBtnOgretmen.AutoSize = true;
            this.RadioBtnOgretmen.Location = new System.Drawing.Point(0, 39);
            this.RadioBtnOgretmen.Name = "RadioBtnOgretmen";
            this.RadioBtnOgretmen.Size = new System.Drawing.Size(79, 17);
            this.RadioBtnOgretmen.TabIndex = 0;
            this.RadioBtnOgretmen.TabStop = true;
            this.RadioBtnOgretmen.Text = "Öğretmen";
            this.RadioBtnOgretmen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblYolcular
            // 
            this.lblYolcular.AutoSize = true;
            this.lblYolcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYolcular.Location = new System.Drawing.Point(3, 182);
            this.lblYolcular.Name = "lblYolcular";
            this.lblYolcular.Size = new System.Drawing.Size(53, 13);
            this.lblYolcular.TabIndex = 2;
            this.lblYolcular.Text = "Yolcular";
            // 
            // LstBoxYolcular
            // 
            this.LstBoxYolcular.FormattingEnabled = true;
            this.LstBoxYolcular.Location = new System.Drawing.Point(6, 198);
            this.LstBoxYolcular.Name = "LstBoxYolcular";
            this.LstBoxYolcular.Size = new System.Drawing.Size(153, 95);
            this.LstBoxYolcular.TabIndex = 3;
            this.LstBoxYolcular.DoubleClick += new System.EventHandler(this.LstBoxYolcular_DoubleClick);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(177, 6);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(39, 13);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "Bakiye";
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Location = new System.Drawing.Point(180, 27);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(119, 20);
            this.TxtBakiye.TabIndex = 5;
            // 
            // TxtOkulAdi
            // 
            this.TxtOkulAdi.Location = new System.Drawing.Point(15, 34);
            this.TxtOkulAdi.Name = "TxtOkulAdi";
            this.TxtOkulAdi.Size = new System.Drawing.Size(119, 20);
            this.TxtOkulAdi.TabIndex = 5;
            // 
            // GBoxOkulAdi
            // 
            this.GBoxOkulAdi.Controls.Add(this.TxtOkulAdi);
            this.GBoxOkulAdi.Location = new System.Drawing.Point(170, 62);
            this.GBoxOkulAdi.Name = "GBoxOkulAdi";
            this.GBoxOkulAdi.Size = new System.Drawing.Size(147, 69);
            this.GBoxOkulAdi.TabIndex = 6;
            this.GBoxOkulAdi.TabStop = false;
            this.GBoxOkulAdi.Text = "Okul Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 317);
            this.Controls.Add(this.TxtBakiye);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.LstBoxYolcular);
            this.Controls.Add(this.lblYolcular);
            this.Controls.Add(this.GBoxKartOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBoxKartOlustur.ResumeLayout(false);
            this.GBoxKartOlustur.PerformLayout();
            this.GBoxOkulAdi.ResumeLayout(false);
            this.GBoxOkulAdi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxKartOlustur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RadioBtnOgrenci;
        private System.Windows.Forms.RadioButton RadioBtnOgretmen;
        private System.Windows.Forms.RadioButton RadioBtnTam;
        private System.Windows.Forms.Label lblYolcular;
        private System.Windows.Forms.ListBox LstBoxYolcular;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox TxtBakiye;
        private System.Windows.Forms.TextBox TxtOkulAdi;
        private System.Windows.Forms.GroupBox GBoxOkulAdi;
    }
}

