namespace İnsanKaynaklari_OOP
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
            this.LstBoxCalisanlar = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBoxElemanTuru = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.NumericMaas = new System.Windows.Forms.Label();
            this.NumericSskNo = new System.Windows.Forms.Label();
            this.NumericSatisAdeti = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // LstBoxCalisanlar
            // 
            this.LstBoxCalisanlar.FormattingEnabled = true;
            this.LstBoxCalisanlar.Location = new System.Drawing.Point(318, 12);
            this.LstBoxCalisanlar.Name = "LstBoxCalisanlar";
            this.LstBoxCalisanlar.Size = new System.Drawing.Size(159, 147);
            this.LstBoxCalisanlar.TabIndex = 0;
            this.LstBoxCalisanlar.SelectedIndexChanged += new System.EventHandler(this.LstBoxCalisanlar_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // ComboBoxElemanTuru
            // 
            this.ComboBoxElemanTuru.AutoSize = true;
            this.ComboBoxElemanTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBoxElemanTuru.Location = new System.Drawing.Point(28, 20);
            this.ComboBoxElemanTuru.Name = "ComboBoxElemanTuru";
            this.ComboBoxElemanTuru.Size = new System.Drawing.Size(78, 13);
            this.ComboBoxElemanTuru.TabIndex = 2;
            this.ComboBoxElemanTuru.Text = "Eleman Türü";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(136, 49);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(136, 87);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(136, 123);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown3.TabIndex = 3;
            // 
            // NumericMaas
            // 
            this.NumericMaas.AutoSize = true;
            this.NumericMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumericMaas.Location = new System.Drawing.Point(28, 56);
            this.NumericMaas.Name = "NumericMaas";
            this.NumericMaas.Size = new System.Drawing.Size(37, 13);
            this.NumericMaas.TabIndex = 2;
            this.NumericMaas.Text = "Maaş";
            // 
            // NumericSskNo
            // 
            this.NumericSskNo.AutoSize = true;
            this.NumericSskNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumericSskNo.Location = new System.Drawing.Point(28, 94);
            this.NumericSskNo.Name = "NumericSskNo";
            this.NumericSskNo.Size = new System.Drawing.Size(48, 13);
            this.NumericSskNo.TabIndex = 2;
            this.NumericSskNo.Text = "Ssk No";
            // 
            // NumericSatisAdeti
            // 
            this.NumericSatisAdeti.AutoSize = true;
            this.NumericSatisAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumericSatisAdeti.Location = new System.Drawing.Point(28, 130);
            this.NumericSatisAdeti.Name = "NumericSatisAdeti";
            this.NumericSatisAdeti.Size = new System.Drawing.Size(68, 13);
            this.NumericSatisAdeti.TabIndex = 2;
            this.NumericSatisAdeti.Text = "Satis Adeti";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(31, 162);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(260, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "EKLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 316);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.NumericSatisAdeti);
            this.Controls.Add(this.NumericSskNo);
            this.Controls.Add(this.NumericMaas);
            this.Controls.Add(this.ComboBoxElemanTuru);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LstBoxCalisanlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxCalisanlar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ComboBoxElemanTuru;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label NumericMaas;
        private System.Windows.Forms.Label NumericSskNo;
        private System.Windows.Forms.Label NumericSatisAdeti;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

