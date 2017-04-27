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
    /// Interaction logic for DeleteCourse.xaml
    /// </summary>
    public partial class DeleteCourse : Window
    {
        public DeleteCourse()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (courseID.Text.Trim() == "")
                MessageBox.Show("Insert Course ID");
            else
            {
                Course temp = new Course();
                temp.cid = courseID.Text.Trim();

                Admin.DeleteCourse(temp);
                MessageBox.Show("Successfully Deleted");
                DialogResult = true;
            }
        }
    }
}
