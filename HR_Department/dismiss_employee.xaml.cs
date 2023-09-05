using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для dismiss_employee.xaml
    /// </summary>
    public partial class dismiss_employee : Window
    {
        private Сотрудник _currentEmployee = new Сотрудник();

        public dismiss_employee()
        {
            InitializeComponent();
            if (AddEmployeeClass.employee != null)
            {
                _currentEmployee = AddEmployeeClass.employee;
                
            }
            date_dismissed.Text = DateTime.Now.ToString();
            date_order_dismissed.Text = DateTime.Now.ToString();
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

        private void Exit(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void dismiss(object sender, RoutedEventArgs e)
        {
            AddEmployeeClass.text_to_label = "Вы действительно хотите уволить сотрудника?";
            Update update = new Update();
            update.ShowDialog();
            if (AddEmployeeClass.yes_no == true) {
                using (var db = new HR_DepartmentEntities()) {
                    var empl = new Приказ_об_увольнении();
                    empl.Код_сотрудника = AddEmployeeClass.employee.Табельный_номер;
                    empl.Дата_увольнения = Convert.ToDateTime(date_dismissed.Text);
                    empl.Основание_увольнения = grounds.Text;
                    empl.Статья = article.Text;
                    empl.Пункт = paragraph.Text;
                    empl.Номер_приказа_на_увольнение = order_number.Text;
                    empl.Дата_приказа_на_увольнение = Convert.ToDateTime(date_order_dismissed.Text);
                    db.Приказ_об_увольнении.Add(empl);
                    HR_DepartmentEntities.GetContext().Сотрудник.Remove(_currentEmployee);
                    HR_DepartmentEntities.GetContext().SaveChanges();
                    AddEmployeeClass.text_to_label = "Сотрудник уволен.";
                    Warning update1 = new Warning();
                    update1.Show();
                    Close();
                }                
            }

        }

        private void print(object sender, RoutedEventArgs e)
        {
            var helper = new word_helper(AddEmployeeClass.path_project + "\\Docx\\Т-8.docx");

            using (var db = new HR_DepartmentEntities())
            {
                AddEmployeeClass.org = db.Информация_об_организации.Find(1);
                AddEmployeeClass.empl_activity = db.Трудовая_деятельность.FirstOrDefault(td => td.Код_сотрудника == AddEmployeeClass.employee.Табельный_номер);
            }
            int index = AddEmployeeClass.org.ФИО_Руководителя.IndexOf(" ");
            int last_index = AddEmployeeClass.org.ФИО_Руководителя.LastIndexOf(" ");
            string surname_sup = "";
            for(int i = 0; i < index; i++)
            {
                surname_sup += AddEmployeeClass.org.ФИО_Руководителя[i];
            }
            string N = AddEmployeeClass.org.ФИО_Руководителя[index + 1].ToString().ToUpper();
            string P = AddEmployeeClass.org.ФИО_Руководителя[last_index + 1].ToString().ToUpper();

            var items = new Dictionary<string, string>
            {
                { "<окпо>", AddEmployeeClass.org.ОКПО },
                { "<полное название>", AddEmployeeClass.org.Полное_наименование },
                { "<номер приказа>", AddEmployeeClass.empl_activity.C__приказа.ToString() },
                { "<дата приказа>", (AddEmployeeClass.empl_activity.Дата_приказа.Value.Date.ToString() != "01.01.0001 0:00:00") ? AddEmployeeClass.empl_activity.Дата_приказа.Value.Date.ToString().Replace(" 0:00:00", "") : "" },
                { "<дата договора>", (AddEmployeeClass.empl_activity.Дата_договора.ToString() != "01.01.0001 0:00:00") ? AddEmployeeClass.empl_activity.Дата_договора.ToString().Replace(" 0:00:00", "") : "" },
                { "<номер договора>", AddEmployeeClass.empl_activity.C__договора.ToString() },
                { "<дата увольнения>", date_dismissed.Text },
                { "<табельный номер>", AddEmployeeClass.employee.Табельный_номер.ToString() },
                { "<ФИО>", AddEmployeeClass.employee.Фамилия + " " + AddEmployeeClass.employee.Имя + " " + AddEmployeeClass.employee.Отчество },
                { "<отдел>", AddEmployeeClass.employee.Отдел },
                { "<должность>", AddEmployeeClass.employee.Должность },
                { "<основания>", grounds.Text },
                { "<статья>", article.Text },
                { "<пункт>", paragraph.Text },
                { "<ОснованиеНаименование>", "приказ" },
                { "<ОснованиеНомер>", order_number.Text },
                { "<ОснованиеСерия>", "" },
                { "<ОснованиеДата>", date_order_dismissed.Text },
                { "<должность руководителя>", AddEmployeeClass.org.Должность_руководителя },
                { "<фамилия инициалы>", surname_sup + " " + N + ". " + P + "." },
            };

            helper.Process(items);
        }
    }
}
