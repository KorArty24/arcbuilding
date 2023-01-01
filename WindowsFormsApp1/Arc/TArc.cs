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
    internal class TArc
    {
        public void BuildArc()
        {
            ArcDTO dto = new ArcDTO();
            double height =dto.height;
            double span = dto.span;
            const int numPanels = 6; // temrprary for testing purposes

            double radiusUp = 0.5*height + Math.Pow(span, 2)/(8*height);
            //double radiusUp = height;
            //gets the center of the arc B(a, r) where a is the center, r - radius
            (double x, double y) center = (span * 0.5, height - radiusUp);
            
            var centerpoint = new Point(span/2, center.y);
            //Central angle. Is set to 180 deg (PI)

            const double  centralAngle = 180;
            // Calculates the sector angle (180/6 = 30)
            int stepsize = (int) centralAngle / numPanels;

            DrawUpperArc();

            void DrawUpperArc()
            {
               
               List<Point> pointsUpper = new List<Point>();
                if (centralAngle > Trigonometry.FromRadToDeg(Math.PI))
                {
                    /*Calculates the start angle ( angle > PI). For central angle 192 deg  
                     * |180-192|/2 + 180= 12/2 + 180 = 186 (deg)*/
                    int startAngle = (int) (Math.Abs((Trigonometry.FromRadToDeg(Math.PI) - centralAngle)/2) +
                        Trigonometry.FromRadToDeg(Math.PI));

                    /*Calculates the end angle ( 2PI > angle > 3PI/2). For central angle 192 deg  
                     * 0-|(180-192)/2|= 0-6= -6 = 360-6=356 (deg)*/
                    var endAngle =(int) (0 - Math.Abs((Trigonometry.FromRadToDeg(Math.PI) - centralAngle)/2));
                   
                    for (int i= startAngle; i<= endAngle; i = i - stepsize)
                    {
                        /*Calculates points according to x = r cos(\fi)  y = r cos(\fi) */
                        double coordX = radiusUp * Math.Cos(Trigonometry.ToRadians(i));
                        double coordY = radiusUp * Math.Sin(Trigonometry.ToRadians(i));
                        Point point = new Point(coordX, coordY);
                        pointsUpper.Add(point);
                    }
                }
            }
            void DrawInnerArc (int nChordes, int startangle, int endAngle) 
            {
                //int centralAngleInner = centralAngle +
                int startAngleInner = startangle - stepsize;

            }
        }
    }
}
