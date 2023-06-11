namespace Proje_Hastahane
{
    partial class FrmSekreterDetay
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
            rchduyuru = new GroupBox();
            lbladsoyad = new Label();
            label3 = new Label();
            lbltc = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnolustur = new Button();
            richTextBox1 = new RichTextBox();
            groupBox3 = new GroupBox();
            btnkaydet = new Button();
            chkdurum = new CheckBox();
            msktc = new MaskedTextBox();
            cmbdoktor = new ComboBox();
            cmbbrans = new ComboBox();
            msksaat = new MaskedTextBox();
            msktarih = new MaskedTextBox();
            txtid = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            btnduyurular = new Button();
            btnrandevuislem = new Button();
            btnbransislem = new Button();
            btndoktorislem = new Button();
            rchduyuru.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // rchduyuru
            // 
            rchduyuru.BackColor = Color.RosyBrown;
            rchduyuru.Controls.Add(lbladsoyad);
            rchduyuru.Controls.Add(label3);
            rchduyuru.Controls.Add(lbltc);
            rchduyuru.Controls.Add(label1);
            rchduyuru.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rchduyuru.Location = new Point(12, 12);
            rchduyuru.Name = "rchduyuru";
            rchduyuru.Size = new Size(427, 167);
            rchduyuru.TabIndex = 1;
            rchduyuru.TabStop = false;
            rchduyuru.Text = "SEKRETER BİLGİ";
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Location = new Point(201, 117);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(96, 31);
            lbladsoyad.TabIndex = 3;
            lbladsoyad.Text = "null null";
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
            // lbltc
            // 
            lbltc.AutoSize = true;
            lbltc.Location = new Point(201, 62);
            lbltc.Name = "lbltc";
            lbltc.Size = new Size(157, 31);
            lbltc.TabIndex = 1;
            lbltc.Text = "00000000000";
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.RosyBrown;
            groupBox2.Controls.Add(btnolustur);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 330);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DUYURU OLUŞTUR";
            // 
            // btnolustur
            // 
            btnolustur.BackColor = Color.FromArgb(224, 224, 224);
            btnolustur.Location = new Point(6, 247);
            btnolustur.Name = "btnolustur";
            btnolustur.Size = new Size(415, 60);
            btnolustur.TabIndex = 1;
            btnolustur.Text = "OLUŞTUR";
            btnolustur.UseVisualStyleBackColor = false;
            btnolustur.Click += btnolustur_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(415, 204);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.RosyBrown;
            groupBox3.Controls.Add(btnkaydet);
            groupBox3.Controls.Add(chkdurum);
            groupBox3.Controls.Add(msktc);
            groupBox3.Controls.Add(cmbdoktor);
            groupBox3.Controls.Add(cmbbrans);
            groupBox3.Controls.Add(msksaat);
            groupBox3.Controls.Add(msktarih);
            groupBox3.Controls.Add(txtid);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(445, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(427, 515);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "RANDEVU PANELİ";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.FromArgb(224, 224, 224);
            btnkaydet.Location = new Point(128, 432);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(249, 60);
            btnkaydet.TabIndex = 19;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // chkdurum
            // 
            chkdurum.AutoSize = true;
            chkdurum.Location = new Point(128, 391);
            chkdurum.Name = "chkdurum";
            chkdurum.Size = new Size(120, 35);
            chkdurum.TabIndex = 16;
            chkdurum.Text = "DURUM";
            chkdurum.UseVisualStyleBackColor = true;
            // 
            // msktc
            // 
            msktc.Location = new Point(128, 333);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(235, 38);
            msktc.TabIndex = 15;
            msktc.ValidatingType = typeof(int);
            // 
            // cmbdoktor
            // 
            cmbdoktor.FormattingEnabled = true;
            cmbdoktor.Location = new Point(128, 270);
            cmbdoktor.Name = "cmbdoktor";
            cmbdoktor.Size = new Size(235, 39);
            cmbdoktor.TabIndex = 14;
            cmbdoktor.SelectedIndexChanged += cmbdoktor_SelectedIndexChanged;
            // 
            // cmbbrans
            // 
            cmbbrans.FormattingEnabled = true;
            cmbbrans.Location = new Point(128, 208);
            cmbbrans.Name = "cmbbrans";
            cmbbrans.Size = new Size(235, 39);
            cmbbrans.TabIndex = 13;
            cmbbrans.SelectedIndexChanged += cmbbrans_SelectedIndexChanged;
            // 
            // msksaat
            // 
            msksaat.Location = new Point(128, 151);
            msksaat.Mask = "00:00";
            msksaat.Name = "msksaat";
            msksaat.Size = new Size(235, 38);
            msksaat.TabIndex = 12;
            msksaat.ValidatingType = typeof(DateTime);
            // 
            // msktarih
            // 
            msktarih.Location = new Point(128, 95);
            msktarih.Mask = "00/00/0000";
            msktarih.Name = "msktarih";
            msktarih.Size = new Size(235, 38);
            msktarih.TabIndex = 11;
            msktarih.ValidatingType = typeof(DateTime);
            // 
            // txtid
            // 
            txtid.Location = new Point(128, 37);
            txtid.Name = "txtid";
            txtid.Size = new Size(235, 38);
            txtid.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 340);
            label9.Name = "label9";
            label9.Size = new Size(51, 31);
            label9.TabIndex = 9;
            label9.Text = "T.C:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 278);
            label7.Name = "label7";
            label7.Size = new Size(111, 31);
            label7.TabIndex = 7;
            label7.Text = "DOKTOR:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 216);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 6;
            label6.Text = "BRANŞ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 158);
            label5.Name = "label5";
            label5.Size = new Size(74, 31);
            label5.TabIndex = 5;
            label5.Text = "SAAT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 102);
            label4.Name = "label4";
            label4.Size = new Size(84, 31);
            label4.TabIndex = 4;
            label4.Text = "TARİH:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 44);
            label2.Name = "label2";
            label2.Size = new Size(44, 31);
            label2.TabIndex = 3;
            label2.Text = "İD:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(878, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(876, 355);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "BRANŞLAR";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(870, 318);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(878, 363);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(879, 340);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "DOKTORLAR";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.RosyBrown;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 34);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(873, 303);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.RosyBrown;
            groupBox6.Controls.Add(btnduyurular);
            groupBox6.Controls.Add(btnrandevuislem);
            groupBox6.Controls.Add(btnbransislem);
            groupBox6.Controls.Add(btndoktorislem);
            groupBox6.Location = new Point(12, 541);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(863, 162);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "DOKTORLAR";
            // 
            // btnduyurular
            // 
            btnduyurular.BackColor = Color.FromArgb(224, 224, 224);
            btnduyurular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnduyurular.Location = new Point(651, 56);
            btnduyurular.Name = "btnduyurular";
            btnduyurular.Size = new Size(211, 60);
            btnduyurular.TabIndex = 5;
            btnduyurular.Text = "DUYURULAR";
            btnduyurular.UseVisualStyleBackColor = false;
            btnduyurular.Click += btnduyurular_Click;
            // 
            // btnrandevuislem
            // 
            btnrandevuislem.BackColor = Color.FromArgb(224, 224, 224);
            btnrandevuislem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnrandevuislem.Location = new Point(434, 56);
            btnrandevuislem.Name = "btnrandevuislem";
            btnrandevuislem.Size = new Size(211, 60);
            btnrandevuislem.TabIndex = 4;
            btnrandevuislem.Text = "RANDEVU İŞLEMLERİ";
            btnrandevuislem.UseVisualStyleBackColor = false;
            btnrandevuislem.Click += btnrandevuislem_Click;
            // 
            // btnbransislem
            // 
            btnbransislem.BackColor = Color.FromArgb(224, 224, 224);
            btnbransislem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnbransislem.Location = new Point(217, 56);
            btnbransislem.Name = "btnbransislem";
            btnbransislem.Size = new Size(211, 60);
            btnbransislem.TabIndex = 3;
            btnbransislem.Text = "BRANŞ İŞLEMLERİ";
            btnbransislem.UseVisualStyleBackColor = false;
            btnbransislem.Click += btnbransislem_Click;
            // 
            // btndoktorislem
            // 
            btndoktorislem.BackColor = Color.FromArgb(224, 224, 224);
            btndoktorislem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndoktorislem.Location = new Point(0, 56);
            btndoktorislem.Name = "btndoktorislem";
            btndoktorislem.Size = new Size(211, 60);
            btndoktorislem.TabIndex = 2;
            btndoktorislem.Text = "DOKTOR İŞLEMLERİ";
            btndoktorislem.UseVisualStyleBackColor = false;
            btndoktorislem.Click += btndoktorislem_Click;
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1760, 713);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(rchduyuru);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmSekreterDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSekreterDetay";
            Load += FrmSekreterDetay_Load;
            rchduyuru.ResumeLayout(false);
            rchduyuru.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox rchduyuru;
        private Label lbladsoyad;
        private Label label3;
        private Label lbltc;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnolustur;
        private RichTextBox richTextBox1;
        private GroupBox groupBox3;
        private ComboBox cmbbrans;
        private MaskedTextBox msksaat;
        private MaskedTextBox msktarih;
        private TextBox txtid;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btnkaydet;
        private CheckBox chkdurum;
        private MaskedTextBox msktc;
        private ComboBox cmbdoktor;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Button btnrandevuislem;
        private Button btnbransislem;
        private Button btndoktorislem;
        private Button btnduyurular;
    }
}