using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Comparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Enter X1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 :");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            CalculateLength clength = new CalculateLength(x1, x2, y1, y2);
            clength.calculate();
            double line1= clength.calculate();
            CalculateLength clengths= new CalculateLength(3,4,5,6);
            double line2= clengths.calculate();
            clengths.Compare(line1,line2);
            clengths.glLine(line1,line2);
        }
    }
}
