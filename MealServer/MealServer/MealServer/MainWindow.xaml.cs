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

namespace MealServer
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlMgr mSqlMgr;

        public MainWindow()
        {
            InitializeComponent();
            mSqlMgr = new SqlMgr();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mSqlMgr.InsertTest();
        }
    }
}