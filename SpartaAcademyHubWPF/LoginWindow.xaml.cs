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
            
            

        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
           
            var userLogin = UsernameText.Text;
            var userPassword = PasswordText.Password;

            using (var db = new AcademyHubContext())
            {
                

                var LoginQuery =
                from account in db.Accounts
                where account.UserName == userLogin
                where account.UserPass == userPassword
                select account;
               
                foreach (var logins in LoginQuery)
                {
                    if (userLogin == logins.UserName && userPassword == logins.UserPass)
                    {
                        MainWindow oldwindow = new MainWindow();
                        Login LoginWindow = new Login();
                        this.Close();
                        
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
            Window OpenRegisterwindow = new RegisterWindow();
            OpenRegisterwindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Login LoginWindow = new Login();

            this.Hide();
            OpenRegisterwindow.Show();
            OpenRegisterwindow.Owner = this;


            

        }

        public void CloseRegister()
        {
            MainWindow oldwindow = new MainWindow();
           ((MainWindow)this.Owner).LoginButtonClicked();
        }
    }
}
