namespace OOP_lab1
{
    partial class Module2
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
            btn_ok = new Button();
            btn_cnl = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.DialogResult = DialogResult.OK;
            btn_ok.Location = new Point(12, 70);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(94, 29);
            btn_ok.TabIndex = 1;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cnl
            // 
            btn_cnl.DialogResult = DialogResult.Cancel;
            btn_cnl.Location = new Point(153, 70);
            btn_cnl.Name = "btn_cnl";
            btn_cnl.Size = new Size(94, 29);
            btn_cnl.TabIndex = 2;
            btn_cnl.Text = "Cancel";
            btn_cnl.UseVisualStyleBackColor = true;
            btn_cnl.Click += btn_cnl_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.MaxLength = 32;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "enter text here (32 symb max)";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 3;
            // 
            // Module2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 110);
            Controls.Add(textBox1);
            Controls.Add(btn_cnl);
            Controls.Add(btn_ok);
            Name = "Module2";
            Text = "Module2";
            Load += Module2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_ok;
        private Button btn_cnl;
        private TextBox textBox1;
    }
}