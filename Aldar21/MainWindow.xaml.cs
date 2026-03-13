using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace Aldar21
{
    public partial class MainWindow : Window
    {
        List<Subject> subjects = new List<Subject>();

        public MainWindow()
        {
            InitializeComponent();

            subjects.Add(new Subject("Математика", false));
            subjects.Add(new Subject("История", true));
            subjects.Add(new Subject("Физика", false));

            UpdateList();
        }

        void UpdateList()
        {
            SubjectsList.ItemsSource = null;
            SubjectsList.ItemsSource = subjects;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (SubjectNameBox.Text != "")
            {
                subjects.Add(new Subject(SubjectNameBox.Text, SubjectStatus.IsChecked == true));
                SubjectNameBox.Text = "";
                UpdateList();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (SubjectsList.SelectedItem is Subject s)
            {
                subjects.Remove(s);
                UpdateList();
            }
        }

        private void ChangeStatus_Click(object sender, RoutedEventArgs e)
        {
            if (SubjectsList.SelectedItem is Subject s)
            {
                s.Status = !s.Status;
                UpdateList();
            }
        }

        private void FilterAll_Click(object sender, RoutedEventArgs e)
        {
            SubjectsList.ItemsSource = subjects;
        }

        private void FilterDone_Click(object sender, RoutedEventArgs e)
        {
            SubjectsList.ItemsSource = subjects.Where(x => x.Status).ToList();
        }

        private void FilterNotDone_Click(object sender, RoutedEventArgs e)
        {
            SubjectsList.ItemsSource = subjects.Where(x => !x.Status).ToList();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                File.WriteAllLines("subjects.txt",
                    subjects.Select(s => s.Name + ";" + s.Status));

                MessageBox.Show("Файл сохранён");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Subject
    {
        public string Name { get; set; }
        public bool Status { get; set; }

        public Subject(string name, bool status)
        {
            Name = name;
            Status = status;
        }

        public override string ToString()
        {
            return Name + " — " + (Status ? "Сдано" : "Не сдано");
        }
    }
}