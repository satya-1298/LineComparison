using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    public class CalculateLength
    {
        int x1, x2, y1, y2;
        public CalculateLength(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;

        }
        public double calculate()
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("the length is :" + length);
            return length;
        }
        public void Compare(double line1,double line2)
        {
            
            if (line1.Equals(line2))
            {
                Console.WriteLine("This two lines are equal");
            }
            else 
            {
                Console.WriteLine("two lines are not equal");
            }

        }
        public void glLine(double line1,double line2)
        {
            if (line1<line2 )
            {
                Console.WriteLine("line2 is greaterthan line1 ");
            }
            else
            {
                Console.WriteLine("line2 is lessthan line1");
            }
        }
    }
}

