namespace Proje_Hastahane
{
    partial class FrmDoktorBilgiDüzenle
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
            txtsoyad = new TextBox();
            label4 = new Label();
            txtad = new TextBox();
            label3 = new Label();
            msktc = new MaskedTextBox();
            label1 = new Label();
            btnbilgiGuncelle = new Button();
            txtsifre = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label5 = new Label();
            cmbbrans = new ComboBox();
            SuspendLayout();
            // 
            // txtsoyad
            // 
            txtsoyad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtsoyad.Location = new Point(220, 171);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(246, 39);
            txtsoyad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(110, 178);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 55;
            label4.Text = "SOYAD:";
            // 
            // txtad
            // 
            txtad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtad.Location = new Point(220, 115);
            txtad.Name = "txtad";
            txtad.Size = new Size(246, 39);
            txtad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(151, 122);
            label3.Name = "label3";
            label3.Size = new Size(51, 32);
            label3.TabIndex = 53;
            label3.Text = "AD:";
            // 
            // msktc
            // 
            msktc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            msktc.Location = new Point(220, 298);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(246, 39);
            msktc.TabIndex = 3;
            msktc.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(39, 305);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 51;
            label1.Text = "T.C Kimlik No:";
            // 
            // btnbilgiGuncelle
            // 
            btnbilgiGuncelle.BackColor = Color.Firebrick;
            btnbilgiGuncelle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnbilgiGuncelle.ForeColor = SystemColors.ButtonFace;
            btnbilgiGuncelle.Location = new Point(295, 429);
            btnbilgiGuncelle.Name = "btnbilgiGuncelle";
            btnbilgiGuncelle.Size = new Size(171, 43);
            btnbilgiGuncelle.TabIndex = 5;
            btnbilgiGuncelle.Text = "GÜNCELLE";
            btnbilgiGuncelle.UseVisualStyleBackColor = false;
            btnbilgiGuncelle.Click += btnbilgiGuncelle_Click;
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtsifre.Location = new Point(220, 361);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(246, 39);
            txtsifre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(135, 368);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 57;
            label2.Text = "Şifre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Script", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(13, 42);
            label7.Name = "label7";
            label7.Size = new Size(608, 61);
            label7.TabIndex = 60;
            label7.Text = "BİLGİ GÜNCELLEME EKRANI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(109, 240);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 61;
            label5.Text = "BRANŞ:";
            // 
            // cmbbrans
            // 
            cmbbrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbrans.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cmbbrans.FormattingEnabled = true;
            cmbbrans.Location = new Point(220, 233);
            cmbbrans.Name = "cmbbrans";
            cmbbrans.Size = new Size(241, 39);
            cmbbrans.TabIndex = 62;
            cmbbrans.SelectedIndexChanged += cmbbrans_SelectedIndexChanged;
            cmbbrans.Click += cmbbrans_Click;
            // 
            // FrmDoktorBilgiDüzenle
            // 
            AcceptButton = btnbilgiGuncelle;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(641, 475);
            Controls.Add(cmbbrans);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(btnbilgiGuncelle);
            Controls.Add(txtsifre);
            Controls.Add(label2);
            Controls.Add(txtsoyad);
            Controls.Add(label4);
            Controls.Add(txtad);
            Controls.Add(label3);
            Controls.Add(msktc);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmDoktorBilgiDüzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDoktorBilgiDüzenle";
            Load += FrmDoktorBilgiDüzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsoyad;
        private Label label4;
        private TextBox txtad;
        private Label label3;
        private MaskedTextBox msktc;
        private Label label1;
        private Button btnbilgiGuncelle;
        private TextBox txtsifre;
        private Label label2;
        private Label label7;
        private Label label5;
        private ComboBox cmbbrans;
    }
}