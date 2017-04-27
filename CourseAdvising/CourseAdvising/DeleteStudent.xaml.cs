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
    /// Interaction logic for DeleteStudent.xaml
    /// </summary>
    public partial class DeleteStudent : Window
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (studentID.Text.Trim() == "")
                MessageBox.Show("Insert Student ID");
            else
            {
                Student temp = new Student();
                temp.sid = studentID.Text.Trim();

                Admin.DeleteStudent(temp);
                MessageBox.Show("Successfully Deleted");
                DialogResult = true;
            }
        }
    }
}
