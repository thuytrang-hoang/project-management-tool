using System;
using Programmierprojekt;
using Programmierprojekt.DiagramManagement;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmierprojekt.DiagramManagement
{
    // Enum representing possible results of a user click event in the diagram editor
    public enum ClickResult
    {
        Created,       // A new element was created.
        PointHandled,  // A point was added to an existing element.
        Finished,      // The element creation process was completed.
        Canceled       // The user canceled the operation.
    }

    // Delegate for handling click events on curves, modifying the current element accordingly
    public delegate ClickResult CurveClickHandler(System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight,
           ref Curve currentElement, out string statusMessage);

}