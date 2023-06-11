namespace Proje_Hastahane
{
    partial class Frm_girisler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_girisler));
            btnhastailkgiris = new Button();
            btindoktorilkgiris = new Button();
            btnsekreterilkgiris = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnhastailkgiris
            // 
            btnhastailkgiris.BackgroundImage = (Image)resources.GetObject("btnhastailkgiris.BackgroundImage");
            btnhastailkgiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnhastailkgiris.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnhastailkgiris.Location = new Point(40, 304);
            btnhastailkgiris.Name = "btnhastailkgiris";
            btnhastailkgiris.Size = new Size(268, 228);
            btnhastailkgiris.TabIndex = 0;
            btnhastailkgiris.UseVisualStyleBackColor = true;
            btnhastailkgiris.Click += btnhastailkgiris_Click;
            // 
            // btindoktorilkgiris
            // 
            btindoktorilkgiris.BackgroundImage = (Image)resources.GetObject("btindoktorilkgiris.BackgroundImage");
            btindoktorilkgiris.BackgroundImageLayout = ImageLayout.Stretch;
            btindoktorilkgiris.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btindoktorilkgiris.Location = new Point(376, 304);
            btindoktorilkgiris.Name = "btindoktorilkgiris";
            btindoktorilkgiris.Size = new Size(268, 228);
            btindoktorilkgiris.TabIndex = 1;
            btindoktorilkgiris.UseVisualStyleBackColor = true;
            btindoktorilkgiris.Click += btindoktorilkgiris_Click;
            // 
            // btnsekreterilkgiris
            // 
            btnsekreterilkgiris.BackgroundImage = (Image)resources.GetObject("btnsekreterilkgiris.BackgroundImage");
            btnsekreterilkgiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnsekreterilkgiris.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnsekreterilkgiris.Location = new Point(709, 304);
            btnsekreterilkgiris.Name = "btnsekreterilkgiris";
            btnsekreterilkgiris.Size = new Size(268, 228);
            btnsekreterilkgiris.TabIndex = 2;
            btnsekreterilkgiris.UseVisualStyleBackColor = true;
            btnsekreterilkgiris.Click += btnsekreterilkgiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(127, 558);
            label1.Name = "label1";
            label1.Size = new Size(101, 37);
            label1.TabIndex = 3;
            label1.Text = "HASTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(463, 558);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 4;
            label2.Text = "DOKTOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(778, 558);
            label3.Name = "label3";
            label3.Size = new Size(140, 37);
            label3.TabIndex = 5;
            label3.Text = "SEKRETER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(549, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Vladimir Script", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 79);
            label4.Name = "label4";
            label4.Size = new Size(591, 97);
            label4.TabIndex = 7;
            label4.Text = "HASTAHANE ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(971, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Frm_girisler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1038, 724);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsekreterilkgiris);
            Controls.Add(btindoktorilkgiris);
            Controls.Add(btnhastailkgiris);
            MaximizeBox = false;
            Name = "Frm_girisler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HASTAHANE";
            Load += Frm_girisler_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnhastailkgiris;
        private Button btindoktorilkgiris;
        private Button btnsekreterilkgiris;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
    }
}