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
    /// Interaction logic for ViewCourse.xaml
    /// </summary>
    public partial class ViewCourse : Window
    {
        public ViewCourse()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UniversityDataDataContext data = new UniversityDataDataContext();
            List<Course> courses = (from s in data.Courses select s).ToList();
            courseGrid.ItemsSource = courses;
        }

  
    }
}
