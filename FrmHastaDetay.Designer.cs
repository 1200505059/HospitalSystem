namespace Proje_Hastahane
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            label3 = new Label();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnhastaguncel = new Button();
            lbltc = new Label();
            label4 = new Label();
            lbladsoyad = new Label();
            groupBox2 = new GroupBox();
            txtid = new TextBox();
            label2 = new Label();
            btnradevual = new Button();
            label7 = new Label();
            rchsikayet = new RichTextBox();
            cmbdoktor = new ComboBox();
            cmbbrans = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(9, 46);
            label3.Name = "label3";
            label3.Size = new Size(175, 32);
            label3.TabIndex = 9;
            label3.Text = "T.C KİMLİK NO:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnhastaguncel);
            groupBox1.Controls.Add(lbltc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbladsoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 170);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLGİLER";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(395, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(441, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(473, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnhastaguncel
            // 
            btnhastaguncel.BackColor = Color.Silver;
            btnhastaguncel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnhastaguncel.ForeColor = SystemColors.ButtonFace;
            btnhastaguncel.Location = new Point(361, 121);
            btnhastaguncel.Name = "btnhastaguncel";
            btnhastaguncel.Size = new Size(157, 43);
            btnhastaguncel.TabIndex = 20;
            btnhastaguncel.Text = "GüNCELLE";
            btnhastaguncel.UseVisualStyleBackColor = false;
            btnhastaguncel.Click += btnhastaguncel_Click;
            // 
            // lbltc
            // 
            lbltc.AutoSize = true;
            lbltc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbltc.Location = new Point(179, 46);
            lbltc.Name = "lbltc";
            lbltc.Size = new Size(157, 32);
            lbltc.TabIndex = 13;
            lbltc.Text = "00000000000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(53, 94);
            label4.Name = "label4";
            label4.Size = new Size(131, 32);
            label4.TabIndex = 12;
            label4.Text = "AD SOYAD:";
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbladsoyad.ForeColor = SystemColors.ButtonFace;
            lbladsoyad.Location = new Point(179, 94);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(101, 32);
            lbladsoyad.TabIndex = 11;
            lbladsoyad.Text = "null null";
            lbladsoyad.Click += lbladsoyad_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtid);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnradevual);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(rchsikayet);
            groupBox2.Controls.Add(cmbdoktor);
            groupBox2.Controls.Add(cmbbrans);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(3, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 407);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "RANDEVU PANELİ";
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(148, 68);
            txtid.Name = "txtid";
            txtid.Size = new Size(207, 39);
            txtid.TabIndex = 21;
            txtid.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(11, 72);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 20;
            label2.Text = "RandevuNo:";
            label2.Visible = false;
            // 
            // btnradevual
            // 
            btnradevual.BackColor = Color.Silver;
            btnradevual.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnradevual.ForeColor = SystemColors.ButtonFace;
            btnradevual.Location = new Point(355, 340);
            btnradevual.Name = "btnradevual";
            btnradevual.Size = new Size(163, 43);
            btnradevual.TabIndex = 19;
            btnradevual.Text = "RANDEVU AL";
            btnradevual.UseVisualStyleBackColor = false;
            btnradevual.Click += btnradevual_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(39, 248);
            label7.Name = "label7";
            label7.Size = new Size(103, 32);
            label7.TabIndex = 15;
            label7.Text = "ŞİKAYET:";
            // 
            // rchsikayet
            // 
            rchsikayet.BackColor = Color.FromArgb(224, 224, 224);
            rchsikayet.Location = new Point(148, 214);
            rchsikayet.Name = "rchsikayet";
            rchsikayet.Size = new Size(325, 120);
            rchsikayet.TabIndex = 14;
            rchsikayet.Text = "";
            // 
            // cmbdoktor
            // 
            cmbdoktor.FormattingEnabled = true;
            cmbdoktor.Location = new Point(148, 169);
            cmbdoktor.Name = "cmbdoktor";
            cmbdoktor.Size = new Size(207, 39);
            cmbdoktor.TabIndex = 13;
            cmbdoktor.SelectedIndexChanged += cmbdoktor_SelectedIndexChanged;
            // 
            // cmbbrans
            // 
            cmbbrans.FormattingEnabled = true;
            cmbbrans.Location = new Point(148, 117);
            cmbbrans.Name = "cmbbrans";
            cmbbrans.Size = new Size(207, 39);
            cmbbrans.TabIndex = 12;
            cmbbrans.SelectedIndexChanged += cmbbrans_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(30, 172);
            label6.Name = "label6";
            label6.Size = new Size(112, 32);
            label6.TabIndex = 11;
            label6.Text = "DOKTOR:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(49, 127);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 10;
            label1.Text = "BRANŞ:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(542, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(940, 245);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "RANDEVU GEÇMİŞİ";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(934, 207);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(542, 256);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(940, 335);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "AKTİF RANDEVULAR";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(934, 297);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1488, 606);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "FrmHastaDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Detay";
            Load += FrmHastaDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private Label lbltc;
        private Label label4;
        private Label lbladsoyad;
        private GroupBox groupBox2;
        private Label label7;
        private RichTextBox rchsikayet;
        private ComboBox cmbdoktor;
        private ComboBox cmbbrans;
        private Label label6;
        private Label label1;
        private Button btnradevual;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private Button btnhastaguncel;
        private TextBox txtid;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}