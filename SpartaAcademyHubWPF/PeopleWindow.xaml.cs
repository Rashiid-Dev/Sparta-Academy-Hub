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
    /// Interaction logic for PeopleWindow.xaml
    /// </summary>
    public partial class PeopleWindow : Window
    {
        public PeopleWindow()
        {
            InitializeComponent();

        }

        private void BackToDashBoardButton(object sender, RoutedEventArgs e)
        {
            Window AcadWindow = new Window1();
            Window oldWindow = new MainWindow();
            this.Close();
            //oldWindow.Show();
            ((MainWindow)this.Owner).LoginButtonClicked();
        }

        private void ShowConnections_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AcademyHubContext())
            {

                var PeopleQuery =
                (from Daccount in db.Accounts
                select Daccount.Firstname + " " + Daccount.Lastname).ToList();

                foreach(string personread in PeopleQuery)
                {
                    
                    ListOfPeople.Items.Add($"{personread}");
                   
                }

            }
        }
    }
}
