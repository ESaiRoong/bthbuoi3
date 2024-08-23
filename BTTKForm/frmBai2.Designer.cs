namespace BTTKForm
{
    partial class frmBai2
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            btbChonHang = new Button();
            button3 = new Button();
            lbTongTien = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Chuột", "Bàn phím", "Máy in", "USB Kingmax" });
            listBox1.Location = new Point(75, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(211, 199);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(487, 82);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(211, 199);
            listBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(603, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 47);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(399, 376);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 1;
            label3.Text = "Tổng thanh toán";
            // 
            // button1
            // 
            button1.Location = new Point(580, 310);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btbChonHang
            // 
            btbChonHang.Location = new Point(292, 173);
            btbChonHang.Name = "btbChonHang";
            btbChonHang.Size = new Size(85, 23);
            btbChonHang.TabIndex = 2;
            btbChonHang.Text = "Chọn hàng >";
            btbChonHang.UseVisualStyleBackColor = true;
            btbChonHang.Click += btbChonHang_Click;
            // 
            // button3
            // 
            button3.Location = new Point(399, 173);
            button3.Name = "button3";
            button3.Size = new Size(82, 23);
            button3.TabIndex = 2;
            button3.Text = "< Bỏ hàng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI", 14F);
            lbTongTien.ForeColor = SystemColors.Highlight;
            lbTongTien.Location = new Point(566, 376);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(0, 25);
            lbTongTien.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 409);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(383, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(417, 409);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // frmBai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btbChonHang);
            Controls.Add(button1);
            Controls.Add(lbTongTien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmBai2";
            Text = "frmBai2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btbChonHang;
        private Button button3;
        private Label lbTongTien;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}