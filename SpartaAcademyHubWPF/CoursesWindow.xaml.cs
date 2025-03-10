﻿using System;
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
    /// Interaction logic for CoursesWindow.xaml
    /// </summary>
    public partial class CoursesWindow : Window
    {
        Program pr = new Program();
        public CoursesWindow()
        {
            InitializeComponent();
        }

        private void BackToDashBoardButton(object sender, RoutedEventArgs e)
        {
            Window CourseWindow = new CoursesWindow();
            Window oldWindow = new MainWindow();
            this.Close();
            ((MainWindow)this.Owner).LoginButtonClicked();
        }

        private void TakeToSDETCourses_Click(object sender, RoutedEventArgs e)
        {
            CoursesCardsGrid.Visibility = Visibility.Hidden;
            {
                foreach(var readCourse in pr.CoursesPrint())
                {
                    ListOfCourses.Items.Add(readCourse);
                }
            }
        }
    }
}
