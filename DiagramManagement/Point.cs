using System;
using Programmierprojekt.DiagramManagement;


namespace Programmierprojekt.DiagramManagement
{
    // Represents a 3D point, derived from PointVectorBase
    public class Point : PointVectorBase
    {
        // Functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024"

        // Represents the origin point (0,0,0) in 3D space
        public static readonly Point Origin = new Point(0.0, 0.0, 0.0);

        public Point()
        {
        }

        // Initializes a point with given coordinates
        public Point(double x = 0, double y = 0, double z = 0) : base(x, y, z)
        {
        }

        // Initializes a point by copying the values from another point
        public Point(Point sourcePoint) : base(sourcePoint)
        {
        }

        // Computes the Euclidean distance from this point to another
        public double DistanceTo(Point endPoint)
        {
            return CalculateDistanceTo(endPoint);
        }

        // Adds multiple vectors to the current point and returns the resulting point
        public Point Add(params Vector[] addends)
        {
            return CalculateSum(addends).AsPoint();
        }
    }
}
