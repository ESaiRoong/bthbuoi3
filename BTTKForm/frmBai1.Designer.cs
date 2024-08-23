namespace BTTKForm
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            groupBox1 = new GroupBox();
            rdWhite = new RadioButton();
            rdRed = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            pictureBox1 = new PictureBox();
            btTinhTien = new Button();
            lbTongTien = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdWhite);
            groupBox1.Controls.Add(rdRed);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(403, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn màu xe";
            // 
            // rdWhite
            // 
            rdWhite.AutoSize = true;
            rdWhite.Location = new Point(21, 72);
            rdWhite.Name = "rdWhite";
            rdWhite.Size = new Size(54, 19);
            rdWhite.TabIndex = 0;
            rdWhite.TabStop = true;
            rdWhite.Text = "Trắng";
            rdWhite.UseVisualStyleBackColor = true;
            rdWhite.CheckedChanged += rdWhite_CheckedChanged;
            // 
            // rdRed
            // 
            rdRed.AutoSize = true;
            rdRed.Location = new Point(21, 47);
            rdRed.Name = "rdRed";
            rdRed.Size = new Size(40, 19);
            rdRed.TabIndex = 0;
            rdRed.TabStop = true;
            rdRed.Text = "Đỏ";
            rdRed.UseVisualStyleBackColor = true;
            rdRed.CheckedChanged += rdRed_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Xanh";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 244);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 280);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(188, 385);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 1;
            label3.Text = "Tổng tiền";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(475, 236);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(100, 23);
            txtDonGia.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(475, 277);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(100, 23);
            txtSoLuong.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 159);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btTinhTien
            // 
            btTinhTien.Location = new Point(475, 313);
            btTinhTien.Name = "btTinhTien";
            btTinhTien.Size = new Size(75, 23);
            btTinhTien.TabIndex = 4;
            btTinhTien.Text = "Tính tiền";
            btTinhTien.UseVisualStyleBackColor = true;
            btTinhTien.Click += btTinhTien_Click;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(296, 385);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(0, 15);
            lbTongTien.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(581, 244);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 5;
            label4.Text = "$";
            // 
            // frmBai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 462);
            Controls.Add(label4);
            Controls.Add(btTinhTien);
            Controls.Add(pictureBox1);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(lbTongTien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmBai1";
            Text = "frmBai1";
            Load += frmBai1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdWhite;
        private RadioButton rdRed;
        private RadioButton radioButton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private PictureBox pictureBox1;
        private Button btTinhTien;
        private Label lbTongTien;
        private Label label4;
    }
}