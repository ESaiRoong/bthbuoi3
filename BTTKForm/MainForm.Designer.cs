namespace BTTKForm
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            bài1ToolStripMenuItem = new ToolStripMenuItem();
            bài2ToolStripMenuItem = new ToolStripMenuItem();
            bài3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { bài1ToolStripMenuItem, bài2ToolStripMenuItem, bài3ToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(61, 20);
            toolStripMenuItem1.Text = "2212360";
            // 
            // bài1ToolStripMenuItem
            // 
            bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            bài1ToolStripMenuItem.Size = new Size(180, 22);
            bài1ToolStripMenuItem.Text = "Bài 1";
            bài1ToolStripMenuItem.Click += bài1ToolStripMenuItem_Click;
            // 
            // bài2ToolStripMenuItem
            // 
            bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            bài2ToolStripMenuItem.Size = new Size(180, 22);
            bài2ToolStripMenuItem.Text = "Bài 2";
            bài2ToolStripMenuItem.Click += bài2ToolStripMenuItem_Click;
            // 
            // bài3ToolStripMenuItem
            // 
            bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            bài3ToolStripMenuItem.Size = new Size(180, 22);
            bài3ToolStripMenuItem.Text = "Bài 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Chương trình chính";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem bài1ToolStripMenuItem;
        private ToolStripMenuItem bài2ToolStripMenuItem;
        private ToolStripMenuItem bài3ToolStripMenuItem;
    }
}
