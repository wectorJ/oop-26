namespace Lab2
{
    partial class Table
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
            dataGridView1 = new DataGridView();
            shapeTypeColumn = new DataGridViewTextBoxColumn();
            startColumn = new DataGridViewTextBoxColumn();
            endColumn = new DataGridViewTextBoxColumn();
            deleteSelectedButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { shapeTypeColumn, startColumn, endColumn });
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 376);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += ShapesGrid_SelectionChanged;
            // 
            // shapeTypeColumn
            // 
            shapeTypeColumn.HeaderText = "Type";
            shapeTypeColumn.MinimumWidth = 6;
            shapeTypeColumn.Name = "shapeTypeColumn";
            shapeTypeColumn.ReadOnly = true;
            shapeTypeColumn.Width = 125;
            // 
            // startColumn
            // 
            startColumn.HeaderText = "Start";
            startColumn.MinimumWidth = 6;
            startColumn.Name = "startColumn";
            startColumn.ReadOnly = true;
            startColumn.Width = 125;
            // 
            // endColumn
            // 
            endColumn.HeaderText = "End";
            endColumn.MinimumWidth = 6;
            endColumn.Name = "endColumn";
            endColumn.ReadOnly = true;
            endColumn.Width = 125;
            // deleteSelectedButton
            deleteSelectedButton.Enabled = false;
            deleteSelectedButton.Location = new Point(12, 12);
            deleteSelectedButton.Name = "deleteSelectedButton";
            deleteSelectedButton.Size = new Size(140, 32);
            deleteSelectedButton.TabIndex = 1;
            deleteSelectedButton.Text = "Delete selected";
            deleteSelectedButton.UseVisualStyleBackColor = true;
            deleteSelectedButton.Click += DeleteSelectedButton_Click;
            // 
            // Table
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(deleteSelectedButton);
            Name = "Table";
            Text = "Table";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn shapeTypeColumn;
        private DataGridViewTextBoxColumn startColumn;
        private DataGridViewTextBoxColumn endColumn;
        private Button deleteSelectedButton;
    }
}
