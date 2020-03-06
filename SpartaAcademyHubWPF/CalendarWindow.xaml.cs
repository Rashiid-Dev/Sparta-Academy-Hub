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
using System.Linq;

namespace SpartaAcademyHubWPF
{
    /// <summary>
    /// Interaction logic for CalendarWindow.xaml
    /// </summary>
    public partial class CalendarWindow : Window
    {
        public CalendarWindow()
        {
            InitializeComponent();
            // Query the courses with dates from the Courses table
            using (var db = new AcademyHubContext())
            {
                var CalendarQuery =
                from coursedates in db.Courses
                select coursedates.StartDate;

                var startingdates = CalendarQuery;
            }

        }
        private void BackToDashboard_Click(object sender, RoutedEventArgs e)
        {
            Window CalendWindow = new CalendarWindow();
            Window oldWindow = new MainWindow();
            this.Close();
            ((MainWindow)this.Owner).LoginButtonClicked();
        }
    }
}
