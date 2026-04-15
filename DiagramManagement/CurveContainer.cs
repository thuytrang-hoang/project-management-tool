using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmierprojekt.DiagramManagement
{
    // Generic container class for storing and managing curves
    public class CurveContainer<T> : List<T> where T : Curve
    {
        // Draws all elements in the container using the provided Graphics object
        public void DrawElements(Graphics g)
        {
            foreach (T element in this)
            {
                element.Draw(g);
            }
        }
    }
}
