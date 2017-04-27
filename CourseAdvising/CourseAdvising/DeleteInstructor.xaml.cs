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
    /// Interaction logic for DeleteInstructor.xaml
    /// </summary>
    public partial class DeleteInstructor : Window
    {
        public DeleteInstructor()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (instructorID.Text.Trim() == "")
                MessageBox.Show("Insert Instructor ID");
            else
            {
                Instructor temp = new Instructor();
                temp.insid = instructorID.Text.Trim();

                Admin.DeleteInstructor(temp);
                MessageBox.Show("Successfully Deleted");
                DialogResult = true;
            }
        }
    }
}
