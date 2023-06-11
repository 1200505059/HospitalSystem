namespace Proje_Hastahane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            groupBox1 = new GroupBox();
            lbldoktoradsoyad = new Label();
            label3 = new Label();
            lbldoktortc = new Label();
            label1 = new Label();
            asdasd = new GroupBox();
            richTextBox1 = new RichTextBox();
            rchsikayet = new RichTextBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            btnduyurular = new Button();
            btncıkıs = new Button();
            btnbilgidüzenle = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            asdasd.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(lbldoktoradsoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbldoktortc);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DOKTOR BİLGİ";
            // 
            // lbldoktoradsoyad
            // 
            lbldoktoradsoyad.AutoSize = true;
            lbldoktoradsoyad.Location = new Point(201, 117);
            lbldoktoradsoyad.Name = "lbldoktoradsoyad";
            lbldoktoradsoyad.Size = new Size(96, 31);
            lbldoktoradsoyad.TabIndex = 3;
            lbldoktoradsoyad.Text = "null null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 117);
            label3.Name = "label3";
            label3.Size = new Size(131, 31);
            label3.TabIndex = 2;
            label3.Text = "AD SOYAD:";
            // 
            // lbldoktortc
            // 
            lbldoktortc.AutoSize = true;
            lbldoktortc.Location = new Point(201, 62);
            lbldoktortc.Name = "lbldoktortc";
            lbldoktortc.Size = new Size(157, 31);
            lbldoktortc.TabIndex = 1;
            lbldoktortc.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 62);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 0;
            label1.Text = "T:C KİMLİK NO:";
            // 
            // asdasd
            // 
            asdasd.BackColor = SystemColors.InactiveCaption;
            asdasd.Controls.Add(richTextBox1);
            asdasd.Controls.Add(rchsikayet);
            asdasd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            asdasd.Location = new Point(12, 185);
            asdasd.Name = "asdasd";
            asdasd.Size = new Size(427, 329);
            asdasd.TabIndex = 1;
            asdasd.TabStop = false;
            asdasd.Text = "RANDEVU DETAY";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(415, 99);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // rchsikayet
            // 
            rchsikayet.Location = new Point(6, 142);
            rchsikayet.Name = "rchsikayet";
            rchsikayet.Size = new Size(415, 158);
            rchsikayet.TabIndex = 0;
            rchsikayet.Text = "";
            rchsikayet.TextChanged += rchsikayet_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(454, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(678, 662);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "RANDEVU LİSTESİ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(672, 625);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.InactiveCaption;
            groupBox4.Controls.Add(btnduyurular);
            groupBox4.Controls.Add(btncıkıs);
            groupBox4.Controls.Add(btnbilgidüzenle);
            groupBox4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(12, 520);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(427, 154);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "HIZLI ERİŞİM";
            // 
            // btnduyurular
            // 
            btnduyurular.BackColor = Color.Moccasin;
            btnduyurular.ForeColor = SystemColors.ActiveCaptionText;
            btnduyurular.Location = new Point(219, 37);
            btnduyurular.Name = "btnduyurular";
            btnduyurular.Size = new Size(191, 45);
            btnduyurular.TabIndex = 3;
            btnduyurular.Text = "DUYURULAR";
            btnduyurular.UseVisualStyleBackColor = false;
            btnduyurular.Click += btnduyurular_Click;
            // 
            // btncıkıs
            // 
            btncıkıs.BackColor = Color.Moccasin;
            btncıkıs.ForeColor = SystemColors.ActiveCaptionText;
            btncıkıs.Location = new Point(22, 88);
            btncıkıs.Name = "btncıkıs";
            btncıkıs.Size = new Size(388, 45);
            btncıkıs.TabIndex = 2;
            btncıkıs.Text = "ÇIKIŞ";
            btncıkıs.UseVisualStyleBackColor = false;
            btncıkıs.Click += btncıkıs_Click;
            // 
            // btnbilgidüzenle
            // 
            btnbilgidüzenle.BackColor = Color.Moccasin;
            btnbilgidüzenle.ForeColor = SystemColors.ActiveCaptionText;
            btnbilgidüzenle.Location = new Point(22, 37);
            btnbilgidüzenle.Name = "btnbilgidüzenle";
            btnbilgidüzenle.Size = new Size(191, 45);
            btnbilgidüzenle.TabIndex = 0;
            btnbilgidüzenle.Text = "BİLGİ DÜZENLE";
            btnbilgidüzenle.UseVisualStyleBackColor = false;
            btnbilgidüzenle.Click += btnbilgidüzenle_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(371, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1152, 675);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(asdasd);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmDoktorDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDoktorDetay";
            Load += FrmDoktorDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            asdasd.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbldoktoradsoyad;
        private Label label3;
        private Label lbldoktortc;
        private Label label1;
        private GroupBox asdasd;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private RichTextBox rchsikayet;
        private GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnduyurular;
        private Button btncıkıs;
        private Button btnbilgidüzenle;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox2;
    }
}