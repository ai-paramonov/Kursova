using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms_CTO
{
    public class Service
    {
        public string title { get; set; }
        public double price { get; set; }
        public bool done { get; set; }

        public Service(string title = "Послуга", double price = 500.0, bool done = true)
        {
            this.title = title;
            this.price = price;
            this.done = done;
        }

        public override string ToString()
        {
            return title + " - " + price + "$";
        }

        public void SortByPrice(List<Service> sort)               //Сортування списку послуг методом бульбашки
        {
            bool wasSwapped = true;
            int z = 0;
            while (wasSwapped)
            {
                wasSwapped = false;
                for (int i = 0; i < sort.Count - 1 - z; i++)
                {
                    if (sort[i].price > sort[i + 1].price)
                    {
                        Service a = new Service();
                        a = sort[i];
                        sort[i] = sort[i + 1];
                        sort[i + 1] = a;
                        wasSwapped = true;
                    }
                }
                z++;
            }
        }
    }
}