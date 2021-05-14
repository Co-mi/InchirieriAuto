
namespace InterfazaUtilizator_WindowsForms
{
    partial class PaginaAcasa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitluAcasa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitluAcasa
            // 
            this.lblTitluAcasa.AutoSize = true;
            this.lblTitluAcasa.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitluAcasa.ForeColor = System.Drawing.Color.White;
            this.lblTitluAcasa.Location = new System.Drawing.Point(181, 73);
            this.lblTitluAcasa.Name = "lblTitluAcasa";
            this.lblTitluAcasa.Size = new System.Drawing.Size(645, 100);
            this.lblTitluAcasa.TabIndex = 6;
            this.lblTitluAcasa.Text = "Bun venit in aplicatia noastra!\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazaUtilizator_WindowsForms.Properties.Resources.Mitsubishi_PNG_Images;
            this.pictureBox1.Location = new System.Drawing.Point(-58, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // PaginaAcasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitluAcasa);
            this.DoubleBuffered = true;
            this.Name = "PaginaAcasa";
            this.Size = new System.Drawing.Size(1015, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitluAcasa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
