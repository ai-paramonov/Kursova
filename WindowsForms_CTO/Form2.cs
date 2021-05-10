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
    public partial class Form2 : Form
    {
        private double count;
        List<Service> array;
        
        public string MyName
        {
            get
            {
                string str = textBox1.Text;
                return str;
            }
        }

        public string Car
        {
            get
            {
                string w = textBox2.Text;
                return w;
            }
        }

        public string Date
        {
            get
            {
                DateTime date1 = DateTime.Now;
                string d = date1.ToString("d");
                return d;
            }
        }

        public double Cost
        {
            get {return count;}     
            set
            {
                if (value == null)
                {
                    value = 0.0;
                }
                else
                {
                    count = value;
                }
            }
        }

        public Form2(List<Service> arra)
        {
            InitializeComponent();
            this.array = arra;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;
            textBox3.Text = string.Format("{0:0.00}", Cost);
            for (int i = 0; i < array.Count; i++)
            {
                checkedListBox1.Items.Add(array[i].ToString());
            }    
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = DialogResult;
            if (result != DialogResult.Cancel && ((textBox1.Text.Length < 1) || (textBox2.Text.Length < 1) || (Cost == 0.0)))
            {
                string message = "Заповніть усі поля коректно!";
                string caption = "Помилка при створенні";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                var dr = MessageBox.Show(message, caption, buttons);
                e.Cancel = dr == DialogResult.OK;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string s = "Вибрані послуги:\n" ;
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                double d = 0.0;
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        d += Convert.ToDouble(array[i].price);
                       // s = s + checkedListBox1.Items[i].ToString() + ", сума - " + d + "$\n";
                    }
                }
                Cost = d;
                //MessageBox.Show(s);
            }
            else
            {
                Cost = 0.0;
            }
            textBox3.Text = string.Format("{0:0.00}", Cost);
        }
    }
}
