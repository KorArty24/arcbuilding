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

namespace WindowsFormsApp1.Arc
{
    public class TArc
    {
        public void BuildArc(ArcDTO dto)
        {
            double height =dto.height;
            double span = dto.span;
            double offset = dto.innerRadiusOffset;
            const int numPanels = 6; // temrprary for testing purposes
            double radiusY = height;
            double radiusX = dto.span/2;
            //gets the center of the arc B(a, r) where a is the center, r - radius
            (double x, double y) center = (span * 0.5, height - radiusY);
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
            CreateWeb();
            CreateLoweTies();

            void DrawUpperArc()
            {
                int endAngle =0; //Deg
                    for (double i= startAngle; i>= endAngle; i = i - stepsize)
                    {
                        /*Calculates points according to x = r cos(\fi)  y = r cos(\fi) */
                        double coordX = radiusX * Math.Cos(Trigonometry.ToRadians(i));
                        double coordY = radiusY * Math.Sin(Trigonometry.ToRadians(i));
                        pointsUpper.Add(new Point(coordX, 1000, coordY));
                    }
            }
            void DrawInnerArc () 
            {
                double startAngleInner = startAngle - stepsize/2;
                double endAngle = stepsize / 2;
                double radiusX_inner = radiusX - offset;
                double radiusY_inner = radiusY - offset;
                for (double i = startAngleInner; i >= endAngle; i = i - stepsize) 
                {
                    double coordX = radiusX_inner * Math.Cos(Trigonometry.ToRadians(i));
                    double coordY = radiusY_inner * Math.Sin(Trigonometry.ToRadians(i));
                    innerPoints.Add(new Point(coordX, 1000, coordY));
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
                var lowerChord = SectionedBeam.CreateLowerChordBeam();
                for (int i = 0; i < innerPoints.Count-1; i++) 
                {
                    lowerChord.StartPoint = innerPoints[i];
                    lowerChord.EndPoint = innerPoints[i + 1];
                    lowerChord.Insert();
                }
            }
            void CreateWeb()
            {
                var webEven =  SectionedBeam.CreateWeb();
                var webOdd = SectionedBeam.CreateWeb();
                List<Beam> lstEven = new List<Beam>(); // for debug purposes
                List<Beam> lstodd = new List<Beam>(); // for debug purposes
                for (int i=1; i < innerPoints.Count; i++) 
                {
                    // Inserts web [inner[0], upper[0]]
                    webOdd.StartPoint = pointsUpper[i];
                    webOdd.EndPoint = innerPoints[i];
                    lstodd.Add(webOdd);
                    webOdd.Insert();
                    //Inserts web tie [inner[0], upper[1]]
                    
                }
                for (int i = 0; i < innerPoints.Count-1; i++) 
                {
                    webEven.StartPoint = innerPoints[i];
                    webEven.EndPoint = pointsUpper[i+1];
                    lstEven.Add(webOdd);
                    webEven.Insert();
                }
            }

            void CreateLoweTies() 
            {
                var tie = SectionedBeam.CreateInnerOuterTies();
                for (int i =0; i< innerPoints.Count; i = i + innerPoints.Count())
                {
                    tie.StartPoint = innerPoints[i];
                    tie.EndPoint = pointsUpper[i];
                    tie.Insert();
                }
                tie.StartPoint = innerPoints[innerPoints.Count()-1];
                tie.EndPoint = pointsUpper[pointsUpper.Count()-1];
                tie.Insert();
            }
        }
    }
}
