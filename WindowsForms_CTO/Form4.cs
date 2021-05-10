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
    public partial class Form4 : Form
    {
        List<Client> array;

        public Form4(List<Client> arr)
        {
            InitializeComponent();
            this.array = arr;

           /* for (int i = 0; i < arr.Count; i++)
            {
                Client cl = new Client();
                cl = (Client)arr[i].Clone();
            }*/
        }


        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.PaleGoldenrod;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            this.dataGridView1.GridColor = Color.Black;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[2].ValueType = typeof(DateTime);
            //dataGridView1.Columns[2].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            for (int i = 0; i < array.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = array[i].name;
                dataGridView1.Rows[i].Cells[1].Value = array[i].auto;
                dataGridView1.Rows[i].Cells[2].Value = array[i].date;
                dataGridView1.Rows[i].Cells[3].Value = array[i].cost;
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[4];
                cell.ReadOnly = false;
                cell.Items.AddRange(new string[] { "Готовий", "В ремонті"});
                if (array[i].ready == true)
                {
                    cell.Value = cell.Items[0];
                    //cell.ReadOnly = true;
                }
                else
                {
                    cell.Value = cell.Items[1];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Count; i++)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[4];
                if (cell.Value.ToString() == "Готовий")
                {
                    array[i].ready = true;
                }
                if (cell.Value.ToString() == "В ремонті")
                {
                    array[i].ready = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
