namespace Proje_Hastahane
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btngiris = new Button();
            txtsifre = new TextBox();
            msktc = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(702, 78);
            label3.TabIndex = 14;
            label3.Text = "SEKRETER GİRİŞ EKRANI";
            // 
            // btngiris
            // 
            btngiris.BackColor = Color.DarkOliveGreen;
            btngiris.ForeColor = SystemColors.ButtonFace;
            btngiris.Location = new Point(347, 355);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(114, 41);
            btngiris.TabIndex = 12;
            btngiris.Text = "GİRİŞ";
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(215, 286);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(246, 39);
            txtsifre.TabIndex = 11;
            txtsifre.UseSystemPasswordChar = true;
            // 
            // msktc
            // 
            msktc.Location = new Point(215, 225);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(246, 39);
            msktc.TabIndex = 10;
            msktc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(139, 293);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 9;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(49, 232);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 8;
            label1.Text = "TC Kimlik No:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(720, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmSekreterGiris
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(769, 501);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btngiris);
            Controls.Add(txtsifre);
            Controls.Add(msktc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmSekreterGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSekreterGiris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Button btngiris;
        private TextBox txtsifre;
        private MaskedTextBox msktc;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
    }
}