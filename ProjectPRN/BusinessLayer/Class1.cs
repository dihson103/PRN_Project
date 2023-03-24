using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            int a = (int)date.DayOfWeek;
            Console.WriteLine(a);
        }
    }
}
