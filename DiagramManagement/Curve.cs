using System;
using Programmierprojekt;
using Newtonsoft.Json;


namespace Programmierprojekt.DiagramManagement
{
    // Abstract base class representing a general curve in a diagram
    public abstract class Curve
    {
        // Functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024" except for "Move" function

        // Property defining the length of the curve (must be implemented by subclasses)
        [JsonIgnore]
        public abstract double Length { get; }

        // Pen used to draw the curve
        [JsonIgnore]
        public Pen DrawPen { get; set; } = new Pen(Color.Black);

        // Abstract method that must be implemented by subclasses to draw the curve
        public abstract void Draw(Graphics g);

        // Converts a screen coordinate to world coordinates
        public static Point TransformScreen2World(System.Drawing.Point screenPoint, int screenHeight)
        {
            return new Point(screenPoint.X, -(screenPoint.Y - screenHeight));
        }
        // Abstract method for shifting the curve by a given x and y offset
        public abstract void Move(int deltaX, int deltaY);

    }
}

