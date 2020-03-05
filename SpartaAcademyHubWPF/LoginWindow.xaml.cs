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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        //public string selectedusername { get; set; }
        //public string selecteduserpass { get; set; }
        
        public Login()
        {
            InitializeComponent();
            //MainWindow mainWindow = new MainWindow();
            

        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
           
            var userLogin = UsernameText.Text;
            var userPassword = PasswordText.Text;

            using (var db = new AcademyHubContext())
            {
                

                var LoginQuery =
                //from order in db.Orders.Include(o => o.Customer)
                //where order.Freight > 750
                //select order;
                from account in db.Accounts
                where account.UserName == userLogin
                where account.UserPass == userPassword
                select account;
                //if(selectedusername ==)
                foreach (var logins in LoginQuery)
                {
                    if (userLogin == logins.UserName && userPassword == logins.UserPass)
                    {
                        MainWindow oldwindow = new MainWindow();
                        Login LoginWindow = new Login();
                        this.Close();
                        //oldwindow.LoginButtonClicked();
                        ((MainWindow)this.Owner).LoginButtonClicked();
                    }
                    else
                    {
                        RightOrWrong.Text = "Wrong Username or/and Password";
                    }
                }




            }

        }

        private void RegisterButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
