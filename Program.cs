using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat instan class / object
            Time objTime = new Time(2610,11,19,23,59,59);

            // mengambil nilai dengan property
            Console.WriteLine("Year : {0}", objTime.Year.ToString());
            Console.WriteLine("Month : {0}", objTime.Month.ToString());
            Console.WriteLine("Date : {0}", objTime.Date.ToString());
            Console.WriteLine("Hour : {0}", objTime.Hour.ToString());
            Console.WriteLine("Minute : {0}", objTime.Minute.ToString());
            Console.WriteLine("Second : {0}", objTime.Second.ToString());

            Console.ReadKey();
        }
    }
}
