namespace InterfataUtilizator
{
    partial class FormaAfisare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaAfisare));
            this.btnUpdateFirma = new System.Windows.Forms.Button();
            this.lstFirme = new System.Windows.Forms.ListBox();
            this.txtFirmaError = new System.Windows.Forms.Label();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblNumeLivrator = new System.Windows.Forms.Label();
            this.txtPrenumeLivrator = new System.Windows.Forms.TextBox();
            this.txtNumeLivrator = new System.Windows.Forms.TextBox();
            this.lblPrenumeLivrator = new System.Windows.Forms.Label();
            this.lblNumeFirma = new System.Windows.Forms.Label();
            this.txtLogoUrl = new System.Windows.Forms.TextBox();
            this.gpbProgrameStudiu = new System.Windows.Forms.GroupBox();
            this.rdbBicicleta = new System.Windows.Forms.RadioButton();
            this.rdbMotocicleta = new System.Windows.Forms.RadioButton();
            this.rdbAutomobil = new System.Windows.Forms.RadioButton();
            this.rdbTrotineta = new System.Windows.Forms.RadioButton();
            this.txtNumeFirma = new System.Windows.Forms.TextBox();
            this.btnAdaugaFirma = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lstLivratori = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addLivBtn = new System.Windows.Forms.Button();
            this.editLivBtn = new System.Windows.Forms.Button();
            this.deleteLivBtn = new System.Windows.Forms.Button();
            this.eroareLivratorLbl = new System.Windows.Forms.Label();
            this.dataAngPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataNasteriiPicker = new System.Windows.Forms.DateTimePicker();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textModelCar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textMarkValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstMasine = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.eroareMasinaLbl = new System.Windows.Forms.Label();
            this.btnStergeFirma = new System.Windows.Forms.Button();
            this.gpbProgrameStudiu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateFirma
            // 
            this.btnUpdateFirma.Location = new System.Drawing.Point(144, 109);
            this.btnUpdateFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateFirma.Name = "btnUpdateFirma";
            this.btnUpdateFirma.Size = new System.Drawing.Size(103, 28);
            this.btnUpdateFirma.TabIndex = 73;
            this.btnUpdateFirma.Text = "Modifica";
            this.btnUpdateFirma.UseVisualStyleBackColor = true;
            this.btnUpdateFirma.Click += new System.EventHandler(this.btnUpdateFirma_Click);
            // 
            // lstFirme
            // 
            this.lstFirme.BackColor = System.Drawing.SystemColors.Window;
            this.lstFirme.FormattingEnabled = true;
            this.lstFirme.ItemHeight = 16;
            this.lstFirme.Location = new System.Drawing.Point(425, 16);
            this.lstFirme.Margin = new System.Windows.Forms.Padding(4);
            this.lstFirme.Name = "lstFirme";
            this.lstFirme.Size = new System.Drawing.Size(472, 164);
            this.lstFirme.TabIndex = 72;
            this.lstFirme.SelectedIndexChanged += new System.EventHandler(this.lstFirme_SelectedIndexChanged);
            // 
            // txtFirmaError
            // 
            this.txtFirmaError.BackColor = System.Drawing.Color.Transparent;
            this.txtFirmaError.ForeColor = System.Drawing.Color.Red;
            this.txtFirmaError.Location = new System.Drawing.Point(13, 80);
            this.txtFirmaError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFirmaError.Name = "txtFirmaError";
            this.txtFirmaError.Size = new System.Drawing.Size(357, 21);
            this.txtFirmaError.TabIndex = 70;
            this.txtFirmaError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.BackColor = System.Drawing.Color.Transparent;
            this.lblTransport.Location = new System.Drawing.Point(422, 713);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(73, 16);
            this.lblTransport.TabIndex = 69;
            this.lblTransport.Text = "*Transport:";
            // 
            // lblNumeLivrator
            // 
            this.lblNumeLivrator.AutoSize = true;
            this.lblNumeLivrator.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeLivrator.Location = new System.Drawing.Point(15, 242);
            this.lblNumeLivrator.Name = "lblNumeLivrator";
            this.lblNumeLivrator.Size = new System.Drawing.Size(75, 16);
            this.lblNumeLivrator.TabIndex = 68;
            this.lblNumeLivrator.Text = "*Nume Livr:";
            // 
            // txtPrenumeLivrator
            // 
            this.txtPrenumeLivrator.Location = new System.Drawing.Point(114, 274);
            this.txtPrenumeLivrator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenumeLivrator.Name = "txtPrenumeLivrator";
            this.txtPrenumeLivrator.Size = new System.Drawing.Size(256, 22);
            this.txtPrenumeLivrator.TabIndex = 67;
            // 
            // txtNumeLivrator
            // 
            this.txtNumeLivrator.Location = new System.Drawing.Point(114, 239);
            this.txtNumeLivrator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeLivrator.Name = "txtNumeLivrator";
            this.txtNumeLivrator.Size = new System.Drawing.Size(256, 22);
            this.txtNumeLivrator.TabIndex = 66;
            // 
            // lblPrenumeLivrator
            // 
            this.lblPrenumeLivrator.AutoSize = true;
            this.lblPrenumeLivrator.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenumeLivrator.Location = new System.Drawing.Point(15, 277);
            this.lblPrenumeLivrator.Name = "lblPrenumeLivrator";
            this.lblPrenumeLivrator.Size = new System.Drawing.Size(69, 16);
            this.lblPrenumeLivrator.TabIndex = 65;
            this.lblPrenumeLivrator.Text = "*Prenume:";
            this.lblPrenumeLivrator.Click += new System.EventHandler(this.lblPrenumeLivrator_Click);
            // 
            // lblNumeFirma
            // 
            this.lblNumeFirma.AutoSize = true;
            this.lblNumeFirma.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeFirma.Location = new System.Drawing.Point(15, 20);
            this.lblNumeFirma.Name = "lblNumeFirma";
            this.lblNumeFirma.Size = new System.Drawing.Size(85, 16);
            this.lblNumeFirma.TabIndex = 62;
            this.lblNumeFirma.Text = "*Nume Firma";
            // 
            // txtLogoUrl
            // 
            this.txtLogoUrl.Location = new System.Drawing.Point(113, 49);
            this.txtLogoUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogoUrl.Name = "txtLogoUrl";
            this.txtLogoUrl.Size = new System.Drawing.Size(256, 22);
            this.txtLogoUrl.TabIndex = 61;
            // 
            // gpbProgrameStudiu
            // 
            this.gpbProgrameStudiu.BackColor = System.Drawing.Color.Transparent;
            this.gpbProgrameStudiu.Controls.Add(this.rdbBicicleta);
            this.gpbProgrameStudiu.Controls.Add(this.rdbMotocicleta);
            this.gpbProgrameStudiu.Controls.Add(this.rdbAutomobil);
            this.gpbProgrameStudiu.Controls.Add(this.rdbTrotineta);
            this.gpbProgrameStudiu.Location = new System.Drawing.Point(425, 733);
            this.gpbProgrameStudiu.Margin = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Name = "gpbProgrameStudiu";
            this.gpbProgrameStudiu.Padding = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Size = new System.Drawing.Size(257, 79);
            this.gpbProgrameStudiu.TabIndex = 60;
            this.gpbProgrameStudiu.TabStop = false;
            // 
            // rdbBicicleta
            // 
            this.rdbBicicleta.AutoSize = true;
            this.rdbBicicleta.Location = new System.Drawing.Point(20, 39);
            this.rdbBicicleta.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBicicleta.Name = "rdbBicicleta";
            this.rdbBicicleta.Size = new System.Drawing.Size(79, 20);
            this.rdbBicicleta.TabIndex = 10;
            this.rdbBicicleta.TabStop = true;
            this.rdbBicicleta.Text = "Bicicleta";
            this.rdbBicicleta.UseVisualStyleBackColor = true;
            // 
            // rdbMotocicleta
            // 
            this.rdbMotocicleta.AutoSize = true;
            this.rdbMotocicleta.Location = new System.Drawing.Point(140, 39);
            this.rdbMotocicleta.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMotocicleta.Name = "rdbMotocicleta";
            this.rdbMotocicleta.Size = new System.Drawing.Size(97, 20);
            this.rdbMotocicleta.TabIndex = 11;
            this.rdbMotocicleta.TabStop = true;
            this.rdbMotocicleta.Text = "Motocicleta";
            this.rdbMotocicleta.UseVisualStyleBackColor = true;
            // 
            // rdbAutomobil
            // 
            this.rdbAutomobil.AutoSize = true;
            this.rdbAutomobil.Location = new System.Drawing.Point(20, 11);
            this.rdbAutomobil.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAutomobil.Name = "rdbAutomobil";
            this.rdbAutomobil.Size = new System.Drawing.Size(88, 20);
            this.rdbAutomobil.TabIndex = 8;
            this.rdbAutomobil.TabStop = true;
            this.rdbAutomobil.Text = "Automobil";
            this.rdbAutomobil.UseVisualStyleBackColor = true;
            this.rdbAutomobil.CheckedChanged += new System.EventHandler(this.rdbAutomobil_CheckedChanged);
            // 
            // rdbTrotineta
            // 
            this.rdbTrotineta.AutoSize = true;
            this.rdbTrotineta.Location = new System.Drawing.Point(140, 11);
            this.rdbTrotineta.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTrotineta.Name = "rdbTrotineta";
            this.rdbTrotineta.Size = new System.Drawing.Size(81, 20);
            this.rdbTrotineta.TabIndex = 9;
            this.rdbTrotineta.TabStop = true;
            this.rdbTrotineta.Text = "Trotineta";
            this.rdbTrotineta.UseVisualStyleBackColor = true;
            // 
            // txtNumeFirma
            // 
            this.txtNumeFirma.Location = new System.Drawing.Point(114, 16);
            this.txtNumeFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeFirma.Name = "txtNumeFirma";
            this.txtNumeFirma.Size = new System.Drawing.Size(256, 22);
            this.txtNumeFirma.TabIndex = 59;
            this.txtNumeFirma.TextChanged += new System.EventHandler(this.txtNumeFirma_TextChanged);
            // 
            // btnAdaugaFirma
            // 
            this.btnAdaugaFirma.Location = new System.Drawing.Point(18, 109);
            this.btnAdaugaFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdaugaFirma.Name = "btnAdaugaFirma";
            this.btnAdaugaFirma.Size = new System.Drawing.Size(103, 28);
            this.btnAdaugaFirma.TabIndex = 58;
            this.btnAdaugaFirma.Text = "Adauga";
            this.btnAdaugaFirma.UseVisualStyleBackColor = true;
            this.btnAdaugaFirma.Click += new System.EventHandler(this.btnAdaugaFirma_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Location = new System.Drawing.Point(15, 52);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(63, 16);
            this.lblLogo.TabIndex = 57;
            this.lblLogo.Text = "*Logo url:";
            // 
            // lstLivratori
            // 
            this.lstLivratori.FormattingEnabled = true;
            this.lstLivratori.ItemHeight = 16;
            this.lstLivratori.Location = new System.Drawing.Point(425, 239);
            this.lstLivratori.Margin = new System.Windows.Forms.Padding(4);
            this.lstLivratori.Name = "lstLivratori";
            this.lstLivratori.Size = new System.Drawing.Size(472, 404);
            this.lstLivratori.TabIndex = 74;
            this.lstLivratori.SelectedIndexChanged += new System.EventHandler(this.lstLivratori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(18, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(879, 5);
            this.label1.TabIndex = 75;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addLivBtn
            // 
            this.addLivBtn.Location = new System.Drawing.Point(18, 630);
            this.addLivBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLivBtn.Name = "addLivBtn";
            this.addLivBtn.Size = new System.Drawing.Size(103, 28);
            this.addLivBtn.TabIndex = 76;
            this.addLivBtn.Text = "Adauga";
            this.addLivBtn.UseVisualStyleBackColor = true;
            this.addLivBtn.Click += new System.EventHandler(this.addLivBtn_Click);
            // 
            // editLivBtn
            // 
            this.editLivBtn.Location = new System.Drawing.Point(144, 630);
            this.editLivBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editLivBtn.Name = "editLivBtn";
            this.editLivBtn.Size = new System.Drawing.Size(103, 28);
            this.editLivBtn.TabIndex = 77;
            this.editLivBtn.Text = "Modifica";
            this.editLivBtn.UseVisualStyleBackColor = true;
            this.editLivBtn.Click += new System.EventHandler(this.editLivBtn_Click);
            // 
            // deleteLivBtn
            // 
            this.deleteLivBtn.Location = new System.Drawing.Point(267, 630);
            this.deleteLivBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteLivBtn.Name = "deleteLivBtn";
            this.deleteLivBtn.Size = new System.Drawing.Size(103, 28);
            this.deleteLivBtn.TabIndex = 78;
            this.deleteLivBtn.Text = "Sterge";
            this.deleteLivBtn.UseVisualStyleBackColor = true;
            this.deleteLivBtn.Click += new System.EventHandler(this.deleteLivBtn_Click);
            // 
            // eroareLivratorLbl
            // 
            this.eroareLivratorLbl.BackColor = System.Drawing.Color.Transparent;
            this.eroareLivratorLbl.ForeColor = System.Drawing.Color.Red;
            this.eroareLivratorLbl.Location = new System.Drawing.Point(14, 594);
            this.eroareLivratorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eroareLivratorLbl.Name = "eroareLivratorLbl";
            this.eroareLivratorLbl.Size = new System.Drawing.Size(355, 21);
            this.eroareLivratorLbl.TabIndex = 79;
            this.eroareLivratorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eroareLivratorLbl.Click += new System.EventHandler(this.eroareLivratorLbl_Click);
            // 
            // dataAngPicker
            // 
            this.dataAngPicker.Location = new System.Drawing.Point(113, 352);
            this.dataAngPicker.Name = "dataAngPicker";
            this.dataAngPicker.Size = new System.Drawing.Size(255, 22);
            this.dataAngPicker.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "*Data ang:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "*Data nasterii:";
            // 
            // dataNasteriiPicker
            // 
            this.dataNasteriiPicker.Location = new System.Drawing.Point(115, 394);
            this.dataNasteriiPicker.Name = "dataNasteriiPicker";
            this.dataNasteriiPicker.Size = new System.Drawing.Size(255, 22);
            this.dataNasteriiPicker.TabIndex = 82;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(114, 311);
            this.emailValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(256, 22);
            this.emailValue.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "*Email:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(18, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(879, 5);
            this.label5.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(13, 727);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 88;
            this.label6.Text = "*Model:";
            // 
            // textModelCar
            // 
            this.textModelCar.Location = new System.Drawing.Point(112, 724);
            this.textModelCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textModelCar.Name = "textModelCar";
            this.textModelCar.Size = new System.Drawing.Size(256, 22);
            this.textModelCar.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(15, 763);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 90;
            this.label7.Text = "*Mark:";
            // 
            // textMarkValue
            // 
            this.textMarkValue.Location = new System.Drawing.Point(112, 760);
            this.textMarkValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMarkValue.Name = "textMarkValue";
            this.textMarkValue.Size = new System.Drawing.Size(256, 22);
            this.textMarkValue.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 824);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 28);
            this.button1.TabIndex = 91;
            this.button1.Text = "Adauga Masina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstMasine
            // 
            this.lstMasine.FormattingEnabled = true;
            this.lstMasine.ItemHeight = 16;
            this.lstMasine.Location = new System.Drawing.Point(16, 463);
            this.lstMasine.Margin = new System.Windows.Forms.Padding(4);
            this.lstMasine.Name = "lstMasine";
            this.lstMasine.Size = new System.Drawing.Size(352, 116);
            this.lstMasine.TabIndex = 92;
            this.lstMasine.SelectedIndexChanged += new System.EventHandler(this.lstMasine_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(15, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 93;
            this.label8.Text = "*Vehicol";
            // 
            // eroareMasinaLbl
            // 
            this.eroareMasinaLbl.BackColor = System.Drawing.Color.Transparent;
            this.eroareMasinaLbl.ForeColor = System.Drawing.Color.Red;
            this.eroareMasinaLbl.Location = new System.Drawing.Point(19, 791);
            this.eroareMasinaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eroareMasinaLbl.Name = "eroareMasinaLbl";
            this.eroareMasinaLbl.Size = new System.Drawing.Size(355, 21);
            this.eroareMasinaLbl.TabIndex = 94;
            this.eroareMasinaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStergeFirma
            // 
            this.btnStergeFirma.Location = new System.Drawing.Point(267, 109);
            this.btnStergeFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStergeFirma.Name = "btnStergeFirma";
            this.btnStergeFirma.Size = new System.Drawing.Size(103, 28);
            this.btnStergeFirma.TabIndex = 95;
            this.btnStergeFirma.Text = "Sterge";
            this.btnStergeFirma.UseVisualStyleBackColor = true;
            this.btnStergeFirma.Click += new System.EventHandler(this.btnStergeFirma_Click);
            // 
            // FormaAfisare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 985);
            this.Controls.Add(this.btnStergeFirma);
            this.Controls.Add(this.eroareMasinaLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstMasine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textMarkValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textModelCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataNasteriiPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataAngPicker);
            this.Controls.Add(this.eroareLivratorLbl);
            this.Controls.Add(this.deleteLivBtn);
            this.Controls.Add(this.editLivBtn);
            this.Controls.Add(this.addLivBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLivratori);
            this.Controls.Add(this.btnUpdateFirma);
            this.Controls.Add(this.lstFirme);
            this.Controls.Add(this.txtFirmaError);
            this.Controls.Add(this.lblNumeLivrator);
            this.Controls.Add(this.txtPrenumeLivrator);
            this.Controls.Add(this.txtNumeLivrator);
            this.Controls.Add(this.lblPrenumeLivrator);
            this.Controls.Add(this.lblNumeFirma);
            this.Controls.Add(this.txtLogoUrl);
            this.Controls.Add(this.gpbProgrameStudiu);
            this.Controls.Add(this.txtNumeFirma);
            this.Controls.Add(this.btnAdaugaFirma);
            this.Controls.Add(this.lblLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaAfisare";
            this.Text = "Catalog Masini";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormaAfisare_FormClosed);
            this.Load += new System.EventHandler(this.FormaAfisare_Load);
            this.gpbProgrameStudiu.ResumeLayout(false);
            this.gpbProgrameStudiu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateFirma;
        private System.Windows.Forms.ListBox lstFirme;
        private System.Windows.Forms.Label txtFirmaError;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label lblNumeLivrator;
        private System.Windows.Forms.TextBox txtPrenumeLivrator;
        private System.Windows.Forms.TextBox txtNumeLivrator;
        private System.Windows.Forms.Label lblPrenumeLivrator;
        private System.Windows.Forms.Label lblNumeFirma;
        private System.Windows.Forms.TextBox txtLogoUrl;
        private System.Windows.Forms.GroupBox gpbProgrameStudiu;
        private System.Windows.Forms.RadioButton rdbBicicleta;
        private System.Windows.Forms.RadioButton rdbMotocicleta;
        private System.Windows.Forms.RadioButton rdbAutomobil;
        private System.Windows.Forms.RadioButton rdbTrotineta;
        private System.Windows.Forms.TextBox txtNumeFirma;
        private System.Windows.Forms.Button btnAdaugaFirma;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ListBox lstLivratori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addLivBtn;
        private System.Windows.Forms.Button editLivBtn;
        private System.Windows.Forms.Button deleteLivBtn;
        private System.Windows.Forms.Label eroareLivratorLbl;
        private System.Windows.Forms.DateTimePicker dataAngPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataNasteriiPicker;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textModelCar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMarkValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstMasine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label eroareMasinaLbl;
        private System.Windows.Forms.Button btnStergeFirma;
    }
}

