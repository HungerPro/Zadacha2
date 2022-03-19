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

namespace natsuki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void change(object sender, RoutedEventArgs e)
        {
            okbutton.Visibility = Visibility.Visible;
            changebutton.Visibility = Visibility.Hidden;
            box.IsReadOnly = false;
        }

        private void ok(object sender, RoutedEventArgs e)
        {
            okbutton.Visibility = Visibility.Hidden;
            changebutton.Visibility = Visibility.Visible;
            box.IsReadOnly = true;
        }

        private void unlock(object sender, RoutedEventArgs e)
        {
            blockbutton.Visibility = Visibility.Visible;
            unlockbutton.Visibility = Visibility.Hidden;
            box.IsEnabled = true;
            okbutton.IsEnabled = true;
            changebutton.IsEnabled = true;
        }

        private void block(object sender, RoutedEventArgs e)
        {
            blockbutton.Visibility = Visibility.Hidden;
            unlockbutton.Visibility = Visibility.Visible;
            box.IsEnabled = false;
            okbutton.IsEnabled = false;
            changebutton.IsEnabled = false;
        }
        
        private void submit(object sender, RoutedEventArgs e)
        {
            if (passwordbox.Text == "Qwerty")
            {
                submitbutton.Visibility = Visibility.Hidden;
                passwordbox.Visibility = Visibility.Hidden;
                changebutton.Visibility=Visibility.Visible;
                blockbutton.Visibility=Visibility.Visible;
                box.Visibility = Visibility.Visible;

            }
        }
    }
}
