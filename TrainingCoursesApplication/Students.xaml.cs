using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ClassLibraryBusinessLayer.Model;
using ClassLibraryBusinessLayer.Service;

namespace TrainingCoursesApplication
{
    /// <summary>
    /// Interaction logic for Students.xaml
    /// </summary>
    public partial class Students : Page
    {
        public Students()
        {
            InitializeComponent();

            DataGridTextColumn columnName = new DataGridTextColumn();
            columnName.Header = "Name";
            columnName.Binding = new Binding("Name");
            StudentsDataGrid.Columns.Add(columnName);

            DataGridTextColumn columnCourseName = new DataGridTextColumn();
            columnCourseName.Header = "Course";
            columnCourseName.Binding = new Binding("Course.Name");
            StudentsDataGrid.Columns.Add(columnCourseName);

            DataGridTextColumn columnCourseCoast = new DataGridTextColumn();
            columnCourseCoast.Header = "Course cost";
            columnCourseCoast.Binding = new Binding("Course.Cost");
            StudentsDataGrid.Columns.Add(columnCourseCoast);

            UpdateAmountStudentsLabel();
        }

        private void ViewAllStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            StudentsDataGrid.Items.Clear();

            StudentService student = new StudentService();
            List<StudentModel> stList = student.AlphabeticalOrderByCourse();

            foreach (StudentModel st in stList)
            {
                StudentsDataGrid.Items.Add(st);
            }
        }

        private void EditStudentButton_Click(object sender, RoutedEventArgs e)
        {
            StudentModel st = (StudentModel)StudentsDataGrid.SelectedItem;

            if (st == null)
            {
                EditStudentLabel.Visibility = Visibility.Visible;
            }
            else
            {
                MainWindow.MainNavigationService.Navigate(new CreateUpdate(st));
            }
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            StudentModel st = (StudentModel)StudentsDataGrid.SelectedItem;

            if (st == null)
            {
                EditStudentLabel.Visibility = Visibility.Visible;
            }
            else
            {
                EditStudentLabel.Visibility = Visibility.Hidden;
                StudentService stService = new StudentService();
                stService.DeleteStudent(st.Id);
                ViewAllStudentsButton_Click(sender, e);
                UpdateAmountStudentsLabel();
            }
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            EntityForAdd entity = EntityForAdd.Student;
            
            MainWindow.MainNavigationService.Navigate(new CreateUpdate(entity));
        }

        private void UpdateAmountStudentsLabel()
        {
            StudentService stServ = new StudentService();
            AmountStudentsLabel.Content = stServ.CountStudents();
        }
    }
}
