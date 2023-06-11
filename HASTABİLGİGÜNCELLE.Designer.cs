namespace Proje_Hastahane
{
    partial class HASTABİLGİGÜNCELLE
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
            btnbilgiGuncelle = new Button();
            label7 = new Label();
            cmbcinsiyet = new ComboBox();
            label6 = new Label();
            msktelefon = new MaskedTextBox();
            label5 = new Label();
            txtsoyad = new TextBox();
            label4 = new Label();
            txtad = new TextBox();
            label3 = new Label();
            txtsifre = new TextBox();
            msktc = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnbilgiGuncelle
            // 
            btnbilgiGuncelle.BackColor = Color.Firebrick;
            btnbilgiGuncelle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnbilgiGuncelle.ForeColor = SystemColors.ButtonFace;
            btnbilgiGuncelle.Location = new Point(293, 477);
            btnbilgiGuncelle.Name = "btnbilgiGuncelle";
            btnbilgiGuncelle.Size = new Size(171, 43);
            btnbilgiGuncelle.TabIndex = 70;
            btnbilgiGuncelle.Text = "GÜNCELLE";
            btnbilgiGuncelle.UseVisualStyleBackColor = false;
            btnbilgiGuncelle.Click += btnbilgiGuncelle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Script", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(25, 32);
            label7.Name = "label7";
            label7.Size = new Size(608, 61);
            label7.TabIndex = 69;
            label7.Text = "BİLGİ GÜNCELLEME EKRANI";
            // 
            // cmbcinsiyet
            // 
            cmbcinsiyet.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cmbcinsiyet.FormattingEnabled = true;
            cmbcinsiyet.Items.AddRange(new object[] { "ERKEK", "KADIN" });
            cmbcinsiyet.Location = new Point(218, 354);
            cmbcinsiyet.Name = "cmbcinsiyet";
            cmbcinsiyet.Size = new Size(246, 39);
            cmbcinsiyet.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(85, 354);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 67;
            label6.Text = "CİNSİYET:";
            // 
            // msktelefon
            // 
            msktelefon.BorderStyle = BorderStyle.FixedSingle;
            msktelefon.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            msktelefon.Location = new Point(218, 302);
            msktelefon.Mask = "00000000000";
            msktelefon.Name = "msktelefon";
            msktelefon.Size = new Size(246, 39);
            msktelefon.TabIndex = 4;
            msktelefon.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(85, 309);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 65;
            label5.Text = "TELEFON:";
            // 
            // txtsoyad
            // 
            txtsoyad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtsoyad.Location = new Point(218, 192);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(246, 39);
            txtsoyad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(108, 199);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 63;
            label4.Text = "SOYAD:";
            // 
            // txtad
            // 
            txtad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtad.Location = new Point(218, 136);
            txtad.Name = "txtad";
            txtad.Size = new Size(246, 39);
            txtad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(149, 143);
            label3.Name = "label3";
            label3.Size = new Size(51, 32);
            label3.TabIndex = 61;
            label3.Text = "AD:";
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtsifre.Location = new Point(218, 409);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(246, 39);
            txtsifre.TabIndex = 6;
            // 
            // msktc
            // 
            msktc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            msktc.Location = new Point(218, 247);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(246, 39);
            msktc.TabIndex = 3;
            msktc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(133, 416);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 58;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(37, 254);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 57;
            label1.Text = "T.C Kimlik No:";
            // 
            // HASTABİLGİGÜNCELLE
            // 
            AcceptButton = btnbilgiGuncelle;
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(657, 564);
            Controls.Add(btnbilgiGuncelle);
            Controls.Add(label7);
            Controls.Add(cmbcinsiyet);
            Controls.Add(label6);
            Controls.Add(msktelefon);
            Controls.Add(label5);
            Controls.Add(txtsoyad);
            Controls.Add(label4);
            Controls.Add(txtad);
            Controls.Add(label3);
            Controls.Add(txtsifre);
            Controls.Add(msktc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "HASTABİLGİGÜNCELLE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HASTABİLGİGÜNCELLE";
            Load += HASTABİLGİGÜNCELLE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnbilgiGuncelle;
        private Label label7;
        private ComboBox cmbcinsiyet;
        private Label label6;
        private MaskedTextBox msktelefon;
        private Label label5;
        private TextBox txtsoyad;
        private Label label4;
        private TextBox txtad;
        private Label label3;
        private TextBox txtsifre;
        private MaskedTextBox msktc;
        private Label label2;
        private Label label1;
    }
}