using System;
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
    /// Interaction logic for Withdraw.xaml
    /// </summary>
    public partial class Withdraw : Window
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void withdraw_Click(object sender, RoutedEventArgs e)
        {
            if (StudentID.Text.Trim() == "")
                MessageBox.Show("Missing Student ID");
            else
            {
                C_taken temp = new C_taken();
                temp.sid = StudentID.Text.Trim();

                Admin.Withdraw(temp);
                MessageBox.Show("Successfully Withdrawed All");
                DialogResult = true;
            }

        }
    }
}
