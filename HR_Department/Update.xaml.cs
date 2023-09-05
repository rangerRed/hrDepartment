using System;
using System.Windows;
using System.Windows.Input;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public Update()
        {
            InitializeComponent();
            if (AddEmployeeClass.text_to_label != "") {
                text.Content = AddEmployeeClass.text_to_label;
            }
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            AddEmployeeClass.yes_no = true;
            Close();
        }

        private void Exit(object sender, MouseButtonEventArgs e)
        {
            AddEmployeeClass.yes_no = false;
            Close();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
                e.Handled = true;
            }
            catch (InvalidOperationException ex)
            {

            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            AddEmployeeClass.yes_no = false;
            Close();
        }
    }
}
