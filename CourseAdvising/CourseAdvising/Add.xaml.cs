﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Business;

namespace CourseAdvising
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (StudentID.Text.Trim() == "")
                MessageBox.Show("Missing Student ID");
            else if (CourseID.Text.Trim() == "")
                MessageBox.Show("Missing Course ID");
            else
            {
                C_taken temp = new C_taken();
                temp.sid = StudentID.Text.Trim();
                temp.cid = CourseID.Text.Trim();

                Admin.Add(temp);
                MessageBox.Show("Successfully Added");
                DialogResult = true;
            }

        }
    }
}
