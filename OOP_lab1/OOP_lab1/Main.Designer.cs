namespace OOP_lab1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStrip1 = new ToolStrip();
            module1 = new ToolStripButton();
            module2 = new ToolStripButton();
            label1 = new Label();
            btn_clr = new Button();
            label2 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { module1, module2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(485, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // module1
            // 
            module1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            module1.Image = (Image)resources.GetObject("module1.Image");
            module1.ImageTransparentColor = Color.Magenta;
            module1.Name = "module1";
            module1.Size = new Size(72, 24);
            module1.Text = "Module1";
            module1.Click += module1_Click;
            // 
            // module2
            // 
            module2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            module2.Image = (Image)resources.GetObject("module2.Image");
            module2.ImageTransparentColor = Color.Magenta;
            module2.Name = "module2";
            module2.Size = new Size(72, 24);
            module2.Text = "Module2";
            module2.Click += module2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "Module1 result";
            // 
            // btn_clr
            // 
            btn_clr.Location = new Point(12, 127);
            btn_clr.Name = "btn_clr";
            btn_clr.Size = new Size(94, 29);
            btn_clr.TabIndex = 2;
            btn_clr.Text = "Clear";
            btn_clr.UseVisualStyleBackColor = true;
            btn_clr.Click += btn_clr_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Module2 result";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 170);
            Controls.Add(label2);
            Controls.Add(btn_clr);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "Main";
            Text = "Var15";
            Load += Main_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton module1;
        private ToolStripButton module2;
        private Label label1;
        private Button btn_clr;
        private Label label2;
    }
}
