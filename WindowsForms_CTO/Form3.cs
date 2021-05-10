using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_CTO
{
    public partial class Form3 : Form
    {
        List<Service> array;

        public Form3(List<Service> arra)
        {
            InitializeComponent();
            this.array = arra;
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 18);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 18);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.PaleGoldenrod;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            this.dataGridView1.GridColor = Color.Black;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.RowHeadersVisible = false;
        
            for (int i = 0; i < array.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = array[i].title;
                dataGridView1.Rows[i].Cells[1].Value = array[i].price;
            }   
        }
    }
}
