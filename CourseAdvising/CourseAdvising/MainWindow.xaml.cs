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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Business;

namespace CourseAdvising
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_ViewStudent(object sender, RoutedEventArgs e)
        {
            Students student = new Students();
            student.ShowDialog();
        }

        private void MenuItem_Click_ViewCourse(object sender, RoutedEventArgs e)
        {
            ViewCourse course = new ViewCourse();
            course.ShowDialog();
        }

        private void MenuItem_Click_ViewInstructor(object sender, RoutedEventArgs e)
        {
            ViewInstructor instructor = new ViewInstructor();
            instructor.ShowDialog();
        }

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_Add(object sender, RoutedEventArgs e)
        {
            Add student = new Add();
            student.ShowDialog();
        }

        private void MenuItem_Click_Drop(object sender, RoutedEventArgs e)
        {
            Drop student = new Drop();
            student.ShowDialog();
        }

        private void MenuItem_Click_Withdraw(object sender, RoutedEventArgs e)
        {
            Withdraw student = new Withdraw();
            student.ShowDialog();
        }

        private void MenuItem_Click_AddStudent(object sender, RoutedEventArgs e)
        {
            AddStudent student = new AddStudent();
            student.ShowDialog();
        }

        private void MenuItem_Click_DeleteStudent(object sender, RoutedEventArgs e)
        {
            DeleteStudent student = new DeleteStudent();
            student.ShowDialog();
        }


        private void MenuItem_Click_AddInstructor(object sender, RoutedEventArgs e)
        {
            AddInstructor instructor = new AddInstructor();
            instructor.ShowDialog();
        }

        private void MenuItem_Click_DeleteInstructor(object sender, RoutedEventArgs e)
        {
            DeleteInstructor instructor = new DeleteInstructor();
            instructor.ShowDialog();
        }

        private void MenuItem_Click_AddCourse(object sender, RoutedEventArgs e)
        {
            AddCourse course = new AddCourse();
            course.ShowDialog();
        }

        private void MenuItem_Click_DeleteCourse(object sender, RoutedEventArgs e)
        {
            DeleteCourse course = new DeleteCourse();
            course.ShowDialog();
        }

        private void MenuItem_Click_Taken(object sender, RoutedEventArgs e)
        {
            CoursesTaken course = new CoursesTaken();
            course.ShowDialog();
        }

        private void MenuItem_Click_Comp(object sender, RoutedEventArgs e)
        {
            CourseCompleted course = new CourseCompleted();
            course.ShowDialog();
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

    }
}
