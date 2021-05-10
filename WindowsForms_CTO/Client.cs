using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_CTO
{
    public class Client : ICloneable, IComparable<Client>
    {
        public string name;
        public string auto;
        public double cost;
        public bool ready;
        public string dateString;
        public DateTime date;

        public Client(string name = "Артур", string auto = "Porshe GT3", string dateString = "13.01.2021",
            double cost = 1000.00, bool ready = false)
        {
            this.name = name;
            this.auto = auto;
            this.dateString = dateString;
            this.cost = cost;
            this.ready = ready;
            try
            {
                date = DateTime.Parse(dateString);
            }
            catch (FormatException)
            {
                date = DateTime.Parse("01.01.2021");
            }
        }

        public void Print()
        {
            Console.WriteLine("Клiєнт {0} ремонтує авто {1} з {2} i винен {3:0.0} грн.", name, auto,
                date.ToString("d"), cost);
        }

        public object Clone()
        {
            Client tmp = (Client)this.MemberwiseClone();
            return tmp;
        }


        public int CompareTo(Client obj)
        {
            if (this.cost > obj.cost)
                return 1;
            if (this.cost < obj.cost)
                return -1;
            else
                return 0;
        }

        public static bool operator ==(Client obj1, Client obj2)
        {
            if (obj1.name == obj2.name && obj1.auto == obj2.auto) return true;
            return false;
        }

        public static bool operator !=(Client obj1, Client obj2)
        {
            if ((obj1.name != obj2.name) || (obj1.auto != obj2.auto)) return true;
            return false;
        }
    }
}
