namespace Proje_Hastahane
{
    partial class Frmdoktorislem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdoktorislem));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnsil = new Button();
            txtad = new TextBox();
            txtsoyad = new TextBox();
            txtsifre = new TextBox();
            msktc = new MaskedTextBox();
            cmbbrans = new ComboBox();
            btnguncelle = new Button();
            btnekle = new Button();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 69);
            label1.Name = "label1";
            label1.Size = new Size(52, 31);
            label1.TabIndex = 0;
            label1.Text = "AD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 117);
            label2.Name = "label2";
            label2.Size = new Size(93, 31);
            label2.TabIndex = 1;
            label2.Text = "SOYAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 166);
            label3.Name = "label3";
            label3.Size = new Size(94, 31);
            label3.TabIndex = 2;
            label3.Text = "BRANŞ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 213);
            label4.Name = "label4";
            label4.Size = new Size(51, 31);
            label4.TabIndex = 3;
            label4.Text = "T.C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 254);
            label5.Name = "label5";
            label5.Size = new Size(78, 31);
            label5.TabIndex = 4;
            label5.Text = "ŞİFRE:";
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Silver;
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(239, 308);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(79, 43);
            btnsil.TabIndex = 7;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // txtad
            // 
            txtad.Location = new Point(116, 66);
            txtad.Name = "txtad";
            txtad.Size = new Size(202, 38);
            txtad.TabIndex = 1;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(116, 114);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(202, 38);
            txtsoyad.TabIndex = 2;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(116, 254);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(202, 38);
            txtsifre.TabIndex = 5;
            // 
            // msktc
            // 
            msktc.Location = new Point(116, 210);
            msktc.Mask = "00000000000";
            msktc.Name = "msktc";
            msktc.Size = new Size(202, 38);
            msktc.TabIndex = 4;
            msktc.ValidatingType = typeof(int);
            // 
            // cmbbrans
            // 
            cmbbrans.FormattingEnabled = true;
            cmbbrans.Location = new Point(116, 158);
            cmbbrans.Name = "cmbbrans";
            cmbbrans.Size = new Size(202, 39);
            cmbbrans.TabIndex = 3;
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.Silver;
            btnguncelle.ForeColor = Color.White;
            btnguncelle.Location = new Point(116, 357);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(202, 43);
            btnguncelle.TabIndex = 8;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.Silver;
            btnekle.ForeColor = Color.White;
            btnekle.Location = new Point(116, 308);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(79, 43);
            btnekle.TabIndex = 6;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(333, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(860, 334);
            dataGridView1.TabIndex = 9;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1143, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Frmdoktorislem
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1203, 414);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(btnekle);
            Controls.Add(btnguncelle);
            Controls.Add(cmbbrans);
            Controls.Add(msktc);
            Controls.Add(txtsifre);
            Controls.Add(txtsoyad);
            Controls.Add(txtad);
            Controls.Add(btnsil);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Frmdoktorislem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmdoktorislem";
            Load += Frmdoktorislem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnsil;
        private TextBox txtad;
        private TextBox txtsoyad;
        private TextBox txtsifre;
        private MaskedTextBox msktc;
        private ComboBox cmbbrans;
        private Button btnguncelle;
        private Button btnekle;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
    }
}