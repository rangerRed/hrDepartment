using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для update_employment_history.xaml
    /// </summary>
    public partial class update_employment_history : Page
    {
        public update_employment_history()
        {
            InitializeComponent();
            if (AddEmployeeClass.empl_hist != null) {
                date.Text = (AddEmployeeClass.empl_hist.Дата.ToString() == "01.01.0001 0:00:00") ? "" : AddEmployeeClass.empl_hist.Дата.ToString();
                intelligence.Text = AddEmployeeClass.empl_hist.Сведения_о_приеме_переводах_и_увольнении;
                name_base.Text = AddEmployeeClass.empl_hist.ОснованиеНаименование;
                date_base.Text = (AddEmployeeClass.empl_hist.ОснованиеДата.ToString() == "01.01.0001 0:00:00") ? "" : AddEmployeeClass.empl_hist.ОснованиеДата.ToString();
                number_base.Text = AddEmployeeClass.empl_hist.ОснованиеНомер;
                series_base.Text = AddEmployeeClass.empl_hist.ОснованиеСерия;
                personnel_event.Text = AddEmployeeClass.empl_hist.Вид_кадрового_мероприятия;
                article.Text = AddEmployeeClass.empl_hist.Статья_ФЗ_причины_при_увольнении;
                paragraph.Text = AddEmployeeClass.empl_hist.Пункт_ФЗ_причины_при_увольнении;
                fuction.Text = AddEmployeeClass.empl_hist.выполняемая_функция_при_наличии_;
                sign_of_cancellation.Text = (AddEmployeeClass.empl_hist.признак_отмены_записи.ToString() == "True") ? "Да" : "Нет";
                cancellation_date.Text = (AddEmployeeClass.empl_hist.дата_отмены_записи.ToString() == "01.01.0001 0:00:00") ? "" : AddEmployeeClass.empl_hist.дата_отмены_записи.ToString();
                parttime_worker.Text = (AddEmployeeClass.empl_hist.совместитель.ToString() == "True") ? "Да" : "Нет";
                position.Text = AddEmployeeClass.empl_hist.должность;
                department.Text = AddEmployeeClass.empl_hist.отдел;
                RKS.Text = AddEmployeeClass.empl_hist.работа_в_районах_крайнего_севера;
                UUID.Text = AddEmployeeClass.empl_hist.UUID;
                from_date.Text = (AddEmployeeClass.empl_hist.С_даты.ToString() == "") ? "" : AddEmployeeClass.empl_hist.С_даты.ToString();
                by_date.Text = (AddEmployeeClass.empl_hist.по_дату.ToString() == "") ? "" : AddEmployeeClass.empl_hist.по_дату.ToString();
            }
        }

        private void cancel_click(object sender, RoutedEventArgs e) // cancel
        {
            AddEmployeeClass.empl_hist = null;
            Manager.MainFrame.Navigate(new employmet_history_page());
        }

        private void Save_click(object sender, RoutedEventArgs e) // save
        {
            using (var db = new HR_DepartmentEntities())
            {
                bool is_update = AddEmployeeClass.empl_hist != null; // если я изменяю существующую запись
                var eh = new Трудовая_книжка();
                if(is_update)
                {
                    eh = db.Трудовая_книжка.Find(AddEmployeeClass.empl_hist.ID);
                }
                if (!is_update)
                {
                    StreamReader reader = new StreamReader(AddEmployeeClass.path_project + "\\Resources\\id_pp_eh.txt");
                    eh.C_пп = Convert.ToInt32(reader.ReadLine());
                    reader.Close();
                    StreamWriter writer = new StreamWriter(AddEmployeeClass.path_project + "\\Resources\\id_pp_eh.txt");
                    writer.WriteLine(++eh.C_пп);
                    writer.Close();
                }
                eh.Код_сотрудника = AddEmployeeClass.employee.Табельный_номер;
                eh.Дата = (date.Text != "") ? Convert.ToDateTime(date.Text) : Convert.ToDateTime("01.01.0001 0:00:00");
                eh.Сведения_о_приеме_переводах_и_увольнении = intelligence.Text;
                eh.ОснованиеНаименование = name_base.Text;
                eh.ОснованиеДата = (date_base.Text != "") ? Convert.ToDateTime(date_base.Text) : Convert.ToDateTime("01.01.0001 0:00:00");
                eh.ОснованиеНомер = number_base.Text;
                eh.ОснованиеСерия = series_base.Text;
                eh.Вид_кадрового_мероприятия = personnel_event.Text;
                eh.Статья_ФЗ_причины_при_увольнении = article.Text;
                eh.Пункт_ФЗ_причины_при_увольнении = paragraph.Text;
                eh.выполняемая_функция_при_наличии_ = fuction.Text;
                eh.признак_отмены_записи = (sign_of_cancellation.Text == "Да") ? true : false;
                eh.дата_отмены_записи = (cancellation_date.Text != "") ? Convert.ToDateTime(cancellation_date.Text) : Convert.ToDateTime("01.01.0001 0:00:00");
                eh.совместитель = (parttime_worker.Text == "Да") ? true : false;
                eh.должность = position.Text;
                eh.отдел = department.Text;
                eh.работа_в_районах_крайнего_севера = RKS.Text;
                eh.UUID = UUID.Text;
                eh.С_даты = (from_date.Text != "") ? Convert.ToDateTime(from_date.Text) : Convert.ToDateTime("01.01.0001 0:00:00");
                eh.по_дату = (by_date.Text != "") ? Convert.ToDateTime(by_date.Text) : Convert.ToDateTime("01.01.0001 0:00:00");
                if (!is_update)
                {
                    db.Трудовая_книжка.Add(eh);
                    AddEmployeeClass.text_to_label = "Запись добавлена!";
                }
                else
                {
                    AddEmployeeClass.text_to_label = "Запись обновлена!";
                }
                db.SaveChanges();
                Warning warning = new Warning();
                warning.Show();
                AddEmployeeClass.empl_hist = null;
                Manager.MainFrame.Navigate(new employmet_history_page());
            }
        }
    }
}
