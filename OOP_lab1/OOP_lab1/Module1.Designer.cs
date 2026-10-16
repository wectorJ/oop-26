namespace OOP_lab1
{
    partial class Module1
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
            list_input = new ListBox();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.DialogResult = DialogResult.OK;
            btn_ok.Location = new Point(12, 134);
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
            btn_cnl.Location = new Point(257, 134);
            btn_cnl.Name = "btn_cnl";
            btn_cnl.Size = new Size(94, 29);
            btn_cnl.TabIndex = 2;
            btn_cnl.Text = "Cancel";
            btn_cnl.UseVisualStyleBackColor = true;
            btn_cnl.Click += btn_cnl_Click;
            // 
            // list_input
            // 
            list_input.FormattingEnabled = true;
            list_input.Items.AddRange(new object[] { "51", "52", "53", "54", "55" });
            list_input.Location = new Point(12, 12);
            list_input.Name = "list_input";
            list_input.Size = new Size(223, 104);
            list_input.TabIndex = 3;
            // 
            // Module1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 176);
            Controls.Add(list_input);
            Controls.Add(btn_cnl);
            Controls.Add(btn_ok);
            Name = "Module1";
            Text = "Module1";
            Load += Module1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_ok;
        private Button btn_cnl;
        private ListBox list_input;
    }
}