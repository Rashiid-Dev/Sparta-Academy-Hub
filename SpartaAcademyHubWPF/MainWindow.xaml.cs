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
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Windows.Media.Effects;

namespace SpartaAcademyHubWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Program p = new Program();
        public MainWindow()
        {
            //p.AcademiesMake();
            InitializeComponent();
            mePlayer.Source = new Uri(@"C:\Users\TECH-W150birm\source\repos\SpartaAcademyHubWPFApp\SpartaAcademyHubWPF\Spartavid.mp4");
            mePlayer.Play();

            //var count = 0;
            //foreach (var makr in p.AcademiesMake())
            //{
            //    PrintInfo.Text += makr + Environment.NewLine;
            //    count++;
            //}



        }

        private void WelcomeButton_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Close();
            WelcomeButton.Visibility = Visibility.Hidden;
            BlurryBackground.Visibility = Visibility.Visible;
            SpartaLogo.Visibility = Visibility.Hidden;
            AcademyLogo.Visibility = Visibility.Hidden;
            Dashboard.Visibility = Visibility.Visible;
        }

        private void UserInfoButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Academy_OnClick(object sender, RoutedEventArgs e)
        {
            PrintInfo.Visibility = Visibility.Visible;
            p.AcademiesMake();
            var count = 0;
            foreach (var makr in p.AcademiesMake())
            {
                PrintInfo.Text += makr + Environment.NewLine;
                count++;
            }
            Dashboard.Visibility = Visibility.Hidden;

        }

        private void TwitterButton_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
