using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_hidding_Constructor_whit_Get_proparty
{
    class data
    {
        private float num;

        public data(float num)
        {
            this.num = num;
        }
        public float number
        {
            get
            {
                return this.num;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            data obj = new data(20.20f);
            float n = obj.number;
            Console.WriteLine(n);
           /* Console.WriteLine(obj.number);*/
            Console.ReadLine();

        }
    }
}
