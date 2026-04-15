using Programmierprojekt;
using System;

namespace Programmierprojekt.DiagramManagement
{
    // Represents a straight line as a type of Curve
    public class Line : Curve
    {
        // Most functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024" with additional revisions and changes

        // User messages for selecting start and end points
        public const string StartMessage = "Bitte wählen Sie den ersten Punkt der Linie.";
        public const string EndMessage = "Bitte wählen Sie den Endpunkt Ihrer Linie.";
 
        // Properties defining the line
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public override double Length => StartPoint.DistanceTo(EndPoint);
        // Computes the direction vector of the line
        public Vector Direction => new Vector(EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y, EndPoint.Z - StartPoint.Z).Normalize();
        // Determines whether the line should be drawn as dashed
        public bool IsDashed { get; set; } = false;

        // Moves the line by a given offset in x and y direction
        public override void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }

        // Draws the line using the specified Graphics object
        public override void Draw(Graphics g)
        {
            if (IsDashed)
            {
                DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                DrawPen.DashPattern = new float[] { 10f, 5f }; 
            }
            else
            {
                DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }

            g.DrawLine(DrawPen, (float)StartPoint.X, (float)StartPoint.Y, (float)EndPoint.X, (float)EndPoint.Y);
        }

        // Constructor initializing the line with start and end points
        public Line(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        // Handles user interaction for creating a line by selecting it's start and end points
        public static ClickResult LineClickHandler(System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight, ref Curve currentElement, out string statusMessage)
        {
            ClickResult result = ClickResult.Canceled;
            statusMessage = string.Empty;

            // Converting screen coordinates to world coordinates
            Point worldPoint = TransformScreen2World(clickPoint, screenHeight);
            // Clicks with non-right buttons
            if (buttons != MouseButtons.Right)
            {
                if (currentElement == null || currentElement.GetType() != typeof(Line))
                {
                    // Create a line with the same start and end point
                    currentElement = new Line(worldPoint, worldPoint);

                    result = ClickResult.Created;
                    statusMessage = EndMessage;
                }
                else
                {
                    // Updating the end point
                    (currentElement as Line).EndPoint = worldPoint;

                    result = ClickResult.Finished;
                    statusMessage = StartMessage;
                }
            }
            return result;
        }
    }
}
