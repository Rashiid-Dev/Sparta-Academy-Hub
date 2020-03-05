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
    /// Interaction logic for CalendarWindow.xaml
    /// </summary>
    public partial class CalendarWindow : Window
    {
        public CalendarWindow()
        {
            InitializeComponent();
        }

        private void BackToDashboard_Click(object sender, RoutedEventArgs e)
        {
            Window CalendWindow = new CalendarWindow();
            Window oldWindow = new MainWindow();
            this.Close();
            //oldWindow.Show();
            ((MainWindow)this.Owner).LoginButtonClicked();
        }
    }
}
