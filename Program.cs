using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsApp_Ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string employeename;
            string employeegender;
            double employeesalary;
            DateTime doj;
            Console.WriteLine("Enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee name");
            employeename = (Console.ReadLine());
            Console.WriteLine("Enter employee Gender");
            employeegender = (Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            employeesalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter DOJ (D/M/Y)");
            doj = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("\nID\tEmployeeName\tEmployeegender\tEmployeeSalary\tDOJ");
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine($"{id}\t{employeename}\t{employeegender}\t{employeesalary}\t{doj}");
            if (employeesalary > 90000)
            {
                Console.WriteLine("you have to pay 30%tax");
            }
            else
            {
                Console.WriteLine("you have to pay 15% tax");
            }
            Console.ReadKey();


        }
    }
}
