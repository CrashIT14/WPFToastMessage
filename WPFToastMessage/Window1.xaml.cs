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
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        private String title, message;
        private int delay;
        private ToastMessage.Position pos;

        public Window1()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToastMessage.Show(message, title, delay, pos);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            title = txtTitle.Text;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            message = txtMessage.Text;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            delay = (int)sliderDelay.Value;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pos = (ToastMessage.Position)comboPos.SelectedItem;
        }
    }
}
