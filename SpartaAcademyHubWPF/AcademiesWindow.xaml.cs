using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SpartaAcademyHubWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Program p = new Program();
        public Window1()
        {
            InitializeComponent();
        }

        private void LondonButtonClick_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BirminghamButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow oldwindow = new MainWindow();
            BirminghamButton.Visibility = Visibility.Hidden;
            LondonButton.Visibility = Visibility.Hidden;
            BlurryBackground.Visibility = Visibility.Visible;
            PrintInfo.Visibility = Visibility.Visible;
            p.AcademiesMake();
            var count = 0;
            foreach (var makr in p.AcademiesMake())
            {
                PrintInfo.Text += makr + Environment.NewLine;
                PrintInfo.Text += Environment.NewLine;
                count++;
            }



        }

        private void BackToDashBoardButton(object sender, RoutedEventArgs e)
        {
            Window AcadWindow = new Window1();
            Window oldWindow = new MainWindow();
            this.Close();
            ((MainWindow)this.Owner).LoginButtonClicked();
        }
    }
}
