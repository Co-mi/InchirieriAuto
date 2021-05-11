
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
            this.SuspendLayout();
            // 
            // lblTitluAcasa
            // 
            this.lblTitluAcasa.AutoSize = true;
            this.lblTitluAcasa.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitluAcasa.ForeColor = System.Drawing.Color.White;
            this.lblTitluAcasa.Location = new System.Drawing.Point(195, 122);
            this.lblTitluAcasa.Name = "lblTitluAcasa";
            this.lblTitluAcasa.Size = new System.Drawing.Size(645, 100);
            this.lblTitluAcasa.TabIndex = 6;
            this.lblTitluAcasa.Text = "Bun venit in aplicatia noastra!\r\n\r\n";
            // 
            // PaginaAcasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.lblTitluAcasa);
            this.Name = "PaginaAcasa";
            this.Size = new System.Drawing.Size(1015, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitluAcasa;
    }
}
