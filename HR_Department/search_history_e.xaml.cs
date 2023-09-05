using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для search_history_e.xaml
    /// </summary>
    public partial class search_history_e : Window
    {
        public search_history_e()
        {
            InitializeComponent();
            button_l.Content = AddEmployeeClass.text_to_label;
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

        private void Button_l_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeClass.text_to_label = button_l.Content.ToString();
            using (var db = new HR_DepartmentEntities())
            {
                int temp = Convert.ToInt32(textBox_pp.Text);
                var eh = db.Трудовая_книжка.FirstOrDefault(us => us.C_пп == temp && us.Код_сотрудника == AddEmployeeClass.employee.Табельный_номер);
                if (AddEmployeeClass.text_to_label == "Удалить")
                {                
                    if (eh == null)
                    {
                        AddEmployeeClass.text_to_label = "Такой записи нет";
                        Warning warning = new Warning();
                        warning.Show();
                    }
                    else
                    {
                        db.Трудовая_книжка.Remove(eh);
                        db.SaveChanges();
                        AddEmployeeClass.text_to_label = "Запись удалена.";
                        Warning update1 = new Warning();
                        update1.Show();
                        Close();
                    }
                }
                else if (AddEmployeeClass.text_to_label == "Изменить")
                {
                    if (eh == null)
                    {
                        AddEmployeeClass.text_to_label = "Такой записи нет";
                        Warning warning = new Warning();
                        warning.Show();
                    }
                    else
                    {
                        AddEmployeeClass.empl_hist = eh;
                        Manager.MainFrame.Navigate(new update_employment_history());
                        Close();
                    }
                }
            }            
        }
    }
}
