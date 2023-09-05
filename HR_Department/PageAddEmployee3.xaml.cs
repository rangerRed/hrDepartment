using System;
using System.Windows;
using System.Windows.Controls;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для PageAddEmployee3.xaml
    /// </summary>
    public partial class PageAddEmployee3 : Page
    {
        public PageAddEmployee3()
        {
            InitializeComponent();
            obrazNameDoc.Text = AddEmployeeClass.empl_education.Наименование_документа_об_образовании;
            ObrazSeriya.Text = AddEmployeeClass.empl_education.Серия;
            obraznomer.Text = AddEmployeeClass.empl_education.Номер;
            obraztipobrazov.Text = AddEmployeeClass.empl_education.Тип_образования;
            obrazNaimenovUchebZav.Text = AddEmployeeClass.empl_education.Наименование_учебного_заведения;
            obrazSpecialnost.Text = AddEmployeeClass.empl_education.Специальность;
            obrazKvalifikac.Text = AddEmployeeClass.empl_education.Квалификация;
            obraz2NameDoc.Text = AddEmployeeClass.empl_education.ВО_Наименование_документа_об_образовании;
            obraz2Seriya.Text = AddEmployeeClass.empl_education.ВОСерия;
            obraz2Nomer.Text = AddEmployeeClass.empl_education.ВОНомер;
            obraz2Tipobraz.Text = AddEmployeeClass.empl_education.ВОТип_образования;
            obraz2NameUchebZav.Text = AddEmployeeClass.empl_education.ВОНаименование_учебного_заведения;
            obraz2Specialnost.Text = AddEmployeeClass.empl_education.ВОСпециальность;
            obraz2kvalifikaciya.Text = AddEmployeeClass.empl_education.ВОКвалификация;
            PosleObrazNaimenov.Text = AddEmployeeClass.empl_education.ПОНаименование;
            PosleObrazNomerDoc.Text = AddEmployeeClass.empl_education.ПОДокумент_;
            PosleObrazvidavshiyorgan.Text = AddEmployeeClass.empl_education.C_ПОВыдавший_орган;
            PosleObrazUchStepen.Text = AddEmployeeClass.empl_education.C_ПОУченая_степень;
            PosleObrazNapravleniye.Text = AddEmployeeClass.empl_education.ПОНаправление_по_диплому;
            if (AddEmployeeClass.empl_education.Дата_окончания.ToString() != "01.01.0001 0:00:00")
                obrazdataokonch.Text = AddEmployeeClass.empl_education.Дата_окончания.ToString();
            if (AddEmployeeClass.empl_education.ВОДата_окончания.ToString() != "01.01.0001 0:00:00")
                obraz2dataokonchaniya.Text = AddEmployeeClass.empl_education.ВОДата_окончания.ToString();
            if (AddEmployeeClass.empl_education.C_ПОДата_выдачи.ToString() != "01.01.0001 0:00:00")
                PosleObrazdatavidachi.Text = AddEmployeeClass.empl_education.C_ПОДата_выдачи.ToString();
        }

        private void textBox_to_AddEmployeeClass()
        {
            AddEmployeeClass.empl_education.Наименование_документа_об_образовании = obrazNameDoc.Text;
            AddEmployeeClass.empl_education.Серия = ObrazSeriya.Text;
            AddEmployeeClass.empl_education.Номер = obraznomer.Text;
            AddEmployeeClass.empl_education.Тип_образования = obraztipobrazov.Text;
            AddEmployeeClass.empl_education.Наименование_учебного_заведения = obrazNaimenovUchebZav.Text;
            AddEmployeeClass.empl_education.Специальность = obrazSpecialnost.Text;
            AddEmployeeClass.empl_education.Квалификация = obrazKvalifikac.Text;
            AddEmployeeClass.empl_education.ВО_Наименование_документа_об_образовании = obraz2NameDoc.Text;
            AddEmployeeClass.empl_education.ВОСерия = obraz2Seriya.Text;
            AddEmployeeClass.empl_education.ВОНомер = obraz2Nomer.Text;
            AddEmployeeClass.empl_education.ВОТип_образования = obraz2Tipobraz.Text;
            AddEmployeeClass.empl_education.ВОНаименование_учебного_заведения = obraz2NameUchebZav.Text;
            AddEmployeeClass.empl_education.ВОСпециальность = obraz2Specialnost.Text;
            AddEmployeeClass.empl_education.ВОКвалификация = obraz2kvalifikaciya.Text;
            AddEmployeeClass.empl_education.ПОНаименование = PosleObrazNaimenov.Text;
            AddEmployeeClass.empl_education.ПОДокумент_ = PosleObrazNomerDoc.Text;
            AddEmployeeClass.empl_education.C_ПОВыдавший_орган = PosleObrazvidavshiyorgan.Text;
            AddEmployeeClass.empl_education.C_ПОУченая_степень = PosleObrazUchStepen.Text;
            AddEmployeeClass.empl_education.ПОНаправление_по_диплому = PosleObrazNapravleniye.Text;
            if (obrazdataokonch.Text != "")
                AddEmployeeClass.empl_education.Дата_окончания = Convert.ToDateTime(obrazdataokonch.Text);
            else
                AddEmployeeClass.empl_education.Дата_окончания = Convert.ToDateTime("01.01.0001 0:00:00");
            if (obraz2dataokonchaniya.Text != "")
                AddEmployeeClass.empl_education.ВОДата_окончания = Convert.ToDateTime(obraz2dataokonchaniya.Text);
            else
                AddEmployeeClass.empl_education.ВОДата_окончания = Convert.ToDateTime("01.01.0001 0:00:00");
            if (PosleObrazdatavidachi.Text != "")
                AddEmployeeClass.empl_education.C_ПОДата_выдачи = Convert.ToDateTime(PosleObrazdatavidachi.Text);
            else
                AddEmployeeClass.empl_education.C_ПОДата_выдачи = Convert.ToDateTime("01.01.0001 0:00:00");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox_to_AddEmployeeClass();
            Manager.MainFrame.Navigate(new PageAddEmployee4());
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            textBox_to_AddEmployeeClass();
            Manager.MainFrame.Navigate(new PageAddEmployee2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddEmployeeClass.employee = null;
            AddEmployeeClass.Clear_variables();
            Manager.MainFrame.Navigate(new Page1());
        }
    }
}
