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
    /// Interaction logic for AddInstructor.xaml
    /// </summary>
    public partial class AddInstructor : Window
    {
        public AddInstructor()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            int number;

            if (instructorID.Text.Trim() == "")
                MessageBox.Show("Missing Instructor ID");
            else if (firstName.Text.Trim() == "")
                MessageBox.Show("Missing First Name");
            else if (lastName.Text.Trim() == "")
                MessageBox.Show("Missing Last Name");
            else if (int.TryParse(roomNo.Text, out number) == false)
                MessageBox.Show("Insert a number for Room");
            else if (int.TryParse(roomNo.Text, out number) == true)
            {
                if (number < 101 || number > 899)
                    MessageBox.Show("Invalid Room Number");
                else
                {
                    Instructor temp = new Instructor();
                    temp.insid = instructorID.Text.Trim();
                    temp.ifname = firstName.Text.Trim();
                    temp.ilname = lastName.Text.Trim();
                    temp.iroom = number;

                    Admin.AddInstructor(temp);
                    MessageBox.Show("Successfully Added");
                    DialogResult = true;
                }
            }
        }
    }
}
