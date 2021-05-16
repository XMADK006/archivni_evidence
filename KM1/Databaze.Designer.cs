namespace KM1
{
    partial class Databaze
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Databaze));
            this.pictureKnihy = new System.Windows.Forms.PictureBox();
            this.txtBoxNAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPridat = new System.Windows.Forms.Button();
            this.buttonEditovat = new System.Windows.Forms.Button();
            this.buttonStorno = new System.Windows.Forms.Button();
            this.buttonVymazat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dgEvidenceList = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVyhledat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxZpracovany = new System.Windows.Forms.ComboBox();
            this.cmbBoxPomucka = new System.Windows.Forms.ComboBox();
            this.numericUpDownRok = new System.Windows.Forms.NumericUpDown();
            this.txtBoxFond = new System.Windows.Forms.TextBox();
            this.textBoxVyhledatPuvodce = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxPuvodce = new System.Windows.Forms.TextBox();
            this.textBoxVyhledatPomucka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxVyhledatZpracovani = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVyhledatZaevidovani = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxVyhledatVsude = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKnihy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvidenceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureKnihy
            // 
            this.pictureKnihy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureKnihy.Image = ((System.Drawing.Image)(resources.GetObject("pictureKnihy.Image")));
            this.pictureKnihy.Location = new System.Drawing.Point(29, 30);
            this.pictureKnihy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureKnihy.Name = "pictureKnihy";
            this.pictureKnihy.Size = new System.Drawing.Size(487, 160);
            this.pictureKnihy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKnihy.TabIndex = 0;
            this.pictureKnihy.TabStop = false;
            // 
            // txtBoxNAD
            // 
            this.txtBoxNAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxNAD.Location = new System.Drawing.Point(203, 224);
            this.txtBoxNAD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNAD.Name = "txtBoxNAD";
            this.txtBoxNAD.ReadOnly = true;
            this.txtBoxNAD.Size = new System.Drawing.Size(159, 30);
            this.txtBoxNAD.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Archivní fond";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Původce";
            // 
            // buttonPridat
            // 
            this.buttonPridat.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonPridat.Location = new System.Drawing.Point(35, 641);
            this.buttonPridat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(91, 52);
            this.buttonPridat.TabIndex = 14;
            this.buttonPridat.Text = "Přidat";
            this.buttonPridat.UseVisualStyleBackColor = false;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // buttonEditovat
            // 
            this.buttonEditovat.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonEditovat.Location = new System.Drawing.Point(167, 641);
            this.buttonEditovat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditovat.Name = "buttonEditovat";
            this.buttonEditovat.Size = new System.Drawing.Size(91, 52);
            this.buttonEditovat.TabIndex = 15;
            this.buttonEditovat.Text = "Editovat";
            this.buttonEditovat.UseVisualStyleBackColor = false;
            this.buttonEditovat.Click += new System.EventHandler(this.buttonEditovat_Click);
            // 
            // buttonStorno
            // 
            this.buttonStorno.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonStorno.Location = new System.Drawing.Point(296, 641);
            this.buttonStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStorno.Name = "buttonStorno";
            this.buttonStorno.Size = new System.Drawing.Size(91, 52);
            this.buttonStorno.TabIndex = 16;
            this.buttonStorno.Text = "Storno";
            this.buttonStorno.UseVisualStyleBackColor = false;
            this.buttonStorno.Click += new System.EventHandler(this.buttonStorno_Click);
            // 
            // buttonVymazat
            // 
            this.buttonVymazat.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonVymazat.Location = new System.Drawing.Point(427, 641);
            this.buttonVymazat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVymazat.Name = "buttonVymazat";
            this.buttonVymazat.Size = new System.Drawing.Size(91, 52);
            this.buttonVymazat.TabIndex = 17;
            this.buttonVymazat.Text = "Vymazat";
            this.buttonVymazat.UseVisualStyleBackColor = false;
            this.buttonVymazat.Click += new System.EventHandler(this.buttonVymazat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "© Kamila Mádrová";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(809, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(180, 17);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "xmadk006@studenti.czu.cz";
            // 
            // dgEvidenceList
            // 
            this.dgEvidenceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEvidenceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvidenceList.Location = new System.Drawing.Point(35, 718);
            this.dgEvidenceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgEvidenceList.Name = "dgEvidenceList";
            this.dgEvidenceList.RowHeadersWidth = 51;
            this.dgEvidenceList.RowTemplate.Height = 24;
            this.dgEvidenceList.Size = new System.Drawing.Size(1041, 202);
            this.dgEvidenceList.TabIndex = 20;
            this.dgEvidenceList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEvidenceList_RowHeaderMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(571, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Vyhledat v archivnim fondu";
            // 
            // textBoxVyhledat
            // 
            this.textBoxVyhledat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVyhledat.Location = new System.Drawing.Point(864, 268);
            this.textBoxVyhledat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVyhledat.Name = "textBoxVyhledat";
            this.textBoxVyhledat.Size = new System.Drawing.Size(211, 30);
            this.textBoxVyhledat.TabIndex = 22;
            this.textBoxVyhledat.TextChanged += new System.EventHandler(this.textBoxVyhledat_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(635, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(401, 39);
            this.label9.TabIndex = 23;
            this.label9.Text = "Evidence archivních fondů";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(41, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Zpracovaný";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "NAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(41, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Rok zaevidování";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(41, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pomůcka";
            // 
            // cmbBoxZpracovany
            // 
            this.cmbBoxZpracovany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxZpracovany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxZpracovany.FormattingEnabled = true;
            this.cmbBoxZpracovany.Items.AddRange(new object[] {
            "ano",
            "ne"});
            this.cmbBoxZpracovany.Location = new System.Drawing.Point(203, 457);
            this.cmbBoxZpracovany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxZpracovany.Name = "cmbBoxZpracovany";
            this.cmbBoxZpracovany.Size = new System.Drawing.Size(159, 33);
            this.cmbBoxZpracovany.TabIndex = 34;
            // 
            // cmbBoxPomucka
            // 
            this.cmbBoxPomucka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxPomucka.FormattingEnabled = true;
            this.cmbBoxPomucka.Items.AddRange(new object[] {
            "Inventář",
            "Manipulační seznam",
            "Předávací seznam"});
            this.cmbBoxPomucka.Location = new System.Drawing.Point(203, 513);
            this.cmbBoxPomucka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxPomucka.Name = "cmbBoxPomucka";
            this.cmbBoxPomucka.Size = new System.Drawing.Size(313, 33);
            this.cmbBoxPomucka.TabIndex = 35;
            // 
            // numericUpDownRok
            // 
            this.numericUpDownRok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownRok.Location = new System.Drawing.Point(396, 569);
            this.numericUpDownRok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownRok.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownRok.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownRok.Name = "numericUpDownRok";
            this.numericUpDownRok.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownRok.TabIndex = 36;
            this.numericUpDownRok.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtBoxFond
            // 
            this.txtBoxFond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxFond.Location = new System.Drawing.Point(203, 274);
            this.txtBoxFond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxFond.Multiline = true;
            this.txtBoxFond.Name = "txtBoxFond";
            this.txtBoxFond.Size = new System.Drawing.Size(313, 69);
            this.txtBoxFond.TabIndex = 38;
            // 
            // textBoxVyhledatPuvodce
            // 
            this.textBoxVyhledatPuvodce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVyhledatPuvodce.Location = new System.Drawing.Point(864, 327);
            this.textBoxVyhledatPuvodce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVyhledatPuvodce.Name = "textBoxVyhledatPuvodce";
            this.textBoxVyhledatPuvodce.Size = new System.Drawing.Size(211, 30);
            this.textBoxVyhledatPuvodce.TabIndex = 46;
            this.textBoxVyhledatPuvodce.TextChanged += new System.EventHandler(this.textBoxVyhledatPuvodce_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(571, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 24);
            this.label13.TabIndex = 45;
            this.label13.Text = "Vyhledat v původci";
            // 
            // txtBoxPuvodce
            // 
            this.txtBoxPuvodce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPuvodce.Location = new System.Drawing.Point(203, 366);
            this.txtBoxPuvodce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPuvodce.Multiline = true;
            this.txtBoxPuvodce.Name = "txtBoxPuvodce";
            this.txtBoxPuvodce.Size = new System.Drawing.Size(313, 69);
            this.txtBoxPuvodce.TabIndex = 37;
            // 
            // textBoxVyhledatPomucka
            // 
            this.textBoxVyhledatPomucka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVyhledatPomucka.Location = new System.Drawing.Point(864, 446);
            this.textBoxVyhledatPomucka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVyhledatPomucka.Name = "textBoxVyhledatPomucka";
            this.textBoxVyhledatPomucka.Size = new System.Drawing.Size(211, 30);
            this.textBoxVyhledatPomucka.TabIndex = 50;
            this.textBoxVyhledatPomucka.TextChanged += new System.EventHandler(this.textBoxVyhledatPomucka_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(571, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 24);
            this.label10.TabIndex = 49;
            this.label10.Text = "Vyhledat v pomůcce";
            // 
            // textBoxVyhledatZpracovani
            // 
            this.textBoxVyhledatZpracovani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVyhledatZpracovani.Location = new System.Drawing.Point(864, 388);
            this.textBoxVyhledatZpracovani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVyhledatZpracovani.Name = "textBoxVyhledatZpracovani";
            this.textBoxVyhledatZpracovani.Size = new System.Drawing.Size(211, 30);
            this.textBoxVyhledatZpracovani.TabIndex = 48;
            this.textBoxVyhledatZpracovani.TextChanged += new System.EventHandler(this.textBoxVyhledatZpracovani_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(571, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 24);
            this.label11.TabIndex = 47;
            this.label11.Text = "Vyhledat ve zpracování";
            // 
            // textBoxVyhledatZaevidovani
            // 
            this.textBoxVyhledatZaevidovani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVyhledatZaevidovani.Location = new System.Drawing.Point(864, 502);
            this.textBoxVyhledatZaevidovani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVyhledatZaevidovani.Name = "textBoxVyhledatZaevidovani";
            this.textBoxVyhledatZaevidovani.Size = new System.Drawing.Size(211, 30);
            this.textBoxVyhledatZaevidovani.TabIndex = 52;
            this.textBoxVyhledatZaevidovani.TextChanged += new System.EventHandler(this.textBoxVyhledatZaevidovani_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(571, 502);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 24);
            this.label12.TabIndex = 51;
            this.label12.Text = "Vyhledat v roce zaevidování";
            // 
            // textBoxVyhledatVsude
            // 
            this.textBoxVyhledatVsude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVyhledatVsude.Location = new System.Drawing.Point(864, 622);
            this.textBoxVyhledatVsude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVyhledatVsude.Name = "textBoxVyhledatVsude";
            this.textBoxVyhledatVsude.Size = new System.Drawing.Size(211, 30);
            this.textBoxVyhledatVsude.TabIndex = 54;
            this.textBoxVyhledatVsude.TextChanged += new System.EventHandler(this.textBoxVyhledatVsude_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(571, 622);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(270, 24);
            this.label14.TabIndex = 53;
            this.label14.Text = "Vyhledat ve všech sloupcích";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(571, 665);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(451, 24);
            this.label15.TabIndex = 55;
            this.label15.Text = "(ignoruje výše zadané textové pole vyhledávání)";
            // 
            // Databaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1155, 841);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxVyhledatVsude);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxVyhledatZaevidovani);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxVyhledatPomucka);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxVyhledatZpracovani);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxVyhledatPuvodce);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxFond);
            this.Controls.Add(this.txtBoxPuvodce);
            this.Controls.Add(this.numericUpDownRok);
            this.Controls.Add(this.cmbBoxPomucka);
            this.Controls.Add(this.cmbBoxZpracovany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxVyhledat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgEvidenceList);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonVymazat);
            this.Controls.Add(this.buttonStorno);
            this.Controls.Add(this.buttonEditovat);
            this.Controls.Add(this.buttonPridat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureKnihy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Databaze";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 29, 20);
            this.Text = "Archivní fondy";
            this.Load += new System.EventHandler(this.Databaze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureKnihy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvidenceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureKnihy;
        private System.Windows.Forms.TextBox txtBoxNAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPridat;
        private System.Windows.Forms.Button buttonEditovat;
        private System.Windows.Forms.Button buttonStorno;
        private System.Windows.Forms.Button buttonVymazat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dgEvidenceList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVyhledat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxPomucka;
        private System.Windows.Forms.NumericUpDown numericUpDownRok;
        private System.Windows.Forms.TextBox txtBoxFond;
        private System.Windows.Forms.TextBox textBoxVyhledatPuvodce;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxPuvodce;
        private System.Windows.Forms.TextBox textBoxVyhledatPomucka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxVyhledatZpracovani;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxVyhledatZaevidovani;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxVyhledatVsude;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbBoxZpracovany;
    }
}

