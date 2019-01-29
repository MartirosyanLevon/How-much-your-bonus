using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMuchIsYourBonus
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your experience of work");
            byte years = Convert.ToByte(Console.ReadLine());
            int salary = 150000;
            if ((years > 0) && (years < 5))
            {
                Console.WriteLine(" Your salary is {0} \n Your bonus is = {1}\n All = {2}", salary, salary * 10 / 100, salary + (salary * 0.10));
            }
            else if ((years >= 5) && (years < 10))
            {
                Console.WriteLine(" Your salary is {0} \n Your bonus is = {1}\n All = {2}", salary, salary * 15 / 100, salary + (salary * 0.15));
            }
            else if ((years >= 10) && (years < 15))
            {
                Console.WriteLine(" Your salary is {0} \n Your bonus is = {1}\n All = {2}", salary, salary * 25 / 100, salary + (salary * 0.25));
            }
            else if ((years >= 15) && (years < 20))
            {
                Console.WriteLine(" Your salary is {0} \n Your bonus is = {1}\n All = {2}", salary, salary * 35 / 100, salary + (salary * 0.35));
            }
            else if ((years >= 20) && (years < 25))
            {
                Console.WriteLine(" Your salary is {0} \n Your bonus is = {1}\n All = {2}", salary, salary * 45 / 100, salary + (salary * 0.45));

            }
            else if (years >= 25)
            {
                Console.WriteLine(" Your salary is {0} \n Your bonus is = {1}\n All = {2}", salary, salary * 50 / 100, salary + (salary * 0.5));

            }

            Console.ReadKey();
        }
    }
}
