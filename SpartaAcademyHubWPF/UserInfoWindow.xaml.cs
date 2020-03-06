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
    /// Interaction logic for UserInfoWindow.xaml
    /// </summary>
    public partial class UserInfoWindow : Window
    {
        Login LW = new Login();
        public UserInfoWindow()
        {
            InitializeComponent();
            
        }

        private void BackToDashBoardButton(object sender, RoutedEventArgs e)
        {
            Window UserInfWindow = new UserInfoWindow();
            Window oldWindow = new MainWindow();
            this.Close();
            //oldWindow.Show();
            ((MainWindow)this.Owner).LoginButtonClicked();
        }

        private void EditUserInfoButton(object sender, RoutedEventArgs e)
        {
           // var UserName = LW.StoredUserName;
           // UserInfoTextBlock.Text = UserName;
        }
    }
}
