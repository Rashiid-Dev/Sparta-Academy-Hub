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
using System.Windows.Threading;


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
            StartClock();

            //var count = 0;
            //foreach (var makr in p.AcademiesMake())
            //{
            //    PrintInfo.Text += makr + Environment.NewLine;
            //    count++;
            //}



        }

        private void WelcomeButton_Click(object sender, RoutedEventArgs e)
        {
            //mePlayer.Close();
            WelcomeButton.Visibility = Visibility.Hidden;
            //BlurryBackground.Visibility = Visibility.Visible;
            //SpartaLogo.Visibility = Visibility.Hidden;
            AcademyLogo.Visibility = Visibility.Hidden;
            //Dashboard.Visibility = Visibility.Visible;
            //DigitalClock.Visibility = Visibility.Visible;
            //PartlyCloudy.Visibility = Visibility.Visible;
            //Weathertext.Visibility = Visibility.Visible;
            Window LoginWindow = new Login();
            LoginWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            LoginWindow.Show();
            LoginWindow.Owner = this;
        }

        public void LoginButtonClicked()
        {
            mePlayer.Close();
            BlurryBackground.Visibility = Visibility.Visible;
            SpartaLogo.Visibility = Visibility.Hidden;
            Dashboard.Visibility = Visibility.Visible;
            DigitalClock.Visibility = Visibility.Visible;
            PartlyCloudy.Visibility = Visibility.Visible;
            Weathertext.Visibility = Visibility.Visible;
        }


        public void StartClock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            DigitalClock.Text = DateTime.Now.ToString(@"hh\:mm");
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            Dashboard.Visibility = Visibility.Visible;
            DigitalClock.Visibility = Visibility.Visible;
            PartlyCloudy.Visibility = Visibility.Visible;
            Weathertext.Visibility = Visibility.Visible;
            PrintInfo.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;
            CoursesText.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Courses_Click(object sender, RoutedEventArgs e)
        {
            CoursesText.Visibility = Visibility.Visible;
            p.CoursesPrint();
            var count = 0;
            //foreach (var makr in p.CoursesPrint())
            //{
            CoursesText.Text += p.CoursesPrint() + Environment.NewLine;
            CoursesText.Text += Environment.NewLine;
            count++;
            //}
            Dashboard.Visibility = Visibility.Hidden;
            DigitalClock.Visibility = Visibility.Hidden;
            PartlyCloudy.Visibility = Visibility.Hidden;
            Weathertext.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Visible;
        }

        private void UserInfoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Academies_Click(object sender, RoutedEventArgs e)
        {
        //    PrintInfo.Visibility = Visibility.Visible;
        //    p.AcademiesMake();
        //    var count = 0;
        //    foreach (var makr in p.AcademiesMake())
        //    {
        //        PrintInfo.Text += makr + Environment.NewLine;
        //        PrintInfo.Text += Environment.NewLine;
        //        count++;
        //    }
        //    Dashboard.Visibility = Visibility.Hidden;
        //    DigitalClock.Visibility = Visibility.Hidden;
        //    PartlyCloudy.Visibility = Visibility.Hidden;
        //    Weathertext.Visibility = Visibility.Hidden;
        //    BackButton.Visibility = Visibility.Visible;

        Window AcadWindow = new Window1();
        Window oldWindow = new MainWindow();
            oldWindow.Close();
        AcadWindow.Show();
        AcadWindow.Owner = this;
        }

        private void Calendar_Click(object sender, RoutedEventArgs e)
        {
            Window CalendWindow = new CalendarWindow();
            Window oldWindow = new MainWindow();
            oldWindow.Close();
            CalendWindow.Show();
            CalendWindow.Owner = this;
        }

        private void People_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
