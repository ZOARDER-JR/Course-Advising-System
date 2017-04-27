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
    /// Interaction logic for CoursesTaken.xaml
    /// </summary>
    public partial class CoursesTaken : Window
    {
        public CoursesTaken()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UniversityDataDataContext data = new UniversityDataDataContext();
            List<C_taken> courses = (from s in data.C_takens select s).ToList();
            takenGrid.ItemsSource = courses;
        }
    }
}
