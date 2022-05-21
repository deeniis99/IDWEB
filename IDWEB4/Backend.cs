using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IDWEB4
{
    class Backend
    {
        public static string[] SolveQuadratic(int a, int b, int c)

        {
            double sqrtpart = b * b - 4 * a * c;
            double x, x1, x2, img;
            string[] results = new string[2];
            if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                img = System.Math.Sqrt(sqrtpart) / (2 * a);
                Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);
                Complex ComplexC = new Complex(x, img);
                results[0] = ComplexC.Real + "+" + ComplexC.Imaginary + "i";
                results[1] = ComplexC.Real + "-" + ComplexC.Imaginary + "i";
            }
            return results;
        }
    }
}
