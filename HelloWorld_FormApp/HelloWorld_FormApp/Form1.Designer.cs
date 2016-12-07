namespace HelloWorld_FormApp
{
    partial class İlkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İlkForm));
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.AdTxtB = new System.Windows.Forms.TextBox();
            this.SifreTxtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.BackgroundImage")));
            this.KaydetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.KaydetBtn.Location = new System.Drawing.Point(200, 55);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(106, 83);
            this.KaydetBtn.TabIndex = 0;
            this.KaydetBtn.UseVisualStyleBackColor = true;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // AdTxtB
            // 
            this.AdTxtB.Location = new System.Drawing.Point(63, 55);
            this.AdTxtB.Name = "AdTxtB";
            this.AdTxtB.Size = new System.Drawing.Size(131, 20);
            this.AdTxtB.TabIndex = 1;
            // 
            // SifreTxtB
            // 
            this.SifreTxtB.Location = new System.Drawing.Point(63, 118);
            this.SifreTxtB.Name = "SifreTxtB";
            this.SifreTxtB.PasswordChar = '#';
            this.SifreTxtB.Size = new System.Drawing.Size(131, 20);
            this.SifreTxtB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şifre";
            // 
            // İlkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SifreTxtB);
            this.Controls.Add(this.AdTxtB);
            this.Controls.Add(this.KaydetBtn);
            this.Name = "İlkForm";
            this.Text = "İlk Form";
            this.Load += new System.EventHandler(this.İlkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.TextBox AdTxtB;
        private System.Windows.Forms.TextBox SifreTxtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

