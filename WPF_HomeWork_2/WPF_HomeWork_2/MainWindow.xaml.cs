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

namespace WPF_HomeWork_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            anwserLabel.Visibility = Visibility.Hidden;
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            anwserLabel.Visibility = Visibility.Visible;
        }

        private void noButton_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.GetPosition(null).X - 1 < noButton.Margin.Left)
            noButton.Margin = new Thickness(e.GetPosition(null).X + noButton.Width / 2, e.GetPosition(null).Y - noButton.Height / 2, 0,0);

            else if (e.GetPosition(null).X + 1 > noButton.Margin.Left + noButton.Width)
                noButton.Margin = new Thickness(e.GetPosition(null).X - noButton.Width * 1.5, e.GetPosition(null).Y - noButton.Height/2, 0, 0);

            else if (e.GetPosition(null).Y - 1 < noButton.Margin.Top)
                noButton.Margin = new Thickness( (e.GetPosition(null).X) - (e.GetPosition(null).X - noButton.Margin.Left) , e.GetPosition(null).Y + noButton.Height / 2, 0, 0);

            else if (e.GetPosition(null).Y + 1 > noButton.Margin.Top + noButton.Height)
                noButton.Margin = new Thickness((e.GetPosition(null).X) - (e.GetPosition(null).X - noButton.Margin.Left), e.GetPosition(null).Y - noButton.Height * 2, 0, 0);

            else
                noButton.Margin = new Thickness((e.GetPosition(null).X) - noButton.Width ,e.GetPosition(null).Y - noButton.Height, 0, 0);
        }
    }
}
