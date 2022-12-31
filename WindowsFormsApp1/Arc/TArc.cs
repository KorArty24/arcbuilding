using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeklaGeom =Tekla.Structures.Geometry3d;
using Tekla.Structures.Internal;
using System.Drawing;
using Tekla.Structures.Geometry3d;
using Point = Tekla.Structures.Geometry3d.Point;
using WindowsFormsApp1.Arc;

namespace WindowsFormsApp1.TArc
{
    internal static class TArc
    {
        public static void BuildArc(int height, int halfLength, int span)
        {
            double radius = 0.5*height + Math.Pow(span, 2)/(8*height);
            (double x, double y) center = (span * 0.5, height - radius);
            var centerpoint = new Point(3.5, center.y);
            var startpoint = new Point(0, 0);
            var tangentpoint = new Point(span / 2, height);
            
            
            void DrawArc()
            {
               // var newarc = new Arc(centerpoint, startpoint, tangentpoint);
               // Central angle of an arc
               var angle = Trigonometry.FromRadToDeg(halfLength*2/ radius);
               int stepsize = (int) angle / 6;
               List<Point> points = new List<Point>();
                if (angle > Trigonometry.FromRadToDeg(Math.PI))
                {
                    int startangle = (int) (Math.Abs((Trigonometry.FromRadToDeg(Math.PI) - angle)/2) +
                        Trigonometry.FromRadToDeg(Math.PI));
                    var endangle =(int) (0 - Math.Abs((Trigonometry.FromRadToDeg(Math.PI) - angle)/2));
                    for (int i= startangle; i<= endangle; i = i - stepsize)
                    {
                        double coordX = radius * Math.Cos(Trigonometry.ToRadians(i));
                        double coordY = radius * Math.Sin(Trigonometry.ToRadians(i));
                        Point point = new Point(coordX, coordY);
                        points.Add(point);
                    }
                }
            }
        }
    }
}
