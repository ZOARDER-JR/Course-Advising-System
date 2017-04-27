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
    /// Interaction logic for AddCourse.xaml
    /// </summary>
    public partial class AddCourse : Window
    {
        public AddCourse()
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

            if (courseID.Text.Trim() == "")
                MessageBox.Show("Missing Course ID");
            else if (courseTitle.Text.Trim() == "")
                MessageBox.Show("Missing Course Tilte");
            else if (int.TryParse(credit.Text, out number) == false)
                MessageBox.Show("Insert a number for Credit");
            else if (int.TryParse(credit.Text, out number) == true)
            {
                if (number < 3 || number > 4)
                    MessageBox.Show("Invalid Credit Number");
                else
                {
                    Course temp = new Course();
                    temp.cid = courseID.Text.Trim();
                    temp.cname = courseTitle.Text.Trim();
                    temp.crdt = number;

                    Admin.AddCourse(temp);
                    MessageBox.Show("Successfully Added");
                    DialogResult = true;
                }
            }

        }
    }
}
