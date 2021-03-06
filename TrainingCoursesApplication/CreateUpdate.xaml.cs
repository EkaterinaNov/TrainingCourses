using ClassLibraryBusinessLayer.Model;
using ClassLibraryBusinessLayer.Service;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TrainingCoursesApplication
{
    /// <summary>
    /// Interaction logic for CreateUpdateStudent.xaml
    /// </summary>
    public partial class CreateUpdate : Page
    {
        private StudentModel _student;
        private CourseModel _course;
        private EntityForAdd _entity;

        public CreateUpdate() { }

        public CreateUpdate(EntityForAdd entity)
        {
            InitializeComponent();

            AddButton.Visibility = Visibility.Visible;
            EditButton.Visibility = Visibility.Hidden;
            _entity = entity;
            
            if (_entity == EntityForAdd.Student)
            {
                UpdateCoursesComboBox();
                CourseLabel.Visibility = Visibility.Visible;
                CoursesComboBox.Visibility = Visibility.Visible;

                CourseCostLabel.Visibility = Visibility.Collapsed;
                CoursesCostTextBox.Visibility = Visibility.Collapsed;
            }

            else if (_entity == EntityForAdd.Course)
            {
                CourseLabel.Visibility = Visibility.Collapsed;
                CoursesComboBox.Visibility = Visibility.Collapsed;

                CourseCostLabel.Visibility = Visibility.Visible;
                CoursesCostTextBox.Visibility = Visibility.Visible;
            }
        }

        public CreateUpdate(StudentModel student)
        {
            InitializeComponent();

            _student = student;

            AddButton.Visibility = Visibility.Hidden;
            EditButton.Visibility = Visibility.Visible;

            CourseLabel.Visibility = Visibility.Visible;
            CoursesComboBox.Visibility = Visibility.Visible;

            CourseCostLabel.Visibility = Visibility.Collapsed;
            CoursesCostTextBox.Visibility = Visibility.Collapsed;

            UpdateCoursesComboBox();
            NameTextBox.Text = student.Name;
        }

        public CreateUpdate(CourseModel course)
        {
            InitializeComponent();

            _course = course;

            AddButton.Visibility = Visibility.Hidden;
            EditButton.Visibility = Visibility.Visible;

            CourseLabel.Visibility = Visibility.Collapsed;
            CoursesComboBox.Visibility = Visibility.Collapsed;

            CourseCostLabel.Visibility = Visibility.Visible;
            CoursesCostTextBox.Visibility = Visibility.Visible;

            NameTextBox.Text = course.Name;
            CoursesCostTextBox.Text = Convert.ToString(course.Cost);
        }

        private void UpdateCoursesComboBox()
        {
            CourseService courServ = new CourseService();
            List<CourseModel> courList = courServ.AllCourses();

            foreach (CourseModel cour in courList)
            {
                CoursesComboBox.Items.Add(cour);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                NameLabel.Visibility = Visibility.Visible;
                return;
            }

            if (_student != null)
            {
                CourseModel cour = (CourseModel)CoursesComboBox.SelectedItem;

                if(cour == null)
                {
                    CourseMessageLabel.Visibility = Visibility.Visible;
                    return;
                }
                else
                {
                    StudentService stService = new StudentService();
                    stService.EditStudent(_student.Id, NameTextBox.Text, cour.Id);
                    MainWindow.MainNavigationService.Navigate(new Students());
                }
            }

            else if (_course != null)
            {
                if (CoursesCostTextBox.Text == "")
                {
                    CourseCostMessageLabel.Visibility = Visibility.Visible;
                    return;
                }
                else
                {
                    CourseService courServ = new CourseService();
                    courServ.EditCourse(_course.Id, NameTextBox.Text, Convert.ToDecimal(CoursesCostTextBox.Text));
                    MainWindow.MainNavigationService.Navigate(new Courses());
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                NameLabel.Visibility = Visibility.Visible;
                return;
            }
            
            if (_entity == EntityForAdd.Student)
            {
                CourseModel cour = (CourseModel)CoursesComboBox.SelectedItem;

                if (cour == null)
                {
                    CourseMessageLabel.Visibility = Visibility.Visible;
                    return;
                }
                else
                {
                    StudentService stService = new StudentService();
                    stService.AddStudent(NameTextBox.Text, cour.Id);
                    MainWindow.MainNavigationService.Navigate(new Students());
                }
            }

            else if (_entity == EntityForAdd.Course)
            {
                if (CoursesCostTextBox.Text == "")
                {
                    CourseCostMessageLabel.Visibility = Visibility.Visible;
                    return;
                }
                else
                {
                    CourseService courServ = new CourseService();
                    courServ.AddCourse(NameTextBox.Text, Convert.ToDecimal(CoursesCostTextBox.Text));
                    MainWindow.MainNavigationService.Navigate(new Courses());
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            NameLabel.Visibility = Visibility.Hidden;
        }

        private void CoursesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CourseMessageLabel.Visibility = Visibility.Hidden;
        }

        private void CoursesCostTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CourseCostMessageLabel.Visibility = Visibility.Hidden;
        }
    }
}
