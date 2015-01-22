using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Se.Creotec.WPFToastMessage
{
    public partial class ToastWindow : Window
    {
        private const double TOAST_MARGIN = 20.0;

        private const int DEFAULT_TIMER = 2;
        private const String DEFAULT_TITLE = "Notification";
        private const ToastMessage.Position DEFAULT_POS = ToastMessage.Position.TOP_RIGHT;

        private DispatcherTimer timer = new DispatcherTimer();

        public ToastWindow() { }
        
        public ToastWindow(String message)
            : this(message, DEFAULT_TITLE, DEFAULT_TIMER, DEFAULT_POS) {}
        public ToastWindow(String message, String title)
            : this(message, title, DEFAULT_TIMER, DEFAULT_POS) {}

        public ToastWindow(String message, String title, int delay) 
            : this(message, title, delay, DEFAULT_POS) {}

        public ToastWindow(String message, String title, int delay, ToastMessage.Position position)
        {
            InitializeComponent();
            timer.Tick += new EventHandler(closeToast);

            textToastMessage.Text = message;
            labelToastTitle.Content = title;
            timer.Interval = new TimeSpan(0, 0, delay);
            setPosition(position);

            timer.Start();
        }

        private void closeToast(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonToastClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sets the position of the toast based on a predefined position.
        /// </summary>
        /// <param name="position">The position where the toast will show</param>
        private void setPosition(ToastMessage.Position position)
        {
            // Using WorkArea to take things as the TaskBar in mind
            double screenWidth = System.Windows.SystemParameters.WorkArea.Width;
            double screenHeight = System.Windows.SystemParameters.WorkArea.Height;

            switch (position) {
                case ToastMessage.Position.TOP_LEFT:
                    this.Left = TOAST_MARGIN;
                    this.Top = TOAST_MARGIN;
                    break;
                case ToastMessage.Position.TOP_RIGHT:
                    this.Left = screenWidth - Width - TOAST_MARGIN;
                    this.Top = TOAST_MARGIN;
                    break;
                case ToastMessage.Position.BOTTOM_LEFT:
                    this.Left = TOAST_MARGIN;
                    this.Top = screenHeight - Height - TOAST_MARGIN;
                    break;
                case ToastMessage.Position.BOTTOM_RIGHT:
                    this.Left = screenWidth - Width - TOAST_MARGIN;
                    this.Top = screenHeight - Height - TOAST_MARGIN;
                    break;
            }
        }        
    }
}
