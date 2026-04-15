using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmierprojekt.DiagramManagement
{
    // Manages status messages within the application using a singleton pattern
    public class StatusManager
    {
        // Functions taken from "I30 Programmierung 2 (PCÜ) - Gruppe A - SoSe2024"

        private static StatusManager _statusManager = null;

        // Private constructor for singleton pattern
        private StatusManager()
        { }

        // Get the one and only instance
        public static StatusManager Instance
        {
            get
            {
                if (_statusManager == null)
                {
                    _statusManager = new StatusManager();
                }
                return _statusManager;
            }
        }

        // Event triggered when the status message changes
        public event EventHandler<StatusMessageEventArgs> StatusMessageChanged;

        // Set a new status message
        public void SetStatus(string statusMessage)
        {
            if (statusMessage == null)
                return;

            if (StatusMessageChanged != null)
                StatusMessageChanged(this, new StatusMessageEventArgs(statusMessage));
        }
    }
}
