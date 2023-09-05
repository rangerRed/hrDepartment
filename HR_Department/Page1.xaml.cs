using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HR_Department
{

    public partial class Page1 : Page
    {
        List<Сотрудник> em_list;

        public Page1()
        {
            InitializeComponent();
        }

        private void AddEmployee(object sender, RoutedEventArgs e) // добавление
        {
            AddEmployeeClass.add = true;
            AddEmployeeClass.employee = new Сотрудник();
            AddEmployeeClass.empl_activity = new Трудовая_деятельность();
            AddEmployeeClass.empl_education = new ОбразовниеСот();
            AddEmployeeClass.empl_military_registration = new Воинский_учетСот();
            AddEmployeeClass.empl_passport = new Паспортные_данныеСот();
            AddEmployeeClass.fields = new дополнительные_поля();
            Manager.MainFrame.Navigate(new PageAddEmployee(null));
        }

        private void UpdateEmployee(object sender, RoutedEventArgs e) // изменение данных сотрудника
        {
            var employee_to_dismiss = HomeStafDataGrid.SelectedItems.Cast<Сотрудник>().ToList();
            AddEmployeeClass.add = false;
            if (employee_to_dismiss.Count == 1)
            {
                using (var db = new HR_DepartmentEntities()) {
                    string connection_string = ConfigurationManager.ConnectionStrings["HR_DepartmentEntities2"].ConnectionString;
                    SqlConnection sqlConnection = null;
                    SqlDataReader sqlDataReader = null;
                    sqlConnection = new SqlConnection(connection_string);
                    sqlConnection.Open();

                    // поиск всех данных сотрудника
                    AddEmployeeClass.employee = employee_to_dismiss[0];
                    
                    // паспортные данные
                    string command = "SELECT * FROM [Паспортные данныеСот] WHERE [Код сотрудника] = " + AddEmployeeClass.employee.Табельный_номер;
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    AddEmployeeClass.empl_passport = db.Паспортные_данныеСот.Find(sqlDataReader["id"]);
                    
                    // Образование
                    command = "SELECT * FROM [ОбразовниеСот] WHERE [Код сотрудника] = " + AddEmployeeClass.employee.Табельный_номер;
                    sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    AddEmployeeClass.empl_education = db.ОбразовниеСот.Find(sqlDataReader["ID диплома"]);

                    // Трудовая деятельность
                    command = "SELECT * FROM [Трудовая деятельность] WHERE [Код сотрудника] = " + AddEmployeeClass.employee.Табельный_номер;
                    sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    AddEmployeeClass.empl_activity = db.Трудовая_деятельность.Find(sqlDataReader["id"]);

                    // Воинский учет
                    command = "SELECT * FROM [Воинский учетСот] WHERE [Код сотрудника] = " + AddEmployeeClass.employee.Табельный_номер;
                    sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    AddEmployeeClass.empl_military_registration = db.Воинский_учетСот.Find(sqlDataReader["id"]);

                    // дополнительные поля
                    command = "SELECT * FROM [дополнительные поля] WHERE [код сотрудника] = " + AddEmployeeClass.employee.Табельный_номер;
                    sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    AddEmployeeClass.fields = db.дополнительные_поля.Find(sqlDataReader["id"]);

                    sqlConnection.Close();
                }
                Manager.MainFrame.Navigate(new PageAddEmployee(AddEmployeeClass.employee));
            }
            else
            {
                AddEmployeeClass.text_to_label = "Вы не выбрали сотрудника!";
                Warning warning = new Warning();
                warning.Show();
            }
        }

        private void dismiss(object sender, RoutedEventArgs e) // увольнение
        {
            var employee_to_dismiss = HomeStafDataGrid.SelectedItems.Cast<Сотрудник>().ToList();

            if(employee_to_dismiss.Count == 1)
            {
                AddEmployeeClass.employee = employee_to_dismiss[0];
                dismiss_employee dismiss = new dismiss_employee();
                dismiss.ShowDialog();
            }
            else
            {
                AddEmployeeClass.text_to_label = "Вы не выбрали сотрудника!";
                Warning warning = new Warning();
                warning.Show();
            }
        }

        //private void Click(object sender, RoutedEventArgs e) // кнопка
        //{
        //    AddEmployeeClass.employee = (sender as Button).DataContext as Сотрудник;
        //}

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
            try
            {
                if (Visibility.Visible == Visibility)
                {
                    HR_DepartmentEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    HomeStafDataGrid.ItemsSource = HR_DepartmentEntities.GetContext().Сотрудник.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refrash(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Visibility.Visible == Visibility)
                {
                    HR_DepartmentEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    HomeStafDataGrid.ItemsSource = HR_DepartmentEntities.GetContext().Сотрудник.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Employment_history_click(object sender, RoutedEventArgs e) // трудовая книжка
        {
            var employee_to_dismiss = HomeStafDataGrid.SelectedItems.Cast<Сотрудник>().ToList();

            if (employee_to_dismiss.Count == 1)
            {
                AddEmployeeClass.employee = employee_to_dismiss[0];
                Manager.MainFrame.Navigate(new employmet_history_page());
            }
            else
            {
                AddEmployeeClass.text_to_label = "Вы не выбрали сотрудника!";
                Warning warning = new Warning();
                warning.Show();
            }
        }

        private void print_T1(object sender, RoutedEventArgs e) // печать прием сотрудника Т-1
        {
            var employee_to_dismiss = HomeStafDataGrid.SelectedItems.Cast<Сотрудник>().ToList();

            
            if (employee_to_dismiss.Count == 1)
            {
                AddEmployeeClass.employee = employee_to_dismiss[0];
                var helper = new word_helper(AddEmployeeClass.path_project + "\\Docx\\Т-1.docx");

                using (var db = new HR_DepartmentEntities())
                {
                    AddEmployeeClass.org = db.Информация_об_организации.Find(1);
                    AddEmployeeClass.empl_activity = db.Трудовая_деятельность.FirstOrDefault(td => td.Код_сотрудника == AddEmployeeClass.employee.Табельный_номер);
                    AddEmployeeClass.fields = db.дополнительные_поля.FirstOrDefault(td => td.код_сотрудника == AddEmployeeClass.employee.Табельный_номер);
                }
                int index = AddEmployeeClass.org.ФИО_Руководителя.IndexOf(" ");
                int last_index = AddEmployeeClass.org.ФИО_Руководителя.LastIndexOf(" ");
                string surname_sup = "";
                for (int i = 0; i < index; i++)
                {
                    surname_sup += AddEmployeeClass.org.ФИО_Руководителя[i];
                }
                string N = AddEmployeeClass.org.ФИО_Руководителя[index + 1].ToString().ToUpper();
                string P = AddEmployeeClass.org.ФИО_Руководителя[last_index + 1].ToString().ToUpper();

                var items = new Dictionary<string, string>
            {
                { "<окпо>", AddEmployeeClass.org.ОКПО },
                { "<номер приказа>", AddEmployeeClass.empl_activity.C__приказа.ToString() },
                { "<дата приказа>", AddEmployeeClass.empl_activity.Дата_приказа.ToString().Replace("0:00:00", "") },
                { "<дата принятия>", AddEmployeeClass.empl_activity.Дата_приема_на_работу.ToString().Replace("0:00:00", "") },
                { "<срок договора>", AddEmployeeClass.empl_activity.Срок_договора.ToString().Replace("0:00:00", "") },
                { "<табельный номер>", AddEmployeeClass.employee.Табельный_номер.ToString() },
                { "<ФИО>", AddEmployeeClass.employee.Фамилия + " " + AddEmployeeClass.employee.Имя + " " + AddEmployeeClass.employee.Отчество },
                { "<отдел>", AddEmployeeClass.employee.Отдел },
                { "<должность>", AddEmployeeClass.employee.Должность },
                { "<разряд>", AddEmployeeClass.fields.разряд },
                { "<квалификационная категория>", AddEmployeeClass.fields.квалификационная_категория },
                { "<характер работы>", AddEmployeeClass.fields.характер_работы },
                { "<режим труда>", AddEmployeeClass.fields.режим_труда },
                { "<продолжительность недели>", AddEmployeeClass.fields.продолжительность_недели },
                { "<оклад>", AddEmployeeClass.empl_activity.Оклад.ToString() },
                { "<надбавка>", AddEmployeeClass.empl_activity.Надбавка.ToString() },
                { "<срок>", AddEmployeeClass.fields.испытательный_срок.ToString() },
                { "<полное название>", AddEmployeeClass.org.Полное_наименование },
                { "<дата ТД>", (AddEmployeeClass.empl_activity.Дата_договора.ToString() != "01.01.0001 0:00:00") ? AddEmployeeClass.empl_activity.Дата_договора.ToString().Replace(" 0:00:00", "") : "" },
                { "<номер ТД>", AddEmployeeClass.empl_activity.C__договора.ToString() },
                { "<должность руководителя>", AddEmployeeClass.org.Должность_руководителя },
                { "<фамилия инициалы>", surname_sup + " " + N + ". " + P + "." },
            };

                helper.Process(items);
            }
            else
            {
                AddEmployeeClass.text_to_label = "Вы не выбрали сотрудника!";
                Warning warning = new Warning();
                warning.Show();
            }
        }

        private void print_T2(object sender, RoutedEventArgs e) // печать карточка сотрудника Т-2
        {
            var employee_to_dismiss = HomeStafDataGrid.SelectedItems.Cast<Сотрудник>().ToList();

            if (employee_to_dismiss.Count == 1)
            {
                AddEmployeeClass.employee = employee_to_dismiss[0];
                T2 t2 = new T2();
                t2.ShowDialog();
            }
            else
            {
                AddEmployeeClass.text_to_label = "Вы не выбрали сотрудника!";
                Warning warning = new Warning();
                warning.Show();
            }
        }
    }
}

