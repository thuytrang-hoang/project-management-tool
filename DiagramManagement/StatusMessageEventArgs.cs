using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmierprojekt.DiagramManagement
{
    // Event arguments class for status messages
    public class StatusMessageEventArgs : EventArgs
    {
        // Functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024"

        // Creates a new instance
        public StatusMessageEventArgs(string message)
        {
            Message = message;
        }

        // Gets the status message associated with the event
        public string Message { get; }
    }
}
