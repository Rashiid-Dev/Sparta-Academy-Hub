﻿using System;
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
            p.AcademiesMake();
            InitializeComponent();
            //mePlayer.Play();
            var count = 0;
            foreach (var makr in p.AcademiesMake())
            {
                PrintInfo.Text += makr + Environment.NewLine;
                count++;
            }



        }
    }
}
