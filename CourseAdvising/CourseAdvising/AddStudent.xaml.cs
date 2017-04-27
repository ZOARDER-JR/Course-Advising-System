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
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            int number;
            float number1; 
            if (studentID.Text.Trim() == "")
                MessageBox.Show("Missing Student ID");
            else if (firstName.Text.Trim() == "")
                MessageBox.Show("Missing First Name");
            else if (lastName.Text.Trim() == "")
                MessageBox.Show("Missing Last Name");
            else if (int.TryParse(creditEarned.Text, out number) == false)
                MessageBox.Show("Insert a number for Credit Earned");
            else if (int.TryParse(creditEarned.Text, out number) == true && (number < 0 || number > 145))
                 MessageBox.Show("Invalid input for Credit Earned");
            else if (float.TryParse(cgpa.Text, out number1) == false)
                MessageBox.Show("Insert a number for CGPA");
            else if (float.TryParse(cgpa.Text, out number1) == true && (number1 < 0 || number1 > 4))
                    MessageBox.Show("Invalid CGPA");
            else if (instructorID.Text.Trim() == "")
                MessageBox.Show("Missing Instructor ID");
            else
            {
                Student temp = new Student();
                temp.sid = studentID.Text.Trim();
                temp.sfname = firstName.Text.Trim();
                temp.slname = lastName.Text.Trim();
                temp.ccomp = number;
                temp.cgpa = number1;
                temp.insid = instructorID.Text.Trim();

                Admin.AddStudent(temp);
                MessageBox.Show("Successfully Added");
                DialogResult = true;
            }
        }
    }
}
