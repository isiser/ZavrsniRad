namespace PratkicniDio_Zavrsni
{
    partial class PrikazLozinki
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAplikacije = new System.Windows.Forms.DataGridView();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.btnUnosApp = new System.Windows.Forms.Button();
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelaPrezime = new System.Windows.Forms.Label();
            this.labelaIme = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNovaApp = new System.Windows.Forms.TextBox();
            this.btnObrisiApp = new System.Windows.Forms.Button();
            this.btnObrisiRacun = new System.Windows.Forms.Button();
            this.pictureBoxStrelica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAplikacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStrelica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaz vaših korištenih aplikacija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(504, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prikaz vaših korisničkih računa:";
            // 
            // dgvAplikacije
            // 
            this.dgvAplikacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAplikacije.Location = new System.Drawing.Point(174, 163);
            this.dgvAplikacije.Name = "dgvAplikacije";
            this.dgvAplikacije.Size = new System.Drawing.Size(197, 158);
            this.dgvAplikacije.TabIndex = 2;
            this.dgvAplikacije.SelectionChanged += new System.EventHandler(this.dgvAplikacije_SelectionChanged);
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(511, 163);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.Size = new System.Drawing.Size(268, 158);
            this.dgvRacuni.TabIndex = 3;
            // 
            // btnUnosApp
            // 
            this.btnUnosApp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnosApp.Location = new System.Drawing.Point(23, 233);
            this.btnUnosApp.Name = "btnUnosApp";
            this.btnUnosApp.Size = new System.Drawing.Size(133, 38);
            this.btnUnosApp.TabIndex = 4;
            this.btnUnosApp.Text = "Unesi novu aplikaciju";
            this.btnUnosApp.UseVisualStyleBackColor = true;
            this.btnUnosApp.Click += new System.EventHandler(this.btnUnosApp_Click);
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoviRacun.Location = new System.Drawing.Point(511, 338);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(129, 38);
            this.btnNoviRacun.TabIndex = 5;
            this.btnNoviRacun.Text = "Unesi novi račun";
            this.btnNoviRacun.UseVisualStyleBackColor = true;
            this.btnNoviRacun.Click += new System.EventHandler(this.btnNoviRacun_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdjava.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdjava.Location = new System.Drawing.Point(695, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(97, 39);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelaPrezime);
            this.groupBox1.Controls.Add(this.labelaIme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o korisniku:";
            // 
            // labelaPrezime
            // 
            this.labelaPrezime.AutoSize = true;
            this.labelaPrezime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaPrezime.Location = new System.Drawing.Point(229, 39);
            this.labelaPrezime.Name = "labelaPrezime";
            this.labelaPrezime.Size = new System.Drawing.Size(50, 18);
            this.labelaPrezime.TabIndex = 9;
            this.labelaPrezime.Text = "label6";
            // 
            // labelaIme
            // 
            this.labelaIme.AutoSize = true;
            this.labelaIme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaIme.Location = new System.Drawing.Point(54, 40);
            this.labelaIme.Name = "labelaIme";
            this.labelaIme.Size = new System.Drawing.Size(50, 18);
            this.labelaIme.TabIndex = 8;
            this.labelaIme.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(146, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(20, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ime aplikacije:";
            // 
            // textBoxNovaApp
            // 
            this.textBoxNovaApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNovaApp.Location = new System.Drawing.Point(23, 194);
            this.textBoxNovaApp.Name = "textBoxNovaApp";
            this.textBoxNovaApp.Size = new System.Drawing.Size(133, 26);
            this.textBoxNovaApp.TabIndex = 9;
            // 
            // btnObrisiApp
            // 
            this.btnObrisiApp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiApp.Location = new System.Drawing.Point(23, 283);
            this.btnObrisiApp.Name = "btnObrisiApp";
            this.btnObrisiApp.Size = new System.Drawing.Size(133, 38);
            this.btnObrisiApp.TabIndex = 10;
            this.btnObrisiApp.Text = "Obriši aplikaciju";
            this.btnObrisiApp.UseVisualStyleBackColor = true;
            this.btnObrisiApp.Click += new System.EventHandler(this.btnObrisiApp_Click);
            // 
            // btnObrisiRacun
            // 
            this.btnObrisiRacun.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiRacun.Location = new System.Drawing.Point(650, 338);
            this.btnObrisiRacun.Name = "btnObrisiRacun";
            this.btnObrisiRacun.Size = new System.Drawing.Size(129, 38);
            this.btnObrisiRacun.TabIndex = 11;
            this.btnObrisiRacun.Text = "Obriši račun";
            this.btnObrisiRacun.UseVisualStyleBackColor = true;
            this.btnObrisiRacun.Click += new System.EventHandler(this.btnObrisiRacun_Click);
            // 
            // pictureBoxStrelica
            // 
            this.pictureBoxStrelica.Location = new System.Drawing.Point(377, 179);
            this.pictureBoxStrelica.Name = "pictureBoxStrelica";
            this.pictureBoxStrelica.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxStrelica.TabIndex = 12;
            this.pictureBoxStrelica.TabStop = false;
            // 
            // PrikazLozinki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 388);
            this.Controls.Add(this.pictureBoxStrelica);
            this.Controls.Add(this.btnObrisiRacun);
            this.Controls.Add(this.btnObrisiApp);
            this.Controls.Add(this.textBoxNovaApp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnNoviRacun);
            this.Controls.Add(this.btnUnosApp);
            this.Controls.Add(this.dgvRacuni);
            this.Controls.Add(this.dgvAplikacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrikazLozinki";
            this.Text = "PrikazLozinki";
            this.Load += new System.EventHandler(this.PrikazLozinki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAplikacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStrelica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAplikacije;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnUnosApp;
        private System.Windows.Forms.Button btnNoviRacun;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelaPrezime;
        private System.Windows.Forms.Label labelaIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNovaApp;
        private System.Windows.Forms.Button btnObrisiApp;
        private System.Windows.Forms.Button btnObrisiRacun;
        private System.Windows.Forms.PictureBox pictureBoxStrelica;
    }
}