namespace PratkicniDio_Zavrsni
{
    partial class Registracija
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxKorIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdaberiPrst = new System.Windows.Forms.Button();
            this.btnRegistraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSpremiSliku = new System.Windows.Forms.Button();
            this.btnPrepoznavanjeLica = new System.Windows.Forms.Button();
            this.pictureBoxPrst = new System.Windows.Forms.PictureBox();
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.pictureBoxLica = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(436, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(401, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(349, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Korisnicko ime:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIme.Location = new System.Drawing.Point(484, 23);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(175, 26);
            this.textBoxIme.TabIndex = 3;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrezime.Location = new System.Drawing.Point(484, 73);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(175, 26);
            this.textBoxPrezime.TabIndex = 4;
            // 
            // textBoxKorIme
            // 
            this.textBoxKorIme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKorIme.Location = new System.Drawing.Point(484, 121);
            this.textBoxKorIme.Name = "textBoxKorIme";
            this.textBoxKorIme.Size = new System.Drawing.Size(175, 26);
            this.textBoxKorIme.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Molim unesite svoj otisak prsta:";
            // 
            // btnOdaberiPrst
            // 
            this.btnOdaberiPrst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberiPrst.Location = new System.Drawing.Point(65, 452);
            this.btnOdaberiPrst.Name = "btnOdaberiPrst";
            this.btnOdaberiPrst.Size = new System.Drawing.Size(200, 40);
            this.btnOdaberiPrst.TabIndex = 7;
            this.btnOdaberiPrst.Text = "Unesi";
            this.btnOdaberiPrst.UseVisualStyleBackColor = true;
            this.btnOdaberiPrst.Click += new System.EventHandler(this.btnOdaberiPrst_Click);
            // 
            // btnRegistraj
            // 
            this.btnRegistraj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistraj.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistraj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistraj.Location = new System.Drawing.Point(368, 520);
            this.btnRegistraj.Name = "btnRegistraj";
            this.btnRegistraj.Size = new System.Drawing.Size(336, 41);
            this.btnRegistraj.TabIndex = 8;
            this.btnRegistraj.Text = "Registriraj se ";
            this.btnRegistraj.UseVisualStyleBackColor = false;
            this.btnRegistraj.Click += new System.EventHandler(this.btnRegistraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Molim napravite sliku vašeg lica:";
            // 
            // btnSpremiSliku
            // 
            this.btnSpremiSliku.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiSliku.Location = new System.Drawing.Point(728, 452);
            this.btnSpremiSliku.Name = "btnSpremiSliku";
            this.btnSpremiSliku.Size = new System.Drawing.Size(200, 40);
            this.btnSpremiSliku.TabIndex = 11;
            this.btnSpremiSliku.Text = "Spremi lice";
            this.btnSpremiSliku.UseVisualStyleBackColor = true;
            this.btnSpremiSliku.Click += new System.EventHandler(this.btnSpremiSliku_Click);
            // 
            // btnPrepoznavanjeLica
            // 
            this.btnPrepoznavanjeLica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrepoznavanjeLica.Location = new System.Drawing.Point(416, 452);
            this.btnPrepoznavanjeLica.Name = "btnPrepoznavanjeLica";
            this.btnPrepoznavanjeLica.Size = new System.Drawing.Size(200, 40);
            this.btnPrepoznavanjeLica.TabIndex = 12;
            this.btnPrepoznavanjeLica.Text = "Prepoznavanje lica";
            this.btnPrepoznavanjeLica.UseVisualStyleBackColor = true;
            this.btnPrepoznavanjeLica.Click += new System.EventHandler(this.btnPrepoznavanjeLica_Click);
            // 
            // pictureBoxPrst
            // 
            this.pictureBoxPrst.Location = new System.Drawing.Point(36, 213);
            this.pictureBoxPrst.Name = "pictureBoxPrst";
            this.pictureBoxPrst.Size = new System.Drawing.Size(276, 220);
            this.pictureBoxPrst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPrst.TabIndex = 13;
            this.pictureBoxPrst.TabStop = false;
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(378, 213);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(268, 220);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // pictureBoxLica
            // 
            this.pictureBoxLica.Location = new System.Drawing.Point(698, 213);
            this.pictureBoxLica.Name = "pictureBoxLica";
            this.pictureBoxLica.Size = new System.Drawing.Size(256, 220);
            this.pictureBoxLica.TabIndex = 14;
            this.pictureBoxLica.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(22, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 339);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(353, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(618, 339);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 583);
            this.Controls.Add(this.pictureBoxLica);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.pictureBoxPrst);
            this.Controls.Add(this.btnPrepoznavanjeLica);
            this.Controls.Add(this.btnSpremiSliku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegistraj);
            this.Controls.Add(this.btnOdaberiPrst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKorIme);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Registracija";
            this.Text = "Registracija";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxKorIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdaberiPrst;
        private System.Windows.Forms.Button btnRegistraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSpremiSliku;
        private System.Windows.Forms.Button btnPrepoznavanjeLica;
        private System.Windows.Forms.PictureBox pictureBoxPrst;
        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.PictureBox pictureBoxLica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}