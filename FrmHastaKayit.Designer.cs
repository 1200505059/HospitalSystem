namespace Proje_Hastahane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnkaydol = new Button();
            txtsifre = new TextBox();
            msktc = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtad = new TextBox();
            txtsoyad = new TextBox();
            msktelefon = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            cmbcinsiyet = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(7, 89);
            label3.Name = "label3";
            label3.Size = new Size(524, 73);
            label3.TabIndex = 14;
            label3.Text = "HASTA ÜYE EKRANI";
            // 
            // btnkaydol
            // 
            btnkaydol.BackColor = Color.DarkOliveGreen;
            btnkaydol.ForeColor = SystemColors.ButtonFace;
            btnkaydol.Location = new Point(306, 567);
            btnkaydol.Name = "btnkaydol";
            btnkaydol.Size = new Size(116, 41);
            btnkaydol.TabIndex = 7;
            btnkaydol.Text = "KAYDOL";
            btnkaydol.UseVisualStyleBackColor = false;
            btnkaydol.Click += btnkaydol_Click;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(176, 445);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(246, 39);
            txtsifre.TabIndex = 5;
            // 
            // msktc
            // 
            msktc.Location = new Point(176, 330);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(246, 39);
            msktc.TabIndex = 3;
            msktc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(97, 445);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 9;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 337);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 8;
            label1.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(72, 269);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 17;
            label4.Text = "SOYAD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(113, 212);
            label5.Name = "label5";
            label5.Size = new Size(51, 32);
            label5.TabIndex = 16;
            label5.Text = "AD:";
            // 
            // txtad
            // 
            txtad.Location = new Point(176, 205);
            txtad.Name = "txtad";
            txtad.Size = new Size(246, 39);
            txtad.TabIndex = 1;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(176, 266);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(246, 39);
            txtsoyad.TabIndex = 2;
            // 
            // msktelefon
            // 
            msktelefon.Location = new Point(176, 386);
            msktelefon.Mask = "00000000000";
            msktelefon.Name = "msktelefon";
            msktelefon.Size = new Size(246, 39);
            msktelefon.TabIndex = 4;
            msktelefon.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(49, 393);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 20;
            label6.Text = "TELEFON:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(49, 510);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 22;
            label7.Text = "CİNSİYET:";
            // 
            // cmbcinsiyet
            // 
            cmbcinsiyet.FormattingEnabled = true;
            cmbcinsiyet.Items.AddRange(new object[] { "ERKEK", "KADIN" });
            cmbcinsiyet.Location = new Point(176, 510);
            cmbcinsiyet.Name = "cmbcinsiyet";
            cmbcinsiyet.Size = new Size(246, 39);
            cmbcinsiyet.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(176, 567);
            button1.Name = "button1";
            button1.Size = new Size(116, 41);
            button1.TabIndex = 23;
            button1.Text = "GERİ ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmHastaKayit
            // 
            AcceptButton = btnkaydol;
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(580, 661);
            Controls.Add(button1);
            Controls.Add(cmbcinsiyet);
            Controls.Add(label7);
            Controls.Add(msktelefon);
            Controls.Add(label6);
            Controls.Add(txtsoyad);
            Controls.Add(txtad);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnkaydol);
            Controls.Add(txtsifre);
            Controls.Add(msktc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_uyeol";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Button btnkaydol;
        private TextBox txtsifre;
        private MaskedTextBox msktc;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtad;
        private TextBox txtsoyad;
        private MaskedTextBox msktelefon;
        private Label label6;
        private Label label7;
        private ComboBox cmbcinsiyet;
        private Button button1;
    }
}