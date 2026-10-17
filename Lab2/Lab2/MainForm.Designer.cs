namespace Lab2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            file_btn = new ToolStripButton();
            obj_btn = new ToolStripDropDownButton();
            dotToolStripMenuItem = new ToolStripMenuItem();
            lineToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            ellipseToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { file_btn, obj_btn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // file_btn
            // 
            file_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            file_btn.Image = (Image)resources.GetObject("file_btn.Image");
            file_btn.ImageTransparentColor = Color.Magenta;
            file_btn.Name = "file_btn";
            file_btn.Size = new Size(36, 24);
            file_btn.Text = "File";
            // 
            // obj_btn
            // 
            obj_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            obj_btn.DropDownItems.AddRange(new ToolStripItem[] { dotToolStripMenuItem, lineToolStripMenuItem, rectangleToolStripMenuItem, ellipseToolStripMenuItem });
            obj_btn.Image = (Image)resources.GetObject("obj_btn.Image");
            obj_btn.ImageTransparentColor = Color.Magenta;
            obj_btn.Name = "obj_btn";
            obj_btn.Size = new Size(73, 24);
            obj_btn.Text = "Objects";
            // 
            // dotToolStripMenuItem
            // 
            dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            dotToolStripMenuItem.Size = new Size(224, 26);
            dotToolStripMenuItem.Text = "Dot";
            // 
            // lineToolStripMenuItem
            // 
            lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            lineToolStripMenuItem.Size = new Size(224, 26);
            lineToolStripMenuItem.Text = "Line";
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(224, 26);
            rectangleToolStripMenuItem.Text = "Rectangle";
            // 
            // ellipseToolStripMenuItem
            // 
            ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            ellipseToolStripMenuItem.Size = new Size(224, 26);
            ellipseToolStripMenuItem.Text = "Ellipse";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "Main";
            Text = "Lab2";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton file_btn;
        private ToolStripDropDownButton obj_btn;
        private ToolStripMenuItem dotToolStripMenuItem;
        private ToolStripMenuItem lineToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem ellipseToolStripMenuItem;
    }
}
