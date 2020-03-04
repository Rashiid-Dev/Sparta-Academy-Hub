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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            //MainWindow mainWindow = new MainWindow();
            
        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
            MainWindow oldwindow = new MainWindow();
            Login LoginWindow = new Login();
            this.Close();
            //oldwindow.LoginButtonClicked();
            ((MainWindow)this.Owner).LoginButtonClicked();


        }

        private void RegisterButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
