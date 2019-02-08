using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public static class Trianglesolver
    {

     

        public static  string analyze(int side1, int side2, int side3)
        {
            string result = string.Empty;

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    result = "equilateral triangle";

                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    result = "isosceles triangle";

                }

                else if (side1!=side2 && side2!=side3)
                {
                    result = "scalene triangle";
                }
            }

            else
            {
                result = "not a triangle";
            }
            return result;



        }
    

    }
}
