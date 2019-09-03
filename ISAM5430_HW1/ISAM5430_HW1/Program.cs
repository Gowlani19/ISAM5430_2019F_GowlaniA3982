using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAM5430_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            string input1 = Console.ReadLine();
            int a = int.Parse(input1);
            Console.WriteLine("Enter number 2:");
            string input2 = Console.ReadLine();
            int b = int.Parse(input2);
            Console.WriteLine("Enter the operator +,-,*,/ :");
            string opt=Console.ReadLine();
            if(opt=="+")
            {
                int sum;
                sum = a+b;
                Console.WriteLine(sum);
            }
             if(opt=="-")
            {
                int subtract;
                subtract = a - b;
                Console.WriteLine(subtract);
            }
             if(opt=="*")
            {
                int multi;
                multi = a * b;
                Console.WriteLine(multi);

            }
            if(opt=="/")
             {
                int div;
                div = a / b;
                Console.WriteLine(div);

            }


        }
    }
}
