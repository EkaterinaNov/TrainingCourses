using ClassLibraryBusinessLayer.Model;
using ClassLibraryBusinessLayer.Service;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace TrainingCoursesApplication
{
    /// <summary>
    /// Interaction logic for Courses.xaml
    /// </summary>
    public partial class Courses : Page
    {
        public Courses()
        {
            InitializeComponent();

            DataGridTextColumn CourseNameColumn = new DataGridTextColumn();
            CourseNameColumn.Header = "Name";
            CourseNameColumn.Binding = new Binding("Name");
            CoursesDataGrid.Columns.Add(CourseNameColumn);

            DataGridTextColumn courseCostColumn = new DataGridTextColumn();
            courseCostColumn.Header = "Cost";
            courseCostColumn.Binding = new Binding("Cost");
            CoursesDataGrid.Columns.Add(courseCostColumn);

            DataGridTextColumn courseSumCoastColumn = new DataGridTextColumn();
            courseSumCoastColumn.Header = "Sum cost";
            courseSumCoastColumn.Binding = new Binding("SumCost");
            CoursesDataGrid.Columns.Add(courseSumCoastColumn);
            courseSumCoastColumn.Visibility = Visibility.Collapsed;

            UpdateAmountCoursesLabel();
        }

        private void MostExpensiveCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            CoursesDataGrid.Items.Clear();
            CoursesDataGrid.Columns[2].Visibility = Visibility.Hidden;

            CourseService courServ = new CourseService();
            List<CourseModel> courList = courServ.MostExpensiveCourse();

            foreach (CourseModel course in courList)
            {
                CoursesDataGrid.Items.Add(course);
            }
        }

        private void CheapestCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            CoursesDataGrid.Items.Clear();
            CoursesDataGrid.Columns[2].Visibility = Visibility.Hidden;

            CourseService courServ = new CourseService();
            List<CourseModel> courList = courServ.MostCheapestCourse();

            foreach (CourseModel course in courList)
            {
                CoursesDataGrid.Items.Add(course);
            }
        }

        private void MostProfitableCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            CoursesDataGrid.Items.Clear();

            CoursesDataGrid.Columns[2].Visibility = Visibility.Visible;

            CourseService courServ = new CourseService();
            List<AdvancedCourseModel> courList = courServ.MostProfitableCourses();

            foreach (AdvancedCourseModel course in courList)
            {
                CoursesDataGrid.Items.Add(course);
            }
        }

        private void EditCourseButton_Click(object sender, RoutedEventArgs e)
        {
            CourseModel cour = (CourseModel)CoursesDataGrid.SelectedItem;
            if (cour == null)
            {
                EditCourseLabel.Visibility = Visibility.Visible;
            }
            else
            {
                MainWindow.MainNavigationService.Navigate(new CreateUpdate(cour));
            }
        }

        private void ViewAllCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            CoursesDataGrid.Items.Clear();

            CourseService courServ = new CourseService();
            List<CourseModel> courList = courServ.AllCourses();

            foreach (CourseModel st in courList)
            {
                CoursesDataGrid.Items.Add(st);
            }
        }

        private void UpdateAmountCoursesLabel()
        {
            CourseService courServ = new CourseService();
            AmountCoursesLabel.Content = courServ.CountCourses();
        }

        private void AddCourseButton_Click(object sender, RoutedEventArgs e)
        {
            EntityForAdd entity = EntityForAdd.Course;

            MainWindow.MainNavigationService.Navigate(new CreateUpdate(entity));
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            CourseModel course = (CourseModel)CoursesDataGrid.SelectedItem;

            if (course == null)
            {
                EditCourseLabel.Visibility = Visibility.Visible;
            }
            else
            {
                EditCourseLabel.Visibility = Visibility.Hidden;
                CourseService courseServ = new CourseService();
                courseServ.DeleteCourse(course.Id);
                ViewAllCoursesButton_Click(sender, e);
                UpdateAmountCoursesLabel();
            }
        }
    }
}
