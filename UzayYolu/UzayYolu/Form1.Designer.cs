namespace UzayYolu
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
            this.spaceShip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spaceShip)).BeginInit();
            this.SuspendLayout();
            // 
            // spaceShip
            // 
            this.spaceShip.Image = ((System.Drawing.Image)(resources.GetObject("spaceShip.Image")));
            this.spaceShip.InitialImage = ((System.Drawing.Image)(resources.GetObject("spaceShip.InitialImage")));
            this.spaceShip.Location = new System.Drawing.Point(0, 0);
            this.spaceShip.Name = "spaceShip";
            this.spaceShip.Size = new System.Drawing.Size(136, 122);
            this.spaceShip.TabIndex = 0;
            this.spaceShip.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 362);
            this.Controls.Add(this.spaceShip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.spaceShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox spaceShip;
    }
}

