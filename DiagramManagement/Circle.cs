using System;
using System.Net;
using Programmierprojekt;
using Programmierprojekt.DiagramManagement;

namespace Programmierprojekt.DiagramManagement
{
    // Represents a circular shape that implements both Curve and ISurface
    public class Circle : Curve, ISurface
    {
        // Most functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024" with additional revisions and changes

        // User messages displayed during circle creation
        public const string StartMessage = "Bitte wählen Sie den Mittelpunkt des Kreises.";
        public const string EndMessage = "Bitte wählen Sie einen äußeren Punkt des Kreises.";

        // Moves the circle by a given delta in x and y direction
        public override void Move(int deltaX, int deltaY)
        {
            CenterPoint = new Point(CenterPoint.X + deltaX, CenterPoint.Y + deltaY);
        }

        // Properties defining the circle
        public Point CenterPoint { get; set; }
        public Vector Normal { get; set; }
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;
        public override double Length => 2.0 * Math.PI * Radius;

        // Constructor initializing the circle with center, normal, and radius
        public Circle(Point centerPoint, Vector normal, double radius)
        {
            this.CenterPoint = centerPoint;
            this.Normal = normal;
            this.Radius = radius;
        }

        // Draws the circle on the given Graphics context
        public override void Draw(Graphics g)
        {
            // Build a rectangle to describe the circle
            float x = (float)(CenterPoint.X - Radius);
            float y = (float)(CenterPoint.Y - Radius);
            float diameter = 2f * (float)Radius;
            RectangleF rectangle = new RectangleF(x, y, diameter, diameter);
            g.DrawEllipse(DrawPen, rectangle);
        }

        // Handles user interaction to create a circle by selecting its center and radius
        public static ClickResult CircleClickHandler(System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight,
                ref Curve currentElement, out string statusMessage)
        {
            ClickResult result = ClickResult.Canceled;
            statusMessage = string.Empty;
            // Converting screen coordinates to world coordinates
            Point worldPoint = TransformScreen2World(clickPoint, screenHeight);
            // Clicks with non-right buttons
            if (buttons != MouseButtons.Right)
            {
                if (currentElement == null || currentElement.GetType() != typeof(Circle))
                {
                    // Create a circle on the center point with radius 0
                    currentElement = new Circle(worldPoint, new Vector(), 0);

                    result = ClickResult.Created;
                    statusMessage = EndMessage;
                }
                else
                {
                    Circle c = currentElement as Circle;
                    // Radius will be calculated based on the distance of the first and second point
                    c.Radius = c.CenterPoint.DistanceTo(worldPoint);

                    result = ClickResult.Finished;
                    statusMessage = StartMessage;
                }
            }

            return result;
        }
    }
}
