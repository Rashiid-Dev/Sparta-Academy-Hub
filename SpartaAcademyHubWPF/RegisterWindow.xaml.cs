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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton(object sender, RoutedEventArgs e)
        {
            var userUsername = UsernameText.Text;
            var userFirstname = FirstnameText.Text;
            var userLastname = LastnameText.Text;
            var userMiddlename = MiddlenameText.Text;
            var userPassword = PasswordText.Password;
            var userPasswordCheck = RepeatPasswordText.Password;
            List<Accounts> RegisterQuery;

            using (var db = new AcademyHubContext())
            {


                RegisterQuery =
                (from account in db.Accounts
                 select account).ToList();
            }
                
                // Takes all the values from the textboxes, creates an object out of them and writes it to the database
                foreach (var logins in RegisterQuery)
                {
                    if (userUsername == logins.UserName)
                    {
                        RightOrWrong.Text = "This Username is taken, please choose another one";
                        break;

                    }
                    else if(userUsername != logins.UserName)
                    {
                        if(userPassword == userPasswordCheck)
                        {
                            //Sets Middlenames to null if if was left as it is
                            if(userMiddlename == "Middlenames")
                            {
                                Accounts InsertRegData = new Accounts();
                            {
                                InsertRegData.UserName = userUsername;
                                InsertRegData.Firstname = userFirstname;
                                InsertRegData.Lastname = userLastname;
                                InsertRegData.UserPass = userPassword;
                                using (var db = new AcademyHubContext())
                                {
                                    db.Accounts.Add(InsertRegData);
                                    // executes the commands to implement the changes to the database
                                    db.SaveChanges();
                                    Window loginwindow = new Login();
                                    Window OpenRegisterWindow = new RegisterWindow();
                                    this.Close();
                                    ((Login)this.Owner).CloseRegister();
                                    break;
                                    
                                }
                            }
                            }
                            else
                            {
                                Accounts InsertRegData = new Accounts();
                                {
                                    InsertRegData.UserName = userUsername;
                                    InsertRegData.Firstname = userFirstname;
                                    InsertRegData.Lastname = userLastname;
                                    InsertRegData.MiddleNames = userMiddlename;
                                    InsertRegData.UserPass = userPassword;
                                using (var db = new AcademyHubContext())
                                {
                                    db.Accounts.Add(InsertRegData);
                                    db.SaveChanges();
                                    Window loginwindow = new Login();
                                    Window OpenRegisterWindow = new RegisterWindow();
                                    this.Close();
                                    ((Login)this.Owner).CloseRegister();
                                    break;
                                    
                                }

                                }
                            }
                            
                            

                            

                           
                        }
                        else
                        {
                            RightOrWrong.Text = "Passwords do not match, please check again";
                            break;
                        }
                        
                    }
                }




            
        }

            
    }
}

