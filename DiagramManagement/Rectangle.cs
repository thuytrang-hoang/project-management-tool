using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Programmierprojekt.DiagramManagement
{
    // Represents a rectangle in a diagram, implementing both Curve and ISurface
    public class Rectangle : Curve, ISurface
    {
        // Messages displayed to the user during rectangle creation
        public const string StartMessage = "Bitte wählen Sie die linke untere Ecke des Rechtecks.";
        public const string NextMessage = "Bitte wählen Sie die rechte untere Ecke des Rechtecks.";
        public const string EndMessage = "Bitte wählen Sie die rechte obere Ecke des Rechtecks.";

        // Properties defining the rectangle's characteristics
        public Point CornerPoint { get; set; } // Lower-left corner of the rectangle.
        public Vector Normal { get; set; } // Normal vector defining the rectangle's orientation.
        public double Width { get; set; }
        public double Height { get; set; }
        // Computes the area of the rectangle
        public double Area => Height * Width;
        // Computes the perimeter (length) of the rectangle
        public override double Length => 2.0 * Height + 2.0 * Width;

        // Constructor initializing the rectangle with a corner point, normal vector, height, and width
        public Rectangle(Point cornerPoint, Vector normal, double height, double width)
        {
            this.CornerPoint = cornerPoint;
            this.Normal = normal;
            this.Height = height;
            this.Width = width;
        }

        // Moves the rectangle by a given x and y offset
        public override void Move(int deltaX, int deltaY)
        {
            CornerPoint = new Point(CornerPoint.X + deltaX, CornerPoint.Y + deltaY);
        }

        // Draws the rectangle using the specified Graphics object
        public override void Draw(Graphics g)
        {
            // Build a rectangle
            float x = (float)CornerPoint.X;
            float y = (float)CornerPoint.Y;
            float width = (float)Width;
            float height = (float)Height;
            // Draw the rectangle
            g.DrawRectangle(DrawPen, x, y, width, height);
        }

        // Handles user interaction for creating a rectangle by selecting corner points
        public static ClickResult RectangleClickHandler(System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight,
                ref Curve currentElement, out string statusMessage)
        {
            ClickResult result = ClickResult.Canceled;
            statusMessage = string.Empty;

            // Converting screen coordinates to world coordinates
            Point worldPoint = TransformScreen2World(clickPoint, screenHeight);
            // Clicks with non-right buttons
            if (buttons != MouseButtons.Right)
            {
                if (currentElement == null || currentElement.GetType() != typeof(Rectangle))
                {
                    if (buttons == MouseButtons.Left)
                    {
                        // Create a rectangle with the same start point and no distance to the other points
                        currentElement = new Rectangle(worldPoint, new Vector(), 0, 0);

                        result = ClickResult.Created;
                        statusMessage = NextMessage;
                    }                    
                }
                else
                {
                    Rectangle r = currentElement as Rectangle;
                    if (r.Width == 0 && buttons == MouseButtons.Left)
                    { 
                        // Set width based on the distance between the corner point and current mouse position
                        r.Width = Math.Abs(worldPoint.X - r.CornerPoint.X);

                        result = ClickResult.PointHandled;
                        statusMessage = EndMessage;
                    }
                    else if (r.Height == 0 && buttons == MouseButtons.Left)
                    {
                        // Set height based on the distance between the corner point and current mouse position
                        r.Height = Math.Abs(worldPoint.Y - r.CornerPoint.Y);

                        result = ClickResult.Finished;
                        statusMessage = StartMessage;
                    }
                    else if (buttons == MouseButtons.Left)
                    {
                        result = ClickResult.Finished;
                        statusMessage = StartMessage; 
                    }
                }
            }
            return result;
        }
    }
}

