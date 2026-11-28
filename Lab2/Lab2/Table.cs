using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Table : Form
    {
        private readonly Editor? _editor;

        private Shape? SelectedShape => dataGridView1.SelectedRows.Count == 1
            ? dataGridView1.SelectedRows[0].Tag as Shape
            : null;

        public Table()
        {
            InitializeComponent();
        }

        public Table(Editor editor) : this()
        {
            _editor = editor;
            Reload(editor.Shapes);

            EventHandler refreshRows = (_, _) => Reload(editor.Shapes);
            editor.ShapesChanged += refreshRows;
            Disposed += (_, _) => //delete?
            {
                editor.ShapesChanged -= refreshRows;
                editor.SelectedShape = null;
            };
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing && !e.Cancel) // error handling
            {
                e.Cancel = true;
                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
                Hide();
            }
        }

        private void Reload(IEnumerable<Shape> shapes)
        {
            Shape? selectedShape = SelectedShape;
            dataGridView1.SelectionChanged -= ShapesGrid_SelectionChanged;

            try
            {
                dataGridView1.Rows.Clear();
                DataGridViewRow? selectedRow = null;

                foreach (Shape shape in shapes)
                {
                    int index = dataGridView1.Rows.Add(
                        shape.GetType().Name,
                        $"({shape.Start.X}, {shape.Start.Y})",
                        $"({shape.End.X}, {shape.End.Y})");

                    DataGridViewRow row = dataGridView1.Rows[index];
                    row.Tag = shape;
                    if (ReferenceEquals(shape, selectedShape)) selectedRow = row;
                }

                dataGridView1.CurrentCell = selectedRow?.Cells[0];
                dataGridView1.ClearSelection();
                if (selectedRow is not null) selectedRow.Selected = true;
            }
            finally
            {
                dataGridView1.SelectionChanged += ShapesGrid_SelectionChanged;
            }

            UpdateSelection();
        }

        private void ShapesGrid_SelectionChanged(object? sender, EventArgs e) => UpdateSelection();

        private void UpdateSelection()
        {
            Shape? shape = SelectedShape;
            deleteSelectedButton.Enabled = shape is not null;
            if (_editor is not null) _editor.SelectedShape = shape;
        }

        private void DeleteSelectedButton_Click(object? sender, EventArgs e)
        {
            if (SelectedShape is Shape shape) _editor?.RemoveShape(shape);
        }
    }
}
