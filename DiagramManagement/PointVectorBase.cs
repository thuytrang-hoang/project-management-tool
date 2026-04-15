using System;
namespace Programmierprojekt.DiagramManagement
{
    // Base class representing a 3D point or vector with basic operations
    public class PointVectorBase
    {
        // Functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024"
       
        // Small tolerance value used for numerical precision comparisons
        public const double Tolerance = 1E-10;
     
        // Properties representing the coordinates in 3D space
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        protected PointVectorBase()
        {
        }

        // Initializes a point/vector with the given coordinates (default: origin)
        public PointVectorBase(double x = 0, double y = 0, double z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }        
        // Copy constructor to create a new instance from an existing PointVectorBase
        public PointVectorBase(PointVectorBase sourcePvBase)
        {
            this.X = sourcePvBase.X;
            this.Y = sourcePvBase.Y;
            this.Z = sourcePvBase.Z;
        }

        // Calculates the Euclidean distance to another PointVectorBase
        public double CalculateDistanceTo(PointVectorBase endPvBase)
        {
            return Math.Sqrt(Math.Pow(endPvBase.X - this.X, 2) + Math.Pow(endPvBase.Y - this.Y, 2) + Math.Pow(endPvBase.Z - this.Z, 2));
        }

        // Adds multiple vectors to the current point/vector and returns the result
        public PointVectorBase CalculateSum(params Vector[] addends)
        {
            PointVectorBase sum = new PointVectorBase(X, Y, Z);
            foreach (Vector addend in addends)
            {
                sum.X += addend.X;
                sum.Y += addend.Y;
                sum.Z += addend.Z;
            }
            return sum;
        }

        // Converts this instance into a Point object
        public Point AsPoint()
        {
            return new Point(X, Y, Z);
        }

        // Converts this instance into a Vector object
        public Vector AsVector()
        {
            return new Vector(X, Y, Z);
        }

        // Returns a string representation of the point/vector
        public override string ToString()
        {
            return $"({X} | {Y} | {Z})";
        }
    }
}
