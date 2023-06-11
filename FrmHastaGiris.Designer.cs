namespace Proje_Hastahane
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            label1 = new Label();
            label2 = new Label();
            msktc = new MaskedTextBox();
            txtsifre = new TextBox();
            btngiris = new Button();
            btnuyeol = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(49, 258);
            label1.Name = "label1";
            label1.Size = new Size(160, 31);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(139, 319);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // msktc
            // 
            msktc.Location = new Point(215, 251);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(246, 38);
            msktc.TabIndex = 2;
            msktc.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(215, 312);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(246, 38);
            txtsifre.TabIndex = 3;
            txtsifre.UseSystemPasswordChar = true;
            // 
            // btngiris
            // 
            btngiris.BackColor = Color.DarkOliveGreen;
            btngiris.ForeColor = SystemColors.ButtonFace;
            btngiris.Location = new Point(347, 381);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(114, 41);
            btngiris.TabIndex = 4;
            btngiris.Text = "GİRİŞ";
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // btnuyeol
            // 
            btnuyeol.BackColor = Color.SeaGreen;
            btnuyeol.Location = new Point(215, 381);
            btnuyeol.Name = "btnuyeol";
            btnuyeol.Size = new Size(114, 41);
            btnuyeol.TabIndex = 5;
            btnuyeol.Text = "Üye Ol";
            btnuyeol.UseVisualStyleBackColor = false;
            btnuyeol.Click += btnuyeol_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 32F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(677, 90);
            label3.TabIndex = 6;
            label3.Text = "HASTA GİRİŞ EKRANI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(697, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmHastaGiris
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(749, 510);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnuyeol);
            Controls.Add(btngiris);
            Controls.Add(txtsifre);
            Controls.Add(msktc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(5);
            Name = "FrmHastaGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmHastaGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox msktc;
        private TextBox txtsifre;
        private Button btngiris;
        private Button btnuyeol;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}