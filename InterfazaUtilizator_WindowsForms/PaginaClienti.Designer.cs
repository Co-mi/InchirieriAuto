﻿
namespace InterfazaUtilizator_WindowsForms
{
    partial class PaginaClienti
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
            this.lblTitluClient = new System.Windows.Forms.Label();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.lblPrenumeClient = new System.Windows.Forms.Label();
            this.lblNumeClient = new System.Windows.Forms.Label();
            this.txtNumeClient = new System.Windows.Forms.TextBox();
            this.txtPrenumeClient = new System.Windows.Forms.TextBox();
            this.lblCNPClient = new System.Windows.Forms.Label();
            this.lblIDClient = new System.Windows.Forms.Label();
            this.txtCNPClient = new System.Windows.Forms.TextBox();
            this.txtIDClient = new System.Windows.Forms.TextBox();
            this.grbAdaugaClient = new System.Windows.Forms.GroupBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.rtbAfiseazaClienti = new System.Windows.Forms.RichTextBox();
            this.grbAfiseazaClienti = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbCautareClient = new System.Windows.Forms.GroupBox();
            this.lblMesaj2 = new System.Windows.Forms.Label();
            this.lblPrenumeCautat = new System.Windows.Forms.Label();
            this.txtCautarePrenumeClient = new System.Windows.Forms.TextBox();
            this.lblNumeCautat = new System.Windows.Forms.Label();
            this.txtCautareNumeClient = new System.Windows.Forms.TextBox();
            this.grpOptModifClient = new System.Windows.Forms.GroupBox();
            this.lblMesaj3 = new System.Windows.Forms.Label();
            this.lblInstr = new System.Windows.Forms.Label();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.txCNP = new System.Windows.Forms.TextBox();
            this.lbNume = new System.Windows.Forms.Label();
            this.txNume = new System.Windows.Forms.TextBox();
            this.lbCNP = new System.Windows.Forms.Label();
            this.txPrenume = new System.Windows.Forms.TextBox();
            this.grbAdaugaClient.SuspendLayout();
            this.grbAfiseazaClienti.SuspendLayout();
            this.grbCautareClient.SuspendLayout();
            this.grpOptModifClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitluClient
            // 
            this.lblTitluClient.AutoSize = true;
            this.lblTitluClient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitluClient.ForeColor = System.Drawing.Color.White;
            this.lblTitluClient.Location = new System.Drawing.Point(21, 22);
            this.lblTitluClient.Name = "lblTitluClient";
            this.lblTitluClient.Size = new System.Drawing.Size(137, 22);
            this.lblTitluClient.TabIndex = 0;
            this.lblTitluClient.Text = "Meniu - Clienti";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.ForeColor = System.Drawing.Color.White;
            this.btnAdaugare.Location = new System.Drawing.Point(128, 224);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(86, 32);
            this.btnAdaugare.TabIndex = 4;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnModificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificare.ForeColor = System.Drawing.Color.White;
            this.btnModificare.Location = new System.Drawing.Point(531, 25);
            this.btnModificare.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(86, 32);
            this.btnModificare.TabIndex = 7;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = false;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAfisare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfisare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.ForeColor = System.Drawing.Color.White;
            this.btnAfisare.Location = new System.Drawing.Point(480, 137);
            this.btnAfisare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(86, 32);
            this.btnAfisare.TabIndex = 5;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnCautare
            // 
            this.btnCautare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCautare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautare.ForeColor = System.Drawing.Color.White;
            this.btnCautare.Location = new System.Drawing.Point(437, 25);
            this.btnCautare.Margin = new System.Windows.Forms.Padding(4);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(86, 32);
            this.btnCautare.TabIndex = 6;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = false;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // lblPrenumeClient
            // 
            this.lblPrenumeClient.AutoSize = true;
            this.lblPrenumeClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenumeClient.ForeColor = System.Drawing.Color.White;
            this.lblPrenumeClient.Location = new System.Drawing.Point(8, 95);
            this.lblPrenumeClient.Name = "lblPrenumeClient";
            this.lblPrenumeClient.Size = new System.Drawing.Size(79, 21);
            this.lblPrenumeClient.TabIndex = 9;
            this.lblPrenumeClient.Text = "Prenume";
            // 
            // lblNumeClient
            // 
            this.lblNumeClient.AutoSize = true;
            this.lblNumeClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeClient.ForeColor = System.Drawing.Color.White;
            this.lblNumeClient.Location = new System.Drawing.Point(8, 64);
            this.lblNumeClient.Name = "lblNumeClient";
            this.lblNumeClient.Size = new System.Drawing.Size(57, 21);
            this.lblNumeClient.TabIndex = 10;
            this.lblNumeClient.Text = "Nume";
            // 
            // txtNumeClient
            // 
            this.txtNumeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNumeClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeClient.ForeColor = System.Drawing.Color.White;
            this.txtNumeClient.Location = new System.Drawing.Point(94, 61);
            this.txtNumeClient.MaxLength = 30;
            this.txtNumeClient.Name = "txtNumeClient";
            this.txtNumeClient.Size = new System.Drawing.Size(120, 27);
            this.txtNumeClient.TabIndex = 11;
            // 
            // txtPrenumeClient
            // 
            this.txtPrenumeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPrenumeClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenumeClient.ForeColor = System.Drawing.Color.White;
            this.txtPrenumeClient.Location = new System.Drawing.Point(94, 96);
            this.txtPrenumeClient.MaxLength = 30;
            this.txtPrenumeClient.Name = "txtPrenumeClient";
            this.txtPrenumeClient.Size = new System.Drawing.Size(120, 27);
            this.txtPrenumeClient.TabIndex = 12;
            // 
            // lblCNPClient
            // 
            this.lblCNPClient.AutoSize = true;
            this.lblCNPClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPClient.ForeColor = System.Drawing.Color.White;
            this.lblCNPClient.Location = new System.Drawing.Point(8, 130);
            this.lblCNPClient.Name = "lblCNPClient";
            this.lblCNPClient.Size = new System.Drawing.Size(44, 21);
            this.lblCNPClient.TabIndex = 13;
            this.lblCNPClient.Text = "CNP";
            // 
            // lblIDClient
            // 
            this.lblIDClient.AutoSize = true;
            this.lblIDClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDClient.ForeColor = System.Drawing.Color.White;
            this.lblIDClient.Location = new System.Drawing.Point(8, 168);
            this.lblIDClient.Name = "lblIDClient";
            this.lblIDClient.Size = new System.Drawing.Size(27, 21);
            this.lblIDClient.TabIndex = 14;
            this.lblIDClient.Text = "ID";
            // 
            // txtCNPClient
            // 
            this.txtCNPClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCNPClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPClient.ForeColor = System.Drawing.Color.White;
            this.txtCNPClient.Location = new System.Drawing.Point(94, 130);
            this.txtCNPClient.MaxLength = 13;
            this.txtCNPClient.Name = "txtCNPClient";
            this.txtCNPClient.Size = new System.Drawing.Size(120, 27);
            this.txtCNPClient.TabIndex = 15;
            // 
            // txtIDClient
            // 
            this.txtIDClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtIDClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDClient.ForeColor = System.Drawing.Color.White;
            this.txtIDClient.Location = new System.Drawing.Point(94, 165);
            this.txtIDClient.MaxLength = 8;
            this.txtIDClient.Name = "txtIDClient";
            this.txtIDClient.Size = new System.Drawing.Size(120, 27);
            this.txtIDClient.TabIndex = 16;
            // 
            // grbAdaugaClient
            // 
            this.grbAdaugaClient.Controls.Add(this.lblMesaj);
            this.grbAdaugaClient.Controls.Add(this.btnAdaugare);
            this.grbAdaugaClient.Controls.Add(this.txtIDClient);
            this.grbAdaugaClient.Controls.Add(this.lblPrenumeClient);
            this.grbAdaugaClient.Controls.Add(this.txtCNPClient);
            this.grbAdaugaClient.Controls.Add(this.lblNumeClient);
            this.grbAdaugaClient.Controls.Add(this.lblIDClient);
            this.grbAdaugaClient.Controls.Add(this.txtNumeClient);
            this.grbAdaugaClient.Controls.Add(this.lblCNPClient);
            this.grbAdaugaClient.Controls.Add(this.txtPrenumeClient);
            this.grbAdaugaClient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdaugaClient.ForeColor = System.Drawing.Color.White;
            this.grbAdaugaClient.Location = new System.Drawing.Point(26, 47);
            this.grbAdaugaClient.Name = "grbAdaugaClient";
            this.grbAdaugaClient.Size = new System.Drawing.Size(221, 285);
            this.grbAdaugaClient.TabIndex = 17;
            this.grbAdaugaClient.TabStop = false;
            this.grbAdaugaClient.Text = "Adaugare client";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(35, 201);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj.TabIndex = 18;
            // 
            // rtbAfiseazaClienti
            // 
            this.rtbAfiseazaClienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtbAfiseazaClienti.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAfiseazaClienti.ForeColor = System.Drawing.Color.White;
            this.rtbAfiseazaClienti.Location = new System.Drawing.Point(10, 20);
            this.rtbAfiseazaClienti.Name = "rtbAfiseazaClienti";
            this.rtbAfiseazaClienti.Size = new System.Drawing.Size(556, 110);
            this.rtbAfiseazaClienti.TabIndex = 18;
            this.rtbAfiseazaClienti.Text = "";
            // 
            // grbAfiseazaClienti
            // 
            this.grbAfiseazaClienti.Controls.Add(this.btnAfisare);
            this.grbAfiseazaClienti.Controls.Add(this.rtbAfiseazaClienti);
            this.grbAfiseazaClienti.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAfiseazaClienti.ForeColor = System.Drawing.Color.White;
            this.grbAfiseazaClienti.Location = new System.Drawing.Point(253, 47);
            this.grbAfiseazaClienti.Name = "grbAfiseazaClienti";
            this.grbAfiseazaClienti.Size = new System.Drawing.Size(573, 173);
            this.grbAfiseazaClienti.TabIndex = 19;
            this.grbAfiseazaClienti.TabStop = false;
            this.grbAfiseazaClienti.Text = "Afiseaza clienti";
            // 
            // grbCautareClient
            // 
            this.grbCautareClient.Controls.Add(this.lblMesaj2);
            this.grbCautareClient.Controls.Add(this.lblPrenumeCautat);
            this.grbCautareClient.Controls.Add(this.txtCautarePrenumeClient);
            this.grbCautareClient.Controls.Add(this.btnModificare);
            this.grbCautareClient.Controls.Add(this.lblNumeCautat);
            this.grbCautareClient.Controls.Add(this.txtCautareNumeClient);
            this.grbCautareClient.Controls.Add(this.btnCautare);
            this.grbCautareClient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCautareClient.ForeColor = System.Drawing.Color.White;
            this.grbCautareClient.Location = new System.Drawing.Point(26, 338);
            this.grbCautareClient.Name = "grbCautareClient";
            this.grbCautareClient.Size = new System.Drawing.Size(800, 72);
            this.grbCautareClient.TabIndex = 20;
            this.grbCautareClient.TabStop = false;
            this.grbCautareClient.Text = "Cautare si modificare client";
            // 
            // lblMesaj2
            // 
            this.lblMesaj2.AutoSize = true;
            this.lblMesaj2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj2.Location = new System.Drawing.Point(624, 31);
            this.lblMesaj2.Name = "lblMesaj2";
            this.lblMesaj2.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj2.TabIndex = 16;
            // 
            // lblPrenumeCautat
            // 
            this.lblPrenumeCautat.AutoSize = true;
            this.lblPrenumeCautat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenumeCautat.ForeColor = System.Drawing.Color.White;
            this.lblPrenumeCautat.Location = new System.Drawing.Point(223, 32);
            this.lblPrenumeCautat.Name = "lblPrenumeCautat";
            this.lblPrenumeCautat.Size = new System.Drawing.Size(79, 21);
            this.lblPrenumeCautat.TabIndex = 14;
            this.lblPrenumeCautat.Text = "Prenume";
            // 
            // txtCautarePrenumeClient
            // 
            this.txtCautarePrenumeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCautarePrenumeClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCautarePrenumeClient.ForeColor = System.Drawing.Color.White;
            this.txtCautarePrenumeClient.Location = new System.Drawing.Point(308, 29);
            this.txtCautarePrenumeClient.MaxLength = 30;
            this.txtCautarePrenumeClient.Name = "txtCautarePrenumeClient";
            this.txtCautarePrenumeClient.Size = new System.Drawing.Size(120, 27);
            this.txtCautarePrenumeClient.TabIndex = 15;
            // 
            // lblNumeCautat
            // 
            this.lblNumeCautat.AutoSize = true;
            this.lblNumeCautat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeCautat.ForeColor = System.Drawing.Color.White;
            this.lblNumeCautat.Location = new System.Drawing.Point(9, 32);
            this.lblNumeCautat.Name = "lblNumeCautat";
            this.lblNumeCautat.Size = new System.Drawing.Size(57, 21);
            this.lblNumeCautat.TabIndex = 12;
            this.lblNumeCautat.Text = "Nume";
            // 
            // txtCautareNumeClient
            // 
            this.txtCautareNumeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCautareNumeClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCautareNumeClient.ForeColor = System.Drawing.Color.White;
            this.txtCautareNumeClient.Location = new System.Drawing.Point(72, 29);
            this.txtCautareNumeClient.MaxLength = 30;
            this.txtCautareNumeClient.Name = "txtCautareNumeClient";
            this.txtCautareNumeClient.Size = new System.Drawing.Size(120, 27);
            this.txtCautareNumeClient.TabIndex = 13;
            // 
            // grpOptModifClient
            // 
            this.grpOptModifClient.Controls.Add(this.lblMesaj3);
            this.grpOptModifClient.Controls.Add(this.lblInstr);
            this.grpOptModifClient.Controls.Add(this.lbPrenume);
            this.grpOptModifClient.Controls.Add(this.txCNP);
            this.grpOptModifClient.Controls.Add(this.lbNume);
            this.grpOptModifClient.Controls.Add(this.txNume);
            this.grpOptModifClient.Controls.Add(this.lbCNP);
            this.grpOptModifClient.Controls.Add(this.txPrenume);
            this.grpOptModifClient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOptModifClient.ForeColor = System.Drawing.Color.White;
            this.grpOptModifClient.Location = new System.Drawing.Point(253, 223);
            this.grpOptModifClient.Name = "grpOptModifClient";
            this.grpOptModifClient.Size = new System.Drawing.Size(573, 108);
            this.grpOptModifClient.TabIndex = 21;
            this.grpOptModifClient.TabStop = false;
            this.grpOptModifClient.Text = "Optiuni modificare";
            // 
            // lblMesaj3
            // 
            this.lblMesaj3.AutoSize = true;
            this.lblMesaj3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj3.Location = new System.Drawing.Point(352, 34);
            this.lblMesaj3.Name = "lblMesaj3";
            this.lblMesaj3.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj3.TabIndex = 30;
            // 
            // lblInstr
            // 
            this.lblInstr.AutoSize = true;
            this.lblInstr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstr.ForeColor = System.Drawing.Color.White;
            this.lblInstr.Location = new System.Drawing.Point(18, 30);
            this.lblInstr.Name = "lblInstr";
            this.lblInstr.Size = new System.Drawing.Size(328, 21);
            this.lblInstr.TabIndex = 29;
            this.lblInstr.Text = "Completeaza ceea ce doresti sa modifici";
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenume.ForeColor = System.Drawing.Color.White;
            this.lbPrenume.Location = new System.Drawing.Point(190, 73);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(79, 21);
            this.lbPrenume.TabIndex = 17;
            this.lbPrenume.Text = "Prenume";
            // 
            // txCNP
            // 
            this.txCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txCNP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCNP.ForeColor = System.Drawing.Color.White;
            this.txCNP.Location = new System.Drawing.Point(447, 73);
            this.txCNP.MaxLength = 13;
            this.txCNP.Name = "txCNP";
            this.txCNP.Size = new System.Drawing.Size(120, 27);
            this.txCNP.TabIndex = 23;
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNume.ForeColor = System.Drawing.Color.White;
            this.lbNume.Location = new System.Drawing.Point(9, 77);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(57, 21);
            this.lbNume.TabIndex = 18;
            this.lbNume.Text = "Nume";
            // 
            // txNume
            // 
            this.txNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txNume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNume.ForeColor = System.Drawing.Color.White;
            this.txNume.Location = new System.Drawing.Point(66, 74);
            this.txNume.MaxLength = 30;
            this.txNume.Name = "txNume";
            this.txNume.Size = new System.Drawing.Size(120, 27);
            this.txNume.TabIndex = 19;
            // 
            // lbCNP
            // 
            this.lbCNP.AutoSize = true;
            this.lbCNP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCNP.ForeColor = System.Drawing.Color.White;
            this.lbCNP.Location = new System.Drawing.Point(397, 79);
            this.lbCNP.Name = "lbCNP";
            this.lbCNP.Size = new System.Drawing.Size(44, 21);
            this.lbCNP.TabIndex = 21;
            this.lbCNP.Text = "CNP";
            // 
            // txPrenume
            // 
            this.txPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txPrenume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrenume.ForeColor = System.Drawing.Color.White;
            this.txPrenume.Location = new System.Drawing.Point(271, 74);
            this.txPrenume.MaxLength = 30;
            this.txPrenume.Name = "txPrenume";
            this.txPrenume.Size = new System.Drawing.Size(120, 27);
            this.txPrenume.TabIndex = 20;
            // 
            // PaginaClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.grpOptModifClient);
            this.Controls.Add(this.grbCautareClient);
            this.Controls.Add(this.grbAfiseazaClienti);
            this.Controls.Add(this.grbAdaugaClient);
            this.Controls.Add(this.lblTitluClient);
            this.Name = "PaginaClienti";
            this.Size = new System.Drawing.Size(887, 426);
            this.grbAdaugaClient.ResumeLayout(false);
            this.grbAdaugaClient.PerformLayout();
            this.grbAfiseazaClienti.ResumeLayout(false);
            this.grbCautareClient.ResumeLayout(false);
            this.grbCautareClient.PerformLayout();
            this.grpOptModifClient.ResumeLayout(false);
            this.grpOptModifClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitluClient;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Label lblPrenumeClient;
        private System.Windows.Forms.Label lblNumeClient;
        private System.Windows.Forms.TextBox txtNumeClient;
        private System.Windows.Forms.TextBox txtPrenumeClient;
        private System.Windows.Forms.Label lblCNPClient;
        private System.Windows.Forms.Label lblIDClient;
        private System.Windows.Forms.TextBox txtCNPClient;
        private System.Windows.Forms.TextBox txtIDClient;
        private System.Windows.Forms.GroupBox grbAdaugaClient;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.RichTextBox rtbAfiseazaClienti;
        private System.Windows.Forms.GroupBox grbAfiseazaClienti;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbCautareClient;
        private System.Windows.Forms.Label lblPrenumeCautat;
        private System.Windows.Forms.TextBox txtCautarePrenumeClient;
        private System.Windows.Forms.Label lblNumeCautat;
        private System.Windows.Forms.TextBox txtCautareNumeClient;
        private System.Windows.Forms.Label lblMesaj2;
        private System.Windows.Forms.GroupBox grpOptModifClient;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.TextBox txCNP;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.TextBox txNume;
        private System.Windows.Forms.Label lbCNP;
        private System.Windows.Forms.TextBox txPrenume;
        private System.Windows.Forms.Label lblInstr;
        private System.Windows.Forms.Label lblMesaj3;
    }
}
