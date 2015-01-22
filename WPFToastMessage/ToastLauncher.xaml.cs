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
using System.Windows.Shapes;

namespace Se.Creotec.WPFToastMessage
{
    public partial class ToastLauncher : Window
    {

        private String title, message;
        private int delay;
        private ToastMessage.Position pos;

        public ToastLauncher()
        {
            InitializeComponent();
            List<ToastMessage.Position> posis = new List<ToastMessage.Position>();
            posis.Add(ToastMessage.Position.TOP_RIGHT);
            posis.Add(ToastMessage.Position.TOP_LEFT);
            posis.Add(ToastMessage.Position.BOTTOM_RIGHT);
            posis.Add(ToastMessage.Position.BOTTOM_LEFT);

            comboPos.ItemsSource = posis;
            comboPos.SelectedItem = posis[0];

            title = "";
            message = "";
            delay = 2;
            pos = ToastMessage.Position.TOP_RIGHT;
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            // This is where the toast is created
            ToastMessage.Show(message, title, delay, pos);
        }

        #region Value Setting
        private void txtTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            title = txtTitle.Text;
        }

        private void txtMessage_TextChanged(object sender, TextChangedEventArgs e)
        {
            message = txtMessage.Text;
        }

        private void sliderDelay_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            delay = (int)sliderDelay.Value;
        }

        private void comboPos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pos = (ToastMessage.Position)comboPos.SelectedItem;
        }
        #endregion
    }
}
