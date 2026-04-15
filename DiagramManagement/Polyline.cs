using Programmierprojekt;
using System.Collections.Generic;
using System.Net;

namespace Programmierprojekt.DiagramManagement
{
    // Represents a polyline, a series of connected line segments
    public class Polyline : Curve, ISurface
    {
        // Most functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024" with additional revisions and changes

        // User messages for guiding polyline creation
        public const string StartMessage = "Bitte wählen Sie den Anfangspunkt Ihrer Polylinie.";
        public const string NextMessage = "Bitte wählen Sie einen weiteren Punkt Ihrer Polylinie mit der linken Maustaste oder die rechte Maustaste, um abzubrechen.";
        public const string EndMessage = "Bitte wählen Sie einen weiteren Punkt Ihrer Polylinie mit der linken Maustaste oder die rechte Maustaste, um zu beenden.";
        
        private readonly List<Point> _points = new List<Point>();
        
        // Properties defining the polyline characteristics
        public IReadOnlyList<Point> Points => _points.AsReadOnly();
        public bool IsDashed { get; set; } = false; // Neue Eigenschaft für gestrichelte Linien

        // Constructor initializing a polyline with given points
        public Polyline(Point[] points)
        {
            _points.AddRange(points);
        }

        // Moves the polyline by a given x and y offset
        public override void Move(int deltaX, int deltaY)
        {
            for (int i = 0; i < _points.Count; i++)
            {
                Point currentPoint = _points[i];
                _points[i] = new Point(currentPoint.X + deltaX, currentPoint.Y + deltaY, currentPoint.Z);
            }
        }

        // Computes the total length of the polyline by summing up all line segments
        public override double Length
        {
            get
            {
                double length = 0.0;
                foreach (var lineSegment in LineSegments)
                {
                    length += lineSegment.Length;
                }

                return length;
            }
        }

        // Checks if the polyline is closed
        public bool IsClosed
        {
            get
            {
                if (!IsValid)
                    return false;

                Point firstPoint = _points.First();
                Point lastPoint = _points.Last();
                return (firstPoint.X == lastPoint.X && firstPoint.Y == lastPoint.Y && firstPoint.Z == lastPoint.Z);
            }
        }

        // Checks if the polyline is planar
        public bool IsPlanar
        {
            get
            {
                if (_points.Count < 3)
                    return false;

                bool isFirst = true;
                Vector firstLineSegment = LineSegments.First();
                List<Vector> normals = new List<Vector>();
                foreach (var lineSegment in LineSegments)
                {
                    // Skip the first one
                    if (isFirst)
                    {
                        isFirst = false;
                        continue;
                    }

                    Vector normal = firstLineSegment.CrossProduct(lineSegment);
                    normals.Add(normal);
                }

                Vector firstNormal = normals.First();
                foreach (var normal in normals)
                {
                    // Skip the first one
                    if (isFirst)
                    {
                        isFirst = false;
                        continue;
                    }

                    if (!firstNormal.AreCollinear(normal))
                        return false;
                }

                return true;
            }
        }

        // Generates the vectors representing the line segments of the polyline
        private IEnumerable<Vector> LineSegments
        {
            get
            {
                for (int index = 0; index < _points.Count - 1; index++)
                {
                    Point firstPoint = _points[index];
                    Point secondPoint = _points[index + 1];
                    yield return new Vector(secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y,
                        secondPoint.Z - firstPoint.Z);
                }
            }
        }

        // Determines if the polyline has at least two points to be valid
        public bool IsValid => _points.Count >= 2;
        // Computes the area of a closed and planar polyline using a vector-based approach
        public double Area
        {
            get
            {
                if (!IsClosed || !IsPlanar)
                    return 0.0;

                // Area calculation according to http://geomalgorithms.com/a01-_area.html 
                Vector resultVector = new Vector();
                int n = _points.Count;
                for (int index = 0; index < _points.Count - 2; index++)
                {
                    Vector firstPoint = _points[index].AsVector();
                    Vector secondPoint = _points[index + 1].AsVector();

                    resultVector = resultVector.Add(firstPoint.CrossProduct(secondPoint));
                }

                // Compute the normal vector.
                Vector firstLineSegment = LineSegments.First();
                Vector lastLineSegment = LineSegments.Last();
                Vector normal = firstLineSegment.CrossProduct(lastLineSegment).Normalize();

                // Ensure a positive area value.
                return Math.Abs(0.5 * normal.DotProduct(resultVector));
            }
        }

        // Adds a new point to the polyline
        public void AddPoint(Point newPoint)
        {
            _points.Add(newPoint);
        }
        // Inserts a point at the specified index
        public void InsertPoint(int index, Point newPoint)
        {
            _points.Insert(index, newPoint);
        }
        // Removes a point at the specified index
        public void RemovePoint(int index)
        {
            _points.RemoveAt(index);
        }
        // Adds multiple points to the polyline
        public void PolyLine(Point[] points)
        {
            _points.AddRange(points);
        }

        // Draws the polyline using the specified Graphics object
        public override void Draw(Graphics g)
        {
            if (IsDashed)
            {
                DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                DrawPen.DashPattern = new float[] { 10f, 5f }; // Größere Abstände
            }
            else
            {
                DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }

            var points = _points.Select(p => new PointF((float)p.X, (float)p.Y));
            g.DrawLines(DrawPen, points.ToArray());
        }

        // Handles user interaction for creating a polyline by selecting multiple points
        public static ClickResult PolylineClickHandler(System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight,
               ref Curve currentElement, out string statusMessage)
        {
            ClickResult result = ClickResult.Canceled;
            statusMessage = string.Empty;
            // Converting screen coordinates to world coordinates
            Point worldPoint = TransformScreen2World(clickPoint, screenHeight);
            // Clicks with non-right buttons
            if (currentElement == null || currentElement.GetType() != typeof(Polyline))
            {
                if (buttons == MouseButtons.Left)
                {
                    // Create a new polyline with the selected start point
                    currentElement = new Polyline(new Point[] { worldPoint });
                    
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
                Polyline p = currentElement as Polyline;

                if (buttons == MouseButtons.Left)
                {
                    // Add a new point to the polyline
                    p.AddPoint(worldPoint);

                    result = ClickResult.PointHandled;
                    statusMessage = EndMessage;

                }
                else if (buttons == MouseButtons.Right && p.Points.Count < 2)
                {
                    result = ClickResult.Canceled;
                    statusMessage = StartMessage;
                }
                else if (buttons == MouseButtons.Right)
                {
                    // Finish the polyline
                    result = ClickResult.Finished;
                    statusMessage = StartMessage;
                }
            }
            return result;
        }
    }
}
