using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0, b = 0;
            Console.WriteLine("Выберите одну из операций");
            Console.WriteLine("- ввести А");
            Console.WriteLine("- ввести В");
            Console.WriteLine("- выполнить операцию “+”");
            Console.WriteLine("- выполнить операцию “-”");
            Console.WriteLine("- выполнить операцию “*”");
            Console.WriteLine("- выполнить операцию “/”");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n) 
            {
                case 1:
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine(a + b);
                    break;
                case 4:
                    Console.WriteLine(a - b);
                    break;
                case 5:
                   
                    break;
                case 6:
                   
                    break;
            }
        }
    }
}
