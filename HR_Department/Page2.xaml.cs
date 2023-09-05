using System;
using System.Windows;
using System.Windows.Controls;

using System.IO;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            using (var db = new HR_DepartmentEntities())
            {
                var tb = db.Информация_об_организации.Find(1);
                short_name.Text = tb.Краткое_название;
                full_name.Text = tb.Полное_наименование;
                city.Text = tb.Город;
                address.Text = tb.Адрес;
                INN.Text = tb.ИНН;
                KPP.Text = tb.КПП;
                calculation1.Text = tb.Расс__счет;
                calculation2.Text = tb.Корр__счет;
                OKPO.Text = tb.ОКПО;
                OGRN.Text = tb.ОГРН;
                number_PFR.Text = tb.Рег__номер_в_ПФР;
                id_PFR.Text = tb.Код_ТО_ПФР;
                banck.Text = tb.В_банке;
                BIK_banck.Text = tb.БИК_банка;
                FIO_employee_HR_department.Text = tb.ФИО_работника_кадровой_службы;
                FIO_main_accountant.Text = tb.ФИО_Главного_бухгалтера;
                FIO_supervisor.Text = tb.ФИО_Руководителя;
                position_supervisor.Text = tb.Должность_руководителя;
                position_employee_HR_department.Text = tb.Должность_работника_кадровой_службы;
                phone_fax.Text = tb.Телефон_факс;
                note.Text = tb.Примечание;
            }
        }

        private void Check_update_Checked(object sender, RoutedEventArgs e)
        {
            short_name.IsEnabled = true;
            full_name.IsEnabled = true;
            city.IsEnabled = true;
            address.IsEnabled = true;
            INN.IsEnabled = true;
            KPP.IsEnabled = true;
            calculation1.IsEnabled = true;
            calculation2.IsEnabled = true;
            OKPO.IsEnabled = true;
            OGRN.IsEnabled = true;
            number_PFR.IsEnabled = true;
            id_PFR.IsEnabled = true;
            banck.IsEnabled = true;
            BIK_banck.IsEnabled = true;
            FIO_employee_HR_department.IsEnabled = true;
            FIO_main_accountant.IsEnabled = true;
            FIO_supervisor.IsEnabled = true;
            position_supervisor.IsEnabled = true;
            position_employee_HR_department.IsEnabled = true;
            phone_fax.IsEnabled = true;
            note.IsEnabled = true;
            but_save.IsEnabled = true;
        }

        private void Check_update_Unchecked(object sender, RoutedEventArgs e)
        {
            short_name.IsEnabled = false;
            full_name.IsEnabled = false;
            city.IsEnabled = false;
            address.IsEnabled = false;
            INN.IsEnabled = false;
            KPP.IsEnabled = false;
            calculation1.IsEnabled = false;
            calculation2.IsEnabled = false;
            OKPO.IsEnabled = false;
            OGRN.IsEnabled = false;
            number_PFR.IsEnabled = false;
            id_PFR.IsEnabled = false;
            banck.IsEnabled = false;
            BIK_banck.IsEnabled = false;
            FIO_employee_HR_department.IsEnabled = false;
            FIO_main_accountant.IsEnabled = false;
            FIO_supervisor.IsEnabled = false;
            position_supervisor.IsEnabled = false;
            position_employee_HR_department.IsEnabled = false;
            phone_fax.IsEnabled = false;
            note.IsEnabled = false;
            but_save.IsEnabled = false;
        }

        private void But_save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new HR_DepartmentEntities())
                {
                    var tb = db.Информация_об_организации.Find(1);
                    tb.Краткое_название = short_name.Text;
                    tb.Полное_наименование = full_name.Text;
                    tb.Город = city.Text;
                    tb.Адрес = address.Text;
                    tb.ИНН = INN.Text;
                    tb.КПП = KPP.Text;
                    tb.Расс__счет = calculation1.Text;
                    tb.Корр__счет = calculation2.Text;
                    tb.ОКПО = OKPO.Text;
                    tb.ОГРН = OGRN.Text;
                    tb.Рег__номер_в_ПФР = number_PFR.Text;
                    tb.Код_ТО_ПФР = id_PFR.Text;
                    tb.В_банке = banck.Text;
                    tb.БИК_банка = BIK_banck.Text;
                    tb.ФИО_работника_кадровой_службы = FIO_employee_HR_department.Text;
                    tb.ФИО_Главного_бухгалтера = FIO_main_accountant.Text;
                    tb.ФИО_Руководителя = FIO_supervisor.Text;
                    tb.Должность_руководителя = position_supervisor.Text;
                    tb.Должность_работника_кадровой_службы = position_employee_HR_department.Text;
                    tb.Телефон_факс = phone_fax.Text;
                    tb.Примечание = note.Text;
                    db.SaveChanges();
                    check_update.IsChecked = false;
                    AddEmployeeClass.text_to_label = "Изменения сохранены";
                    Warning warning = new Warning();
                    warning.Show();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
