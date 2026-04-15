using System;
namespace Programmierprojekt.DiagramManagement
{
    // Represents a 3D vector with basic mathematical operations
    public class Vector : PointVectorBase
    {
        // Functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024"

        // Predefined vectors representing common directions and values
        public static readonly Vector Zero = new Vector(0.0, 0.0, 0.0);
        public static readonly Vector One = new Vector(1.0, 1.0, 1.0);
        public static readonly Vector XDir = new Vector(1.0, 0.0, 0.0);
        public static readonly Vector YDir = new Vector(0.0, 1.0, 0.0);
        public static readonly Vector ZDir = new Vector(0.0, 0.0, 1.0);

        // Computes the length (magnitude) of the vector
        public double Length => CalculateDistanceTo(Point.Origin);

        public Vector()
        {
        }

        // Constructors for creating vectors with specified coordinates or by copying another vector
        public Vector(double x = 0, double y = 0, double z = 0) : base(x, y, z)
        {
        }
        public Vector(Vector sourceVector) : base(sourceVector)
        {
        }

        // Adds multiple vectors to the current vector
        public Vector Add(params Vector[] addends)
        {
            return CalculateSum(addends).AsVector();
        }

        // Subtracts multiple vectors from the current vector
        public Vector Subtract(params Vector[] subtrahends)
        {

            Vector difference = new Vector(X, Y, Z);
            foreach (Vector subtrahend in subtrahends)
            {
                difference.X -= subtrahend.X;
                difference.Y -= subtrahend.Y;
                difference.Z -= subtrahend.Z;
            }
            return difference;
        }

        // Multiplies the vector by a scalar value
        public Vector MultiplyScalar(double scalarFactor)
        {
            return new Vector(
                           scalarFactor * X,
                           scalarFactor * Y,
                           scalarFactor * Z
                       );
        }

        // Computes the cross product of this vector with another vector
        public Vector CrossProduct(Vector b)
        {
            return new Vector(
                           Y * b.Z - Z * b.Y,
                           Z * b.X - X * b.Z,
                           X * b.Y - Y * b.X
                       );
        }

        // Computes the dot product of this vector with another vector
        public double DotProduct(Vector b)
        {
            return X * b.X + Y * b.Y + Z * b.Z;
        }

        // Returns a normalized version of the vector (unit vector)
        public Vector Normalize()
        {
            double length = Length;
            return new Vector(this.X / length, this.Y / length, this.Z / Length);
        }

        // Checks if this vector is collinear with another vector within a given tolerance
        public bool AreCollinear(Vector b, double tolerance = PointVectorBase.Tolerance)
        {
            Vector cross = CrossProduct(b);
            return Math.Abs(cross.X) <= tolerance && Math.Abs(cross.Y) <= tolerance && Math.Abs(cross.Z) <= tolerance;
        }
    }
}
