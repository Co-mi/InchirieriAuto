﻿
namespace InterfazaUtilizator_WindowsForms
{
    partial class PaginaInchirieri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbAdaugaInchiriere = new System.Windows.Forms.GroupBox();
            this.lblSerieMasina = new System.Windows.Forms.Label();
            this.txtSerieMasina = new System.Windows.Forms.TextBox();
            this.txtCNPClient = new System.Windows.Forms.TextBox();
            this.dtpDataTer = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInc = new System.Windows.Forms.DateTimePicker();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lblCNPClient = new System.Windows.Forms.Label();
            this.lblDataTer = new System.Windows.Forms.Label();
            this.lblDataInc = new System.Windows.Forms.Label();
            this.lblTitluAngajat = new System.Windows.Forms.Label();
            this.grbAfiseazaInchirieri = new System.Windows.Forms.GroupBox();
            this.dgvInchirieri = new System.Windows.Forms.DataGridView();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.grbAdaugaInchiriere.SuspendLayout();
            this.grbAfiseazaInchirieri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInchirieri)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAdaugaInchiriere
            // 
            this.grbAdaugaInchiriere.Controls.Add(this.lblSerieMasina);
            this.grbAdaugaInchiriere.Controls.Add(this.txtSerieMasina);
            this.grbAdaugaInchiriere.Controls.Add(this.txtCNPClient);
            this.grbAdaugaInchiriere.Controls.Add(this.dtpDataTer);
            this.grbAdaugaInchiriere.Controls.Add(this.dtpDataInc);
            this.grbAdaugaInchiriere.Controls.Add(this.lblMesaj);
            this.grbAdaugaInchiriere.Controls.Add(this.btnAdaugare);
            this.grbAdaugaInchiriere.Controls.Add(this.lblCNPClient);
            this.grbAdaugaInchiriere.Controls.Add(this.lblDataTer);
            this.grbAdaugaInchiriere.Controls.Add(this.lblDataInc);
            this.grbAdaugaInchiriere.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdaugaInchiriere.ForeColor = System.Drawing.Color.White;
            this.grbAdaugaInchiriere.Location = new System.Drawing.Point(26, 47);
            this.grbAdaugaInchiriere.Name = "grbAdaugaInchiriere";
            this.grbAdaugaInchiriere.Size = new System.Drawing.Size(221, 285);
            this.grbAdaugaInchiriere.TabIndex = 24;
            this.grbAdaugaInchiriere.TabStop = false;
            this.grbAdaugaInchiriere.Text = "Adaugare inchiriere";
            // 
            // lblSerieMasina
            // 
            this.lblSerieMasina.AutoSize = true;
            this.lblSerieMasina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerieMasina.ForeColor = System.Drawing.Color.White;
            this.lblSerieMasina.Location = new System.Drawing.Point(6, 99);
            this.lblSerieMasina.Name = "lblSerieMasina";
            this.lblSerieMasina.Size = new System.Drawing.Size(85, 21);
            this.lblSerieMasina.TabIndex = 34;
            this.lblSerieMasina.Text = "Serie msn.";
            // 
            // txtSerieMasina
            // 
            this.txtSerieMasina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSerieMasina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerieMasina.ForeColor = System.Drawing.Color.White;
            this.txtSerieMasina.Location = new System.Drawing.Point(94, 96);
            this.txtSerieMasina.MaxLength = 17;
            this.txtSerieMasina.Name = "txtSerieMasina";
            this.txtSerieMasina.Size = new System.Drawing.Size(120, 27);
            this.txtSerieMasina.TabIndex = 33;
            // 
            // txtCNPClient
            // 
            this.txtCNPClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCNPClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPClient.ForeColor = System.Drawing.Color.White;
            this.txtCNPClient.Location = new System.Drawing.Point(94, 61);
            this.txtCNPClient.MaxLength = 13;
            this.txtCNPClient.Name = "txtCNPClient";
            this.txtCNPClient.Size = new System.Drawing.Size(120, 27);
            this.txtCNPClient.TabIndex = 32;
            // 
            // dtpDataTer
            // 
            this.dtpDataTer.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dtpDataTer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataTer.Location = new System.Drawing.Point(94, 164);
            this.dtpDataTer.MinDate = new System.DateTime(2021, 5, 30, 0, 0, 0, 0);
            this.dtpDataTer.Name = "dtpDataTer";
            this.dtpDataTer.Size = new System.Drawing.Size(120, 21);
            this.dtpDataTer.TabIndex = 30;
            // 
            // dtpDataInc
            // 
            this.dtpDataInc.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dtpDataInc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInc.Location = new System.Drawing.Point(96, 130);
            this.dtpDataInc.MinDate = new System.DateTime(2021, 5, 30, 0, 0, 0, 0);
            this.dtpDataInc.Name = "dtpDataInc";
            this.dtpDataInc.Size = new System.Drawing.Size(118, 21);
            this.dtpDataInc.TabIndex = 29;
            this.dtpDataInc.Value = new System.DateTime(2021, 5, 30, 0, 0, 0, 0);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(9, 222);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj.TabIndex = 18;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.ForeColor = System.Drawing.Color.White;
            this.btnAdaugare.Location = new System.Drawing.Point(128, 246);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(86, 32);
            this.btnAdaugare.TabIndex = 4;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lblCNPClient
            // 
            this.lblCNPClient.AutoSize = true;
            this.lblCNPClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPClient.ForeColor = System.Drawing.Color.White;
            this.lblCNPClient.Location = new System.Drawing.Point(8, 64);
            this.lblCNPClient.Name = "lblCNPClient";
            this.lblCNPClient.Size = new System.Drawing.Size(44, 21);
            this.lblCNPClient.TabIndex = 10;
            this.lblCNPClient.Text = "CNP";
            // 
            // lblDataTer
            // 
            this.lblDataTer.AutoSize = true;
            this.lblDataTer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTer.ForeColor = System.Drawing.Color.White;
            this.lblDataTer.Location = new System.Drawing.Point(8, 164);
            this.lblDataTer.Name = "lblDataTer";
            this.lblDataTer.Size = new System.Drawing.Size(81, 21);
            this.lblDataTer.TabIndex = 14;
            this.lblDataTer.Text = "Data ter.";
            // 
            // lblDataInc
            // 
            this.lblDataInc.AutoSize = true;
            this.lblDataInc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInc.ForeColor = System.Drawing.Color.White;
            this.lblDataInc.Location = new System.Drawing.Point(8, 130);
            this.lblDataInc.Name = "lblDataInc";
            this.lblDataInc.Size = new System.Drawing.Size(82, 21);
            this.lblDataInc.TabIndex = 13;
            this.lblDataInc.Text = "Data inc.";
        
            // 
            // lblTitluAngajat
            // 
            this.lblTitluAngajat.AutoSize = true;
            this.lblTitluAngajat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitluAngajat.ForeColor = System.Drawing.Color.White;
            this.lblTitluAngajat.Location = new System.Drawing.Point(21, 22);
            this.lblTitluAngajat.Name = "lblTitluAngajat";
            this.lblTitluAngajat.Size = new System.Drawing.Size(156, 22);
            this.lblTitluAngajat.TabIndex = 25;
            this.lblTitluAngajat.Text = "Meniu - Inchirieri";
            // 
            // grbAfiseazaInchirieri
            // 
            this.grbAfiseazaInchirieri.Controls.Add(this.btnStergere);
            this.grbAfiseazaInchirieri.Controls.Add(this.dgvInchirieri);
            this.grbAfiseazaInchirieri.Controls.Add(this.btnAfisare);
            this.grbAfiseazaInchirieri.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAfiseazaInchirieri.ForeColor = System.Drawing.Color.White;
            this.grbAfiseazaInchirieri.Location = new System.Drawing.Point(253, 47);
            this.grbAfiseazaInchirieri.Name = "grbAfiseazaInchirieri";
            this.grbAfiseazaInchirieri.Size = new System.Drawing.Size(573, 285);
            this.grbAfiseazaInchirieri.TabIndex = 26;
            this.grbAfiseazaInchirieri.TabStop = false;
            this.grbAfiseazaInchirieri.Text = "Afiseaza inchirieri";
            // 
            // dgvInchirieri
            // 
            this.dgvInchirieri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInchirieri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInchirieri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInchirieri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInchirieri.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInchirieri.Location = new System.Drawing.Point(7, 30);
            this.dgvInchirieri.Name = "dgvInchirieri";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInchirieri.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInchirieri.Size = new System.Drawing.Size(560, 209);
            this.dgvInchirieri.TabIndex = 6;
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAfisare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfisare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.ForeColor = System.Drawing.Color.White;
            this.btnAfisare.Location = new System.Drawing.Point(480, 246);
            this.btnAfisare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(86, 32);
            this.btnAfisare.TabIndex = 5;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Location = new System.Drawing.Point(7, 246);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(4);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(86, 32);
            this.btnStergere.TabIndex = 9;
            this.btnStergere.Text = "Sterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // PaginaInchirieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.grbAfiseazaInchirieri);
            this.Controls.Add(this.lblTitluAngajat);
            this.Controls.Add(this.grbAdaugaInchiriere);
            this.Name = "PaginaInchirieri";
            this.Size = new System.Drawing.Size(887, 426);
            this.grbAdaugaInchiriere.ResumeLayout(false);
            this.grbAdaugaInchiriere.PerformLayout();
            this.grbAfiseazaInchirieri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInchirieri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdaugaInchiriere;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label lblCNPClient;
        private System.Windows.Forms.Label lblDataTer;
        private System.Windows.Forms.Label lblDataInc;
        private System.Windows.Forms.DateTimePicker dtpDataInc;
        private System.Windows.Forms.DateTimePicker dtpDataTer;
        private System.Windows.Forms.Label lblTitluAngajat;
        private System.Windows.Forms.GroupBox grbAfiseazaInchirieri;
        private System.Windows.Forms.DataGridView dgvInchirieri;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.TextBox txtCNPClient;
        private System.Windows.Forms.Label lblSerieMasina;
        private System.Windows.Forms.TextBox txtSerieMasina;
        private System.Windows.Forms.Button btnStergere;
    }
}
