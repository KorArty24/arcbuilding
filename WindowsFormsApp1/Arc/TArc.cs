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
using Tekla.Structures.Model;

namespace WindowsFormsApp1.TArc
{
    internal class TArc
    {
        public void BuildArc(ArcDTO dto)
        {
            double height =dto.height;
            double span = dto.span;
            const int numPanels = 6; // temrprary for testing purposes
            double radiusY = height;
            double radiusX = dto.span/2;
            //gets the center of the arc B(a, r) where a is the center, r - radius
            (double x, double y) center = (span * 0.5, height - radiusY);
            var centerpoint = new Point(center.x, center.y);
            //Central angle. Is set to 180 deg (PI)
            const double  centralAngle = 180;
            // Calculates the sector angle (180/6 = 30)
            int stepsize = (int) centralAngle / numPanels;
            int startAngle = 180; //Deg
            var innerPoints = new List<Point>();
            var pointsUpper = new List<Point>();
            DrawUpperArc();
            DrawInnerArc();
            CreateUpperChord();
            CreateLowerChord();

            void DrawUpperArc()
            {
                int endAngle =0; //Deg
                    for (double i= startAngle; i< endAngle; i = i - stepsize)
                    {
                        /*Calculates points according to x = r cos(\fi)  y = r cos(\fi) */
                        double coordX = radiusX * Math.Cos(Trigonometry.ToRadians(i));
                        double coordY = radiusY * Math.Sin(Trigonometry.ToRadians(i));
                        pointsUpper.Add(new Point(coordX, coordY));
                    }
            }
            void DrawInnerArc () 
            {
                double startAngleInner = startAngle - stepsize/2;
                double endAngle = stepsize / 2;
                for (double i = startAngleInner; i < endAngle; i = i - stepsize) 
                {
                    double coordX = radiusX * Math.Cos(Trigonometry.ToRadians(i));
                    double coordY = radiusY * Math.Sin(Trigonometry.ToRadians(i));
                    innerPoints.Add(new Point(coordX, coordY));
                }
            }

            void CreateUpperChord()
            {
                var upperChord = SectionedBeam.CreateUpperChordBeam();
                for (int i = 0; i < pointsUpper.Count-1; i++) 
                {
                    upperChord.StartPoint = pointsUpper[i];
                    upperChord.EndPoint = pointsUpper[i + 1];
                    upperChord.Insert();
                }
            }

            void CreateLowerChord() 
            {
                var upperChord = SectionedBeam.CreateUpperChordBeam();
                for (int i = 0; i < innerPoints.Count-1; i++) 
                {
                    upperChord.StartPoint = innerPoints[i];
                    upperChord.EndPoint = innerPoints[i + 1];
                    upperChord.Insert();
                }
            }
        }
    }
}
