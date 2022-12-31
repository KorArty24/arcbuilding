using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Arc
{
    internal static class Trigonometry
    {
        public static double ToRadians(this double val)
        {
            return (Math.PI / 180) * val;

        }

        public static double FromRadToDeg(this double radians) 
        {
            return radians*(180/Math.PI);
        }
    }
}
