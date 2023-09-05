using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для employmet_history_page.xaml
    /// </summary>
    public partial class employmet_history_page : Page
    {
        public employmet_history_page()
        {
            InitializeComponent();
            name.Text = AddEmployeeClass.employee.Фамилия + " " + AddEmployeeClass.employee.Имя + " " + AddEmployeeClass.employee.Отчество;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HR_DepartmentEntities2"].ConnectionString);
            connection.Open();
            string command = "SELECT * FROM [Трудовая книжка] WHERE [Код сотрудника] = " + AddEmployeeClass.employee.Табельный_номер;
            SqlCommand createCommand = new SqlCommand(command, connection);
            createCommand.ExecuteNonQuery();
            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Трудовая книжка"); 
            dataAdp.Fill(dt);
            data_grid_history_employment.ItemsSource = dt.DefaultView;
            connection.Close();

        }

        private void go_back_click(object sender, RoutedEventArgs e) // cancel
        {
            AddEmployeeClass.employee = null;
            Manager.MainFrame.Navigate(new Page1());
        }

        private void add_click(object sender, RoutedEventArgs e) // add
        {
            Manager.MainFrame.Navigate(new update_employment_history());
        }

        private void delete_click(object sender, RoutedEventArgs e) // delete
        {
            try
            {
                AddEmployeeClass.text_to_label = "Удалить";
                search_history_e search_ = new search_history_e();
                search_.ShowDialog();
            }
            catch (FormatException ex)
            {
                AddEmployeeClass.text_to_label = ex.Message;
                Warning warning = new Warning();
                warning.Show();
            }
        }

        private void update_click(object sender, RoutedEventArgs e) // update
        {
            try
            {
                AddEmployeeClass.text_to_label = "Изменить";
                search_history_e search_ = new search_history_e();
                search_.ShowDialog();
            }
            catch (FormatException ex)
            {
                AddEmployeeClass.text_to_label = ex.Message;
                Warning warning = new Warning();
                warning.Show();
            }
        }

        private void refrash(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HR_DepartmentEntities2"].ConnectionString);
                connection.Open();
                string command = "SELECT * FROM [Трудовая книжка] WHERE [Код сотрудника] = " + AddEmployeeClass.employee.Табельный_номер;
                SqlCommand createCommand = new SqlCommand(command, connection);
                createCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Трудовая книжка");
                dataAdp.Fill(dt);
                data_grid_history_employment.ItemsSource = dt.DefaultView;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
