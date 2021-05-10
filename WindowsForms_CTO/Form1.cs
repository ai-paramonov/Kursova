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
    public partial class Form1 : Form
    {
        List<Client> arr;
        List<Service> arra;
        Bitmap b;
        Form1 form1;
        Form2 form2;
        Form3 form3;
        Form4 form4;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            arr = new List<Client>();
            arr.Add(new Client());
            arr.Add(new Client("Роман", "Audi R8", "05.01.2021", 705, true));
            arr.Add(new Client("Іван", "BMW M3", "17.04.2021", 310.5));
            arr.Add(new Client("Вова", "Mercedes C200", "18.02.2021", 600, true));
            arr.Add(new Client("Петро", "Aston Martin DB9", "02.05.2021", 845));
            arr.Add(new Client("Олесь", "Daewoo Matiz", "12.04.2021", 900));
            arr.Add(new Client("Дмитро", "Dodge Caravan", "17.03.2021", 10, true));
            arr.Add(new Client("Василь", "Ford Focus", "07.02.2021", 1500, true));
            arr.Add(new Client("Влад", "VW Golf", "20.04.2021", 505));
            arr.Add(new Client("Сергій", "Kia Rio", "22.03.2021", 5, true));

            arra = new List<Service>();
            arra.Add(new Service("Шиномонтаж", 10.0));
            arra.Add(new Service("Балансування коліс", 10.5));
            arra.Add(new Service("Заміна фільтра", 5.0));
            arra.Add(new Service("Ремонт КПП", 500.0));
            arra.Add(new Service("Ремонт кондиціонера", 100.0));
            arra.Add(new Service("Заміна мастила", 15.0));
            arra.Add(new Service("Встановлення сигналізації", 150.0));
            arra.Add(new Service("Діагностика двигуна", 80.0));
            arra.Add(new Service("Загальна діагностика авто", 70.0));
            arra.Add(new Service("Тонування вікон", 230.0));
            arra.Add(new Service("Чистка інжектора", 45.0));
            arra.Add(new Service("Покраска", 300.0));

            b = new Bitmap("menu.png");

            form1 = this;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(b, 120, 10, 250, 150);
            this.BackColor = Color.PaleGoldenrod;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            form4 = new Form4(this.arr);
            if (form4.ShowDialog() == DialogResult.OK)
            {
                form4.Close();
            }


            /*string message = "You did not enter a server name. Cancel this operation?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);  // Displays the MessageBox.
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this.arra);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                    Client p = new Client(form2.MyName, form2.Car, form2.Date, form2.Cost);                        
                    /*for (int i = 0; i < arr.Count; i++)
                    {
                        if (p == arr[i])
                        {
                            arr.Remove(arr[i]);
                        }
                    }*/
                    arr.Add(p);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            form3 = new Form3(this.arra);
            form3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string message = "Ви впевнені, що хочете вийти?";
            string caption = "Вихід";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons); 
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();  //Application.Exit();
            }
                
        }

    }
}
