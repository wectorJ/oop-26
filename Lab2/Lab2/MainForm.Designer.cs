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
            border_btn = new ToolStripDropDownButton();
            solidToolStripMenuItem = new ToolStripMenuItem();
            dotedToolStripMenuItem = new ToolStripMenuItem();
            dashDotedToolStripMenuItem = new ToolStripMenuItem();
            color_btn = new ToolStripDropDownButton();
            redToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            clear_btn = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { file_btn, obj_btn, border_btn, color_btn, clear_btn });
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
            dotToolStripMenuItem.Size = new Size(158, 26);
            dotToolStripMenuItem.Text = "Dot";
            dotToolStripMenuItem.Click += objectToolStripMenuItem_Click;
            // 
            // lineToolStripMenuItem
            // 
            lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            lineToolStripMenuItem.Size = new Size(158, 26);
            lineToolStripMenuItem.Text = "Line";
            lineToolStripMenuItem.Click += objectToolStripMenuItem_Click;
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(158, 26);
            rectangleToolStripMenuItem.Text = "Rectangle";
            rectangleToolStripMenuItem.Click += objectToolStripMenuItem_Click;
            // 
            // ellipseToolStripMenuItem
            // 
            ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            ellipseToolStripMenuItem.Size = new Size(158, 26);
            ellipseToolStripMenuItem.Text = "Ellipse";
            ellipseToolStripMenuItem.Click += objectToolStripMenuItem_Click;
            // 
            // border_btn
            // 
            border_btn.DropDownItems.AddRange(new ToolStripItem[] { solidToolStripMenuItem, dotedToolStripMenuItem, dashDotedToolStripMenuItem });
            border_btn.Name = "border_btn";
            border_btn.Size = new Size(74, 24);
            border_btn.Text = "Borders";
            // 
            // solidToolStripMenuItem
            // 
            solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            solidToolStripMenuItem.Size = new Size(224, 26);
            solidToolStripMenuItem.Text = "Solid";
            solidToolStripMenuItem.Click += borderToolStripMenuItem_Click;
            // 
            // dotedToolStripMenuItem
            // 
            dotedToolStripMenuItem.Name = "dotedToolStripMenuItem";
            dotedToolStripMenuItem.Size = new Size(224, 26);
            dotedToolStripMenuItem.Text = "Doted";
            dotedToolStripMenuItem.Click += borderToolStripMenuItem_Click;
            // 
            // dashDotedToolStripMenuItem
            // 
            dashDotedToolStripMenuItem.Name = "dashDotedToolStripMenuItem";
            dashDotedToolStripMenuItem.Size = new Size(224, 26);
            dashDotedToolStripMenuItem.Text = "Dash Doted";
            dashDotedToolStripMenuItem.Click += borderToolStripMenuItem_Click;
            // 
            // color_btn
            // 
            color_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            color_btn.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, blackToolStripMenuItem, greenToolStripMenuItem, blueToolStripMenuItem });
            color_btn.Image = (Image)resources.GetObject("color_btn.Image");
            color_btn.ImageTransparentColor = Color.Magenta;
            color_btn.Name = "color_btn";
            color_btn.Size = new Size(59, 24);
            color_btn.Text = "Color";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(131, 26);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(131, 26);
            blackToolStripMenuItem.Text = "Black";
            blackToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(131, 26);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(131, 26);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // clear_btn
            // 
            clear_btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            clear_btn.Image = (Image)resources.GetObject("clear_btn.Image");
            clear_btn.ImageTransparentColor = Color.Magenta;
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(47, 24);
            clear_btn.Text = "Clear";
            clear_btn.Click += clear_btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "MainForm";
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
        private ToolStripDropDownButton border_btn;
        private ToolStripMenuItem solidToolStripMenuItem;
        private ToolStripDropDownButton color_btn;
        private ToolStripMenuItem dotedToolStripMenuItem;
        private ToolStripMenuItem dashDotedToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripButton clear_btn;
    }
}
