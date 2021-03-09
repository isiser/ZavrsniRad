namespace PratkicniDio_Zavrsni
{
    partial class FormAplikacija
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
            this.components = new System.ComponentModel.Container();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKorIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProvjeraPrsta = new System.Windows.Forms.Button();
            this.picBoxProvjeraPrsta = new System.Windows.Forms.PictureBox();
            this.btnOcitajPrst = new System.Windows.Forms.Button();
            this.cameraBoxPocetna = new Emgu.CV.UI.ImageBox();
            this.btnPrepoznajLice = new System.Windows.Forms.Button();
            this.picBoxPotvrdaPrsta = new System.Windows.Forms.PictureBox();
            this.picBoxPotvrdaLica = new System.Windows.Forms.PictureBox();
            this.picBoxPotvrdaPrijave = new System.Windows.Forms.PictureBox();
            this.btnPrihvatiPrepoznato = new System.Windows.Forms.Button();
            this.labelFingerOsoba = new System.Windows.Forms.Label();
            this.labelFingerTocnost = new System.Windows.Forms.Label();
            this.labelFaceOsoba = new System.Windows.Forms.Label();
            this.lblOsobaFinger = new System.Windows.Forms.Label();
            this.lblFingerTocnost = new System.Windows.Forms.Label();
            this.lblFaceTocnost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProvjeraPrsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBoxPocetna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPotvrdaPrsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPotvrdaLica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPotvrdaPrijave)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrijava.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrijava.Location = new System.Drawing.Point(580, 24);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(107, 43);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistracija.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistracija.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistracija.Location = new System.Drawing.Point(731, 24);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(108, 43);
            this.btnRegistracija.TabIndex = 1;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite korisničko ime:";
            // 
            // textBoxKorIme
            // 
            this.textBoxKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKorIme.Location = new System.Drawing.Point(26, 59);
            this.textBoxKorIme.Name = "textBoxKorIme";
            this.textBoxKorIme.Size = new System.Drawing.Size(205, 26);
            this.textBoxKorIme.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Molim unesite uzorak Vašeg prsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(468, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Molim skrenirajte sliku Vašeg lica:";
            // 
            // btnProvjeraPrsta
            // 
            this.btnProvjeraPrsta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProvjeraPrsta.Location = new System.Drawing.Point(31, 455);
            this.btnProvjeraPrsta.Name = "btnProvjeraPrsta";
            this.btnProvjeraPrsta.Size = new System.Drawing.Size(320, 37);
            this.btnProvjeraPrsta.TabIndex = 6;
            this.btnProvjeraPrsta.Text = "Provjera ispravnosti otiska prsta";
            this.btnProvjeraPrsta.UseVisualStyleBackColor = true;
            this.btnProvjeraPrsta.Click += new System.EventHandler(this.btnProvjeraPrsta_Click);
            // 
            // picBoxProvjeraPrsta
            // 
            this.picBoxProvjeraPrsta.Location = new System.Drawing.Point(31, 146);
            this.picBoxProvjeraPrsta.Name = "picBoxProvjeraPrsta";
            this.picBoxProvjeraPrsta.Size = new System.Drawing.Size(320, 240);
            this.picBoxProvjeraPrsta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxProvjeraPrsta.TabIndex = 7;
            this.picBoxProvjeraPrsta.TabStop = false;
            // 
            // btnOcitajPrst
            // 
            this.btnOcitajPrst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOcitajPrst.Location = new System.Drawing.Point(31, 402);
            this.btnOcitajPrst.Name = "btnOcitajPrst";
            this.btnOcitajPrst.Size = new System.Drawing.Size(320, 37);
            this.btnOcitajPrst.TabIndex = 8;
            this.btnOcitajPrst.Text = "Ocitaj otisak prsta";
            this.btnOcitajPrst.UseVisualStyleBackColor = true;
            this.btnOcitajPrst.Click += new System.EventHandler(this.btnOcitajPrst_Click);
            // 
            // cameraBoxPocetna
            // 
            this.cameraBoxPocetna.Location = new System.Drawing.Point(471, 146);
            this.cameraBoxPocetna.Name = "cameraBoxPocetna";
            this.cameraBoxPocetna.Size = new System.Drawing.Size(320, 240);
            this.cameraBoxPocetna.TabIndex = 2;
            this.cameraBoxPocetna.TabStop = false;
            // 
            // btnPrepoznajLice
            // 
            this.btnPrepoznajLice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrepoznajLice.Location = new System.Drawing.Point(471, 402);
            this.btnPrepoznajLice.Name = "btnPrepoznajLice";
            this.btnPrepoznajLice.Size = new System.Drawing.Size(320, 37);
            this.btnPrepoznajLice.TabIndex = 9;
            this.btnPrepoznajLice.Text = "Prepoznaj lice";
            this.btnPrepoznajLice.UseVisualStyleBackColor = true;
            this.btnPrepoznajLice.Click += new System.EventHandler(this.btnPrepoznajLice_Click);
            // 
            // picBoxPotvrdaPrsta
            // 
            this.picBoxPotvrdaPrsta.Location = new System.Drawing.Point(31, 519);
            this.picBoxPotvrdaPrsta.Name = "picBoxPotvrdaPrsta";
            this.picBoxPotvrdaPrsta.Size = new System.Drawing.Size(70, 70);
            this.picBoxPotvrdaPrsta.TabIndex = 10;
            this.picBoxPotvrdaPrsta.TabStop = false;
            // 
            // picBoxPotvrdaLica
            // 
            this.picBoxPotvrdaLica.Location = new System.Drawing.Point(471, 519);
            this.picBoxPotvrdaLica.Name = "picBoxPotvrdaLica";
            this.picBoxPotvrdaLica.Size = new System.Drawing.Size(70, 70);
            this.picBoxPotvrdaLica.TabIndex = 11;
            this.picBoxPotvrdaLica.TabStop = false;
            // 
            // picBoxPotvrdaPrijave
            // 
            this.picBoxPotvrdaPrijave.Location = new System.Drawing.Point(255, 24);
            this.picBoxPotvrdaPrijave.Name = "picBoxPotvrdaPrijave";
            this.picBoxPotvrdaPrijave.Size = new System.Drawing.Size(70, 70);
            this.picBoxPotvrdaPrijave.TabIndex = 12;
            this.picBoxPotvrdaPrijave.TabStop = false;
            // 
            // btnPrihvatiPrepoznato
            // 
            this.btnPrihvatiPrepoznato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrihvatiPrepoznato.Location = new System.Drawing.Point(471, 455);
            this.btnPrihvatiPrepoznato.Name = "btnPrihvatiPrepoznato";
            this.btnPrihvatiPrepoznato.Size = new System.Drawing.Size(320, 37);
            this.btnPrihvatiPrepoznato.TabIndex = 13;
            this.btnPrihvatiPrepoznato.Text = "Prihvati prepoznato lice";
            this.btnPrihvatiPrepoznato.UseVisualStyleBackColor = true;
            this.btnPrihvatiPrepoznato.Click += new System.EventHandler(this.btnPrihvatiPrepoznato_Click);
            // 
            // labelFingerOsoba
            // 
            this.labelFingerOsoba.AutoSize = true;
            this.labelFingerOsoba.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFingerOsoba.Location = new System.Drawing.Point(107, 528);
            this.labelFingerOsoba.Name = "labelFingerOsoba";
            this.labelFingerOsoba.Size = new System.Drawing.Size(158, 19);
            this.labelFingerOsoba.TabIndex = 14;
            this.labelFingerOsoba.Text = "Prepoznata osoba:";
            // 
            // labelFingerTocnost
            // 
            this.labelFingerTocnost.AutoSize = true;
            this.labelFingerTocnost.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFingerTocnost.Location = new System.Drawing.Point(107, 560);
            this.labelFingerTocnost.Name = "labelFingerTocnost";
            this.labelFingerTocnost.Size = new System.Drawing.Size(125, 19);
            this.labelFingerTocnost.TabIndex = 15;
            this.labelFingerTocnost.Text = "Koef. točnosti:";
            // 
            // labelFaceOsoba
            // 
            this.labelFaceOsoba.AutoSize = true;
            this.labelFaceOsoba.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFaceOsoba.Location = new System.Drawing.Point(547, 545);
            this.labelFaceOsoba.Name = "labelFaceOsoba";
            this.labelFaceOsoba.Size = new System.Drawing.Size(158, 19);
            this.labelFaceOsoba.TabIndex = 16;
            this.labelFaceOsoba.Text = "Prepoznata osoba:";
            // 
            // lblOsobaFinger
            // 
            this.lblOsobaFinger.AutoSize = true;
            this.lblOsobaFinger.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOsobaFinger.ForeColor = System.Drawing.Color.Red;
            this.lblOsobaFinger.Location = new System.Drawing.Point(260, 528);
            this.lblOsobaFinger.Name = "lblOsobaFinger";
            this.lblOsobaFinger.Size = new System.Drawing.Size(15, 19);
            this.lblOsobaFinger.TabIndex = 17;
            this.lblOsobaFinger.Text = "-";
            // 
            // lblFingerTocnost
            // 
            this.lblFingerTocnost.AutoSize = true;
            this.lblFingerTocnost.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFingerTocnost.ForeColor = System.Drawing.Color.Red;
            this.lblFingerTocnost.Location = new System.Drawing.Point(226, 560);
            this.lblFingerTocnost.Name = "lblFingerTocnost";
            this.lblFingerTocnost.Size = new System.Drawing.Size(15, 19);
            this.lblFingerTocnost.TabIndex = 18;
            this.lblFingerTocnost.Text = "-";
            // 
            // lblFaceTocnost
            // 
            this.lblFaceTocnost.AutoSize = true;
            this.lblFaceTocnost.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFaceTocnost.ForeColor = System.Drawing.Color.Red;
            this.lblFaceTocnost.Location = new System.Drawing.Point(698, 545);
            this.lblFaceTocnost.Name = "lblFaceTocnost";
            this.lblFaceTocnost.Size = new System.Drawing.Size(15, 19);
            this.lblFaceTocnost.TabIndex = 19;
            this.lblFaceTocnost.Text = "-";
            // 
            // FormAplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 630);
            this.Controls.Add(this.lblFaceTocnost);
            this.Controls.Add(this.lblFingerTocnost);
            this.Controls.Add(this.lblOsobaFinger);
            this.Controls.Add(this.labelFaceOsoba);
            this.Controls.Add(this.labelFingerTocnost);
            this.Controls.Add(this.labelFingerOsoba);
            this.Controls.Add(this.btnPrihvatiPrepoznato);
            this.Controls.Add(this.picBoxPotvrdaPrijave);
            this.Controls.Add(this.picBoxPotvrdaLica);
            this.Controls.Add(this.picBoxPotvrdaPrsta);
            this.Controls.Add(this.btnPrepoznajLice);
            this.Controls.Add(this.cameraBoxPocetna);
            this.Controls.Add(this.btnOcitajPrst);
            this.Controls.Add(this.picBoxProvjeraPrsta);
            this.Controls.Add(this.btnProvjeraPrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKorIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Name = "FormAplikacija";
            this.Text = "Aplikacija - Sef lozinki";
            this.Load += new System.EventHandler(this.FormAplikacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProvjeraPrsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBoxPocetna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPotvrdaPrsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPotvrdaLica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPotvrdaPrijave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKorIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProvjeraPrsta;
        private System.Windows.Forms.PictureBox picBoxProvjeraPrsta;
        private System.Windows.Forms.Button btnOcitajPrst;
        private Emgu.CV.UI.ImageBox cameraBoxPocetna;
        private System.Windows.Forms.Button btnPrepoznajLice;
        private System.Windows.Forms.PictureBox picBoxPotvrdaPrsta;
        private System.Windows.Forms.PictureBox picBoxPotvrdaLica;
        private System.Windows.Forms.PictureBox picBoxPotvrdaPrijave;
        private System.Windows.Forms.Button btnPrihvatiPrepoznato;
        private System.Windows.Forms.Label labelFingerOsoba;
        private System.Windows.Forms.Label labelFingerTocnost;
        private System.Windows.Forms.Label labelFaceOsoba;
        private System.Windows.Forms.Label lblOsobaFinger;
        private System.Windows.Forms.Label lblFingerTocnost;
        private System.Windows.Forms.Label lblFaceTocnost;
    }
}

