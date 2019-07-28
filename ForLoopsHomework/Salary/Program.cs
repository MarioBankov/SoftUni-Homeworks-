using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {

            int tabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < tabs; i++)
            {
                string check = Console.ReadLine();
                if (check=="Facebook")
                {
                    salary -= 150;
                }
                else if (check == "Instagram")
                {
                    salary -=100;
                }
                else if (check=="Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0 ) 
                {
                    result = "You have lost your salary.";
                }
            }
            if (salary>0)
            {
                Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine(result); 
            }
        
        }
    }
}
