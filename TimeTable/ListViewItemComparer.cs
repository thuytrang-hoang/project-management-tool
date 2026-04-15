using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmierprojekt.TimeTable
{
    /*
     * Source: ChatGPT 4.0, 06.12.2024
     * Prompt: Implement a class that compares two ListViewItems based on a specific column index and sort order.
     * Notiz: Funktion Verstanden und Code etwas abgeändert
     */
    public class ListViewItemComparer : IComparer
    // Class implements the IComparer interface to provide custom comparison logic for sorting ListViewItems 
    // Uses Compare method -> determines the order of items based on a specific column index and supports ascending or descending sort order
    {
        private int columnIndex; // Column index to compare 
        private bool ascending; // Sort order (true for ascending / false for descending)

        public ListViewItemComparer(int column, bool ascending = true)
        {
            this.columnIndex = column;
            this.ascending = ascending;
        }

        public int Compare(object x, object y)
        {
            // Converts x and y to type ListViewItem
            ListViewItem item1 = x as ListViewItem; // as, because it makes the code safer because no exception is thrown if the conversion fails | returns null
            ListViewItem item2 = y as ListViewItem;

            int result;

            // Comparison for date column (Deadline)
            if (columnIndex == 2) // 2 because date is in column 2 (0,1,2...).
            {
                // Checks if Date is convertable to DateTime (Validation)
                DateTime date1, date2;
                bool isDate1 = DateTime.TryParse(item1.SubItems[columnIndex].Text, out date1);
                bool isDate2 = DateTime.TryParse(item2.SubItems[columnIndex].Text, out date2); 

                if (isDate1 && isDate2)
                    // Compare dates if both are valid
                    return DateTime.Compare(date1, date2);
                /*
                 * DateTime.Compare explanation: 
                 * Returns -1 if Date1 is before Date2
                 * Returns 1 if Date1 is after Date2
                 * Returns 0 if both dates are equal
                 */

                else if (isDate1) 
                    return -1; // If only item1 contains a valid date and item2 is not a date, -1 is returned
                else if (isDate2) 
                    return 1;  // -"-
                else 
                    return 0; // If none -"-
            }
            else
            {
                // Alphabetical sorting
                result = string.Compare(item1.SubItems[columnIndex].Text, item2.SubItems[columnIndex].Text);
            }

            return ascending ? result : -result; // ascending true: Sort ascending |  ascending false: order is reversed (-result)

            // Alternative without a ternary (?) operator:
            //if (ascending)
            //{
            //    return result; 
            //}
            //else
            //{
            //    return -result; 
            //}
        }
    }
}
