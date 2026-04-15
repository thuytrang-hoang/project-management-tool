using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Programmierprojekt.DiagramManagement
{
    // Represents an oval shape, similar to the "Circle" class but with adjustable width and height
    public class Oval: Curve, ISurface
    {
        // Because of given similarities, class was created similar to "Circle" class

        // User messages for selecting center and boundary points
        public const string StartMessage = "Bitte wählen Sie den Mittelpunkt des Ovals.";
        public const string EndMessage = "Bitte wählen Sie den linken oder rechten äußeren Punkt des Ovals.";

        // Properties defining the oval
        public Point CenterPoint { get; set; }
        public Vector Normal { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        // Computes the area of the oval
        public double Area => Math.PI * Width / 2 * Height / 2;
        // Approximates the perimeter (circumference) of the oval
        public override double Length => Math.PI * (3 * (Width / 2 + Height / 2) - Math.Sqrt((3 * Width / 2 + Height / 2) * (Width / 2 + 3 * Height / 2))); //approximately

        // Constructor initializing the oval with center, normal, width, and height
        public Oval(Point centerPoint, Vector normal, double width, double height)
        {
            this.CenterPoint = centerPoint;
            this.Normal = normal;
            this.Width = width;
            this.Height = height;
        }

        // Moves the oval by a given offset in x and y direction.
        public override void Move(int deltaX, int deltaY)
        {
            CenterPoint = new Point(CenterPoint.X + deltaX, CenterPoint.Y + deltaY);
        }

        // Draws the oval using the specified Graphics object
        public override void Draw(Graphics g)
        {
            // Build a rectangle to describe the oval
            float x = (float)(CenterPoint.X - Width / 2);
            float y = (float)(CenterPoint.Y - Height / 2);
            float width = (float)Width;
            float height = (float)Height;

            RectangleF rectangle = new RectangleF(x, y, width, height);
            g.DrawEllipse(DrawPen, rectangle);
        }

        // Handles user interaction for creating an oval by selecting its center and adjusting its size
        public static ClickResult OvalClickHandler(System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight,
                ref Curve currentElement, out string statusMessage)
        {
            ClickResult result = ClickResult.Canceled;
            statusMessage = string.Empty;
            // Converting screen coordinates to world coordinates
            Point worldPoint = TransformScreen2World(clickPoint, screenHeight);
            // Clicks with non-right buttons
            if (buttons != MouseButtons.Right)
            {
                if (currentElement == null || currentElement.GetType() != typeof(Oval))
                {
                    // Create an oval with 0 width and 0 height
                    currentElement = new Oval(worldPoint, new Vector(), 0, 0);

                    result = ClickResult.Created;
                    statusMessage = EndMessage;
                }
                else
                {
                    Oval o = currentElement as Oval;
                    o.Width = o.CenterPoint.DistanceTo(worldPoint)*2;
                    // Height set to half of the Width to create an oval shape
                    o.Height = o.Width / 2;

                    result = ClickResult.Finished;
                    statusMessage = StartMessage;
                }
            }
            return result;
        }
    }
}

