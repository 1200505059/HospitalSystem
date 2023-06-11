namespace Proje_Hastahane
{
    partial class Frmbransislem
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
            btnekle = new Button();
            btnguncelle = new Button();
            txtbransad = new TextBox();
            txtbransİD = new TextBox();
            btnsil = new Button();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.Silver;
            btnekle.ForeColor = Color.White;
            btnekle.Location = new Point(139, 122);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(79, 43);
            btnekle.TabIndex = 28;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.Silver;
            btnguncelle.ForeColor = Color.White;
            btnguncelle.Location = new Point(139, 171);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(202, 43);
            btnguncelle.TabIndex = 27;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // txtbransad
            // 
            txtbransad.Location = new Point(139, 70);
            txtbransad.Name = "txtbransad";
            txtbransad.Size = new Size(202, 39);
            txtbransad.TabIndex = 23;
            // 
            // txtbransİD
            // 
            txtbransİD.Location = new Point(139, 26);
            txtbransİD.Name = "txtbransİD";
            txtbransİD.Size = new Size(202, 39);
            txtbransİD.TabIndex = 22;
            txtbransİD.Text = " ";
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Silver;
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(262, 122);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(79, 43);
            btnsil.TabIndex = 21;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 73);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 17;
            label2.Text = "BRANŞ AD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 16;
            label1.Text = "BRANŞ İD:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(361, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(429, 188);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Frmbransislem
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(802, 241);
            Controls.Add(dataGridView1);
            Controls.Add(btnekle);
            Controls.Add(btnguncelle);
            Controls.Add(txtbransad);
            Controls.Add(txtbransİD);
            Controls.Add(btnsil);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Frmbransislem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmbransislem";
            Load += Frmbransislem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnekle;
        private Button btnguncelle;
        private TextBox txtbransad;
        private TextBox txtbransİD;
        private Button btnsil;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}