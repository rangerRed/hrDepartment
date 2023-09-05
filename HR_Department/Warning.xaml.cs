using System;
using System.Windows;
using System.Windows.Input;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для Warning.xaml
    /// </summary>
    public partial class Warning : Window
    {
        public Warning()
        {
            InitializeComponent();
            if (AddEmployeeClass.text_to_label != "")
            {
                text.Content = AddEmployeeClass.text_to_label;
            }

        }

        private void Exit(object sender, MouseButtonEventArgs e)
        {
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

        private void OK(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
