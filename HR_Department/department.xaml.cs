using System.Windows;
using System.Windows.Input;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для department.xaml
    /// </summary>
    public partial class department : Window
    {
        public department()
        {
            InitializeComponent();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
            e.Handled = true;
        }

        private void Exit(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
