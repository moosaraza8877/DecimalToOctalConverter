using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] a = new int[50];
            Console.Write("Enter Decimal Number's: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Decimal Number is: {0}", b);
            for (i = 0; ; i++)
            {
                a[i] = b % 8;
                b = b / 8;
                if (b == 0) break;
            }
            Console.Write("It's Octal Equivalent Number is: ");
            for (j = i; j >= 0; j--)
            {
                Console.Write(a[j]);
            }
            Console.WriteLine();
            Console.WriteLine("  ********** THE END **********  ");
        }
    }
}
