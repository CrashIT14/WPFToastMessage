using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se.Creotec.WPFToastMessage
{
    class ToastMessage
    {
        /// <summary>
        /// Display a toast message for a defined amount of time
        /// </summary>
        /// <param name="message">The message to be shown</param>
        /// <param name="delay">Time in milliseconds that the toast will be shown</param>
        public static void Show(String message, int delay)
        {
            // Dummy action
            new ToastWindow().Show();
        }
    }
}
