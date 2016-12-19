namespace A_Otobus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelOtobusTuru = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.PanelTravego = new System.Windows.Forms.Panel();
            this.PanelSetra = new System.Windows.Forms.Panel();
            this.GBoxMüşteriBilg = new System.Windows.Forms.GroupBox();
            this.TxtYolcuIsim = new System.Windows.Forms.TextBox();
            this.YolcuAdi = new System.Windows.Forms.Label();
            this.RbtnKadin = new System.Windows.Forms.RadioButton();
            this.RBtnErkek = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBoxMüşteriBilg.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelOtobusTuru
            // 
            this.LabelOtobusTuru.AutoSize = true;
            this.LabelOtobusTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelOtobusTuru.Location = new System.Drawing.Point(21, 100);
            this.LabelOtobusTuru.Name = "LabelOtobusTuru";
            this.LabelOtobusTuru.Size = new System.Drawing.Size(83, 13);
            this.LabelOtobusTuru.TabIndex = 0;
            this.LabelOtobusTuru.Text = "Otobüs Seçin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(12, 128);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(121, 21);
            this.CBoxOtobusTuru.TabIndex = 2;
            this.CBoxOtobusTuru.SelectedIndexChanged += new System.EventHandler(this.CBoxOtobusTuru_SelectedIndexChanged);
            // 
            // PanelTravego
            // 
            this.PanelTravego.Location = new System.Drawing.Point(139, 88);
            this.PanelTravego.Name = "PanelTravego";
            this.PanelTravego.Size = new System.Drawing.Size(200, 344);
            this.PanelTravego.TabIndex = 3;
            // 
            // PanelSetra
            // 
            this.PanelSetra.Location = new System.Drawing.Point(136, 88);
            this.PanelSetra.Name = "PanelSetra";
            this.PanelSetra.Size = new System.Drawing.Size(200, 344);
            this.PanelSetra.TabIndex = 4;
            // 
            // GBoxMüşteriBilg
            // 
            this.GBoxMüşteriBilg.Controls.Add(this.RBtnErkek);
            this.GBoxMüşteriBilg.Controls.Add(this.RbtnKadin);
            this.GBoxMüşteriBilg.Controls.Add(this.YolcuAdi);
            this.GBoxMüşteriBilg.Controls.Add(this.TxtYolcuIsim);
            this.GBoxMüşteriBilg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBoxMüşteriBilg.Location = new System.Drawing.Point(342, 100);
            this.GBoxMüşteriBilg.Name = "GBoxMüşteriBilg";
            this.GBoxMüşteriBilg.Size = new System.Drawing.Size(200, 164);
            this.GBoxMüşteriBilg.TabIndex = 5;
            this.GBoxMüşteriBilg.TabStop = false;
            this.GBoxMüşteriBilg.Text = "Müşteri Bilgileri";
            // 
            // TxtYolcuIsim
            // 
            this.TxtYolcuIsim.Location = new System.Drawing.Point(6, 39);
            this.TxtYolcuIsim.Name = "TxtYolcuIsim";
            this.TxtYolcuIsim.Size = new System.Drawing.Size(145, 20);
            this.TxtYolcuIsim.TabIndex = 0;
            // 
            // YolcuAdi
            // 
            this.YolcuAdi.AutoSize = true;
            this.YolcuAdi.Location = new System.Drawing.Point(6, 23);
            this.YolcuAdi.Name = "YolcuAdi";
            this.YolcuAdi.Size = new System.Drawing.Size(61, 13);
            this.YolcuAdi.TabIndex = 1;
            this.YolcuAdi.Text = "Ad Soyad";
            // 
            // RbtnKadin
            // 
            this.RbtnKadin.AutoSize = true;
            this.RbtnKadin.Location = new System.Drawing.Point(23, 93);
            this.RbtnKadin.Name = "RbtnKadin";
            this.RbtnKadin.Size = new System.Drawing.Size(57, 17);
            this.RbtnKadin.TabIndex = 2;
            this.RbtnKadin.TabStop = true;
            this.RbtnKadin.Text = "Kadın";
            this.RbtnKadin.UseVisualStyleBackColor = true;
            // 
            // RBtnErkek
            // 
            this.RBtnErkek.AutoSize = true;
            this.RBtnErkek.Location = new System.Drawing.Point(93, 93);
            this.RBtnErkek.Name = "RBtnErkek";
            this.RBtnErkek.Size = new System.Drawing.Size(58, 17);
            this.RBtnErkek.TabIndex = 3;
            this.RBtnErkek.TabStop = true;
            this.RBtnErkek.Text = "Erkek";
            this.RBtnErkek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 465);
            this.Controls.Add(this.GBoxMüşteriBilg);
            this.Controls.Add(this.PanelSetra);
            this.Controls.Add(this.PanelTravego);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelOtobusTuru);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBoxMüşteriBilg.ResumeLayout(false);
            this.GBoxMüşteriBilg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelOtobusTuru;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
        private System.Windows.Forms.Panel PanelTravego;
        private System.Windows.Forms.Panel PanelSetra;
        private System.Windows.Forms.GroupBox GBoxMüşteriBilg;
        private System.Windows.Forms.Label YolcuAdi;
        private System.Windows.Forms.TextBox TxtYolcuIsim;
        private System.Windows.Forms.RadioButton RBtnErkek;
        private System.Windows.Forms.RadioButton RbtnKadin;
    }
}

