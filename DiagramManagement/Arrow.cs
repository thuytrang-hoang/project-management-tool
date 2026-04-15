using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmierprojekt.DiagramManagement
{
    // This Code was partially constructed with the help of ChatGPT4.o
    // Description: Support at the constructoin and optimization at "Draw", "DrawArrowHead", "RotateVector" and "SetArrowSize". The generated Code was revised by the programmer after feedback and adjustment was given.

    // Enum representing the possible sizes of an arrowhead
    public enum ArrowSize
    {
        Small,
        Large
    }

    // The Arrow class represents a drawable arrow that can be either a straight line or a polyline
    public class Arrow: Curve
    {
        // Messages displayed to the user during arrow creation
        public const string StartMessage = "Bitte wählen Sie den Anfangspunkt Ihres Pfeils.";
        public const string NextMessage = "Bitte wählen Sie einen weiteren Punkt Ihres Pfeils mit der linken Maustaste oder die rechte Maustaste, um abzubrechen.";
        public const string EndMessage = "Bitte wählen Sie den Endpunlt Ihres Pfeils.";

        // Fields representing the underlying shape of the arrow
        private Line Line;
        private Polyline Polyline;

        // Public properties allowing access to the line or polyline representation
        public Line ArrowLine 
        {
            get { return Line; }
            set { Line = value; }
        }
        public Polyline ArrowPolyline
        {
            get { return Polyline; }
            set { Polyline = value; }
        }

        // Arrowhead size and dashed style settings
        public double ArrowHeadSize { get; set; }
        public bool ArrowIsDashed { get; set; }

        // Returns the length of the arrow, whether it is a line or a polyline
        public override double Length => Line != null ? Line.Length : Polyline.Length;

        // Moves the arrow by a given delta in the x and y directions
        public override void Move(int deltaX, int deltaY)
        {
            if (Line != null)
            {
                Line.Move(deltaX, deltaY);
            }
            else if (Polyline != null)
            {
                Polyline.Move(deltaX, deltaY);
            }
        
        }

        // Constructor for an arrow based on a line
        public Arrow(Line line, double arrowHeadSize = 10.0, bool isDashed = false)
        {
            Line = line;
            ArrowHeadSize = arrowHeadSize;
            ArrowIsDashed = isDashed;
        }

        // Constructor for an arrow based on a polyline
        public Arrow(Polyline polyline, double arrowHeadSize = 10.0, bool isDashed = false)
        {
            Polyline = polyline;
            ArrowHeadSize = arrowHeadSize;
            ArrowIsDashed = isDashed;
        }

        // Draws the arrow, for both line and polyline
        public override void Draw(Graphics g)
        {
            if (Line != null)
            {
                DrawLineArrow(g);
            }
            else if (Polyline != null)
            {
                DrawPolylineArrow(g);
            }
        }

        // Draws an arrow with a stright line
        private void DrawLineArrow(Graphics g)
        {
            if (ArrowIsDashed)
            {
                Line.DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                Line.DrawPen.DashPattern = new float[] { 10, 5 };
            }
            else
            {
                Line.DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }

            // Draw the main line and the arrowhead
            Line.Draw(g);
            DrawArrowHead(g, Line.StartPoint, Line.EndPoint);
        }

        // Draws an arrow with a polyline
        private void DrawPolylineArrow(Graphics g)
        {
            // Set dashed or solid line style
            if (ArrowIsDashed)
            {
                Polyline.DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                Polyline.DrawPen.DashPattern = new float[] { 10f, 5f }; 
            }
            else
            {
                Polyline.DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            // Draw the polyline and the arrowhead at the last segment
            Polyline.Draw(g);

            if (Polyline.Points.Count > 1)
            {
                var points = Polyline.Points;
                DrawArrowHead(g, points[points.Count - 2], points.Last());
            }
        }

        // Draws the arrowhead at the end of a given line segment
        private void DrawArrowHead(Graphics g, Point fromPoint, Point toPoint)
        {
            // Calculate the direction of the arrow
            Vector direction = new Vector(toPoint.X - fromPoint.X, toPoint.Y - fromPoint.Y, toPoint.Z - fromPoint.Z).Normalize();

            // Dynamic adjustment of the arrowhead based on the segment length
            double segmentLength = fromPoint.DistanceTo(toPoint);
            double arrowHeadSize = Math.Min(ArrowHeadSize, segmentLength / 2);

            // Angle of the arrowhead (30 degree)
            double angle = Math.PI / 6;

            // Calculate the vectors for both sides of the arrowhead
            Vector left = RotateVector(direction, angle).MultiplyScalar(arrowHeadSize);
            Vector right = RotateVector(direction, -angle).MultiplyScalar(arrowHeadSize);

            // Calculate points for the arrowhead
            Point arrowLeft = new Point(toPoint.X - left.X, toPoint.Y - left.Y);
            Point arrowRight = new Point(toPoint.X - right.X, toPoint.Y - right.Y);

            // Draw arrowhead
            g.DrawLine(Line?.DrawPen ?? Polyline.DrawPen, (float)toPoint.X, (float)toPoint.Y, (float)arrowLeft.X, (float)arrowLeft.Y);
            g.DrawLine(Line?.DrawPen ?? Polyline.DrawPen, (float)toPoint.X, (float)toPoint.Y, (float)arrowRight.X, (float)arrowRight.Y);
        }

        // Rotates a vector by a specified angle (in radians)
        private Vector RotateVector(Vector vector, double angle)
        {
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            return new Vector(
                cos * vector.X - sin * vector.Y,
                sin * vector.X + cos * vector.Y,
                vector.Z
            );
        }

        // Sets the arrowhead size based on the enum ArrowSize
        public void SetArrowSize(ArrowSize size)
        {
            ArrowHeadSize = size == ArrowSize.Small ? 10.0 : 20.0;
        }
        // Handles user interaction for creating an arrow based on a LineClickHandler
        public static ClickResult ArrowLineClickHandler(
    System.Drawing.Point clickPoint,
    MouseButtons buttons,
    int screenHeight,
    ref Curve currentElement,
    out string statusMessage)
        {
            ClickResult result = ClickResult.Canceled;
            statusMessage = string.Empty;

            Point worldPoint = TransformScreen2World(clickPoint, screenHeight);

            if (buttons != MouseButtons.Right)
            {
                if (currentElement == null || currentElement.GetType() != typeof(Arrow))
                {
                    currentElement = new Arrow(new Line(worldPoint, worldPoint))
                    {
                        ArrowIsDashed = false
                    };
                    result = ClickResult.Created;
                    statusMessage = EndMessage;
                }
                else
                {
                    Arrow arrow = currentElement as Arrow;
                    if (arrow != null && arrow.Line != null)
                    {
                        arrow.Line.EndPoint = worldPoint;
                        result = ClickResult.Finished;
                        statusMessage = StartMessage;
                    }
                }
            }

            return result;
        
        }

        // Handles user interaction for creating an arrow based on a PolylineClickHandler
        public static ClickResult ArrowPolylineClickHandler(
            System.Drawing.Point clickPoint,
            MouseButtons buttons,
            int screenHeight,
            ref Curve currentElement,
            out string statusMessage)
        {
            ClickResult result = ClickResult.Canceled;
            statusMessage = string.Empty;

            Point worldPoint = TransformScreen2World(clickPoint, screenHeight);

            if (currentElement == null || currentElement.GetType() != typeof(Arrow) || ((Arrow)currentElement).Polyline == null)
            {
                if (buttons == MouseButtons.Left)
                {
                    Polyline basePolyline = new Polyline(new Point[] { worldPoint });
                    currentElement = new Arrow(basePolyline) { ArrowIsDashed = false };

                    result = ClickResult.Created;
                    statusMessage = NextMessage;
                }
                else if (buttons == MouseButtons.Right)
                {
                    result = ClickResult.Canceled;
                    statusMessage = StartMessage;
                }
            }
            else
            {
                Arrow arrow = currentElement as Arrow;

                if (arrow.Polyline != null)
                {
                    if (buttons == MouseButtons.Left)
                    {
                        // Add point to Polyline
                        arrow.Polyline.AddPoint(worldPoint);

                        result = ClickResult.PointHandled;
                        statusMessage = NextMessage;
                    }
                  
                    else if (buttons == MouseButtons.Right)
                    {
                        // PolyArrow completed
                        result = ClickResult.Finished;
                        statusMessage = StartMessage;
                    }
                }
            }
            return result;
        }

    }
}
