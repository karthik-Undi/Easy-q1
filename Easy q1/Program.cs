using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_q1
{
    class Program
    {
        static void Main(string[] args)
        {

            var Employees = new List<string>();
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
            for (; ; )
            {
                String s = Console.ReadLine();
                if (s == "") break;
                else Employees.Add(s);
            }


            Console.WriteLine("Employee list sorted by promotion eligilibility\n");
            for (int i = 0; i < Employees.Count; i++)
                Console.WriteLine(Employees[i]);
            Console.ReadKey();

        }
    }
}
