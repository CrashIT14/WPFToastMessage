using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se.Creotec.WPFToastMessage
{
    public class ToastMessage
    {                
        /// <summary>
        /// Display a toast message for a defined amount of time
        /// </summary>
        /// <param name="message">The message to be shown</param>
        /// <param name="delay">Time in seconds that the toast will be shown</param>
        /// <param name="position">The position of the toast on the screen</param>
        public static void Show(String message, String title, int delay, Position position)
        {
            // Dummy action
            new ToastWindow(message, title, delay, position).Show();
        }

        public enum Position 
        {
            TOP_LEFT, TOP_RIGHT, BOTTOM_LEFT, BOTTOM_RIGHT
        }
    }
}
