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
    /// Interaction logic for ViewInstructor.xaml
    /// </summary>
    public partial class ViewInstructor : Window
    {
        public ViewInstructor()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UniversityDataDataContext data = new UniversityDataDataContext();
            List<Instructor> instructor = (from s in data.Instructors select s).ToList();
            instructorGrid.ItemsSource = instructor;
        }

    }
}
