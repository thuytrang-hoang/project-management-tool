using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using Newtonsoft.Json;
using Point = Programmierprojekt.DiagramManagement.Point;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;


namespace Programmierprojekt.DiagramManagement
{
    // Class representing a drawing that consists of multiple curves and text boxes
    public class Drawing
    {
        // Functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024" 

        // Internal lists for storing curves and text boxes
        private readonly List<Curve> _curves = new List<Curve>();
        private readonly List<TransparentTextBox> _textBoxes = new List<TransparentTextBox>();
        // Provides read-only access to the list of curves
        public IReadOnlyList<Curve> Curves => _curves.AsReadOnly();

        // Event triggered when the drawing needs to be redrawn
        public event EventHandler Redraw;

        // Adds a new curve to the drawing and triggers a redraw event
        public void AddCurve(Curve newCurve)
        {
            _curves.Add(newCurve);

            if (Redraw != null)
            {
                Redraw(newCurve, new EventArgs());
            }
        }

        // Removes a curve at the specified index and triggers a redraw event
        public void RemoveCurve(int index)
        {
            Curve curve = _curves.ElementAt(index);

            _curves.RemoveAt(index);

            if (Redraw != null)
            {
                Redraw(curve, new EventArgs());
            }
        }

        // Draws all curves in the drawing
        public void Draw(Graphics g)
        {
            foreach (var curve in _curves)
            {
                curve.Draw(g);
            }
        }

        // Constructor that initializes the drawing with an array of curves
        public Drawing(Curve[] curves)
        {
            _curves.AddRange(curves);
        }

        // Removes all curves from the drawing and triggers a redraw event
        public void RemoveAllCurves()
        {
            Curve[] curves = _curves.ToArray();

            _curves.Clear();
            if (Redraw != null)
            {
                Redraw(curves, EventArgs.Empty);
            }
        }

        // Saves the curves 
        public void Save(string fileName)
        {
            List<Curve> curves = _curves.ToList();

            var serializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.Auto };

            using (TextWriter writer = File.CreateText(fileName))
            {
                serializer.Serialize(writer, curves);
            }
        }

        // Loads a saved drawing of curves from a file
        public void Load(string fileName)
        {
            var serializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.Auto };

            using (TextReader reader = File.OpenText(fileName))
            {
                _curves.Clear();
                _curves.AddRange(serializer.Deserialize(reader, typeof(List<Curve>)) as List<Curve>);
            }

            if (Redraw != null)
            {
                Redraw(_curves.ToArray(), EventArgs.Empty);
            }
        }

    }
}
