using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using _38_04.StudentDataApp;

namespace StudentDataApp
{
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private const string DataFileName = "students.json";

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            UpdateStudentsList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtGroup.Text) ||
                dpBirthDate.SelectedDate == null)
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var student = new Student
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Group = txtGroup.Text,
                Gender = (Gender)(cmbGender.SelectedItem as ComboBoxItem)?.Tag,
                BirthDate = dpBirthDate.SelectedDate.Value
            };

            students.Add(student);
            UpdateStudentsList();
            ClearInputFields();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            students.Clear();
            UpdateStudentsList();
        }

        private void UpdateStudentsList()
        {
            lstStudents.Items.Clear();
            foreach (var student in students)
            {
                lstStudents.Items.Add(student);
            }
        }

        private void ClearInputFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtGroup.Clear();
            cmbGender.SelectedIndex = 0;
            dpBirthDate.SelectedDate = DateTime.Today;
        }

        private void LoadData()
        {
            if (File.Exists(DataFileName))
            {
                try
                {
                    string json = File.ReadAllText(DataFileName);
                    students = JsonSerializer.Deserialize<List<Student>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SaveData()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(students, options);
                File.WriteAllText(DataFileName, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveData();
        }
    }
}