using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;


namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для T2.xaml
    /// </summary>
    public partial class T2 : Window
    {
        public T2()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString();
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
            AddEmployeeClass.Clear_variables();
            Close();
        }

        private void print(object sender, RoutedEventArgs e)
        {
            var helper = new word_helper(AddEmployeeClass.path_project + "\\Docx\\Т-2.docx");

            using (var db = new HR_DepartmentEntities())
            {
                AddEmployeeClass.org = db.Информация_об_организации.Find(1);
                AddEmployeeClass.empl_activity = db.Трудовая_деятельность.FirstOrDefault(td => td.Код_сотрудника == AddEmployeeClass.employee.Табельный_номер);
                AddEmployeeClass.fields = db.дополнительные_поля.FirstOrDefault(f => f.код_сотрудника == AddEmployeeClass.employee.Табельный_номер);
                AddEmployeeClass.empl_education = db.ОбразовниеСот.FirstOrDefault(edu => edu.Код_сотрудника == AddEmployeeClass.employee.Табельный_номер);
                AddEmployeeClass.empl_passport = db.Паспортные_данныеСот.FirstOrDefault(pas => pas.Код_сотрудника == AddEmployeeClass.employee.Табельный_номер);
                AddEmployeeClass.empl_military_registration = db.Воинский_учетСот.FirstOrDefault(mr => mr.Код_сотрудника == AddEmployeeClass.employee.Табельный_номер);
            }
            int index = AddEmployeeClass.org.ФИО_работника_кадровой_службы.IndexOf(" ");
            int last_index = AddEmployeeClass.org.ФИО_работника_кадровой_службы.LastIndexOf(" ");
            string surname_sup = "";
            for (int i = 0; i < index; i++)
            {
                surname_sup += AddEmployeeClass.org.ФИО_работника_кадровой_службы[i];
            }
            string N = AddEmployeeClass.org.ФИО_работника_кадровой_службы[index + 1].ToString().ToUpper();
            string P = AddEmployeeClass.org.ФИО_работника_кадровой_службы[last_index + 1].ToString().ToUpper();
            
            var items = new Dictionary<string, string>
            {
                { "<окпо>", AddEmployeeClass.org.ОКПО },
                { "<полное название>", AddEmployeeClass.org.Полное_наименование },
                { "<дата составления>", date.Text },
                { "<табельный номер>", AddEmployeeClass.employee.Табельный_номер.ToString() },
                { "<мобильный телефон>", AddEmployeeClass.employee.Телефон_мобильный },
                { "<снилс>", AddEmployeeClass.employee.СНИЛС },
                { "<характер работы>", AddEmployeeClass.fields.характер_работы },
                { "<пол>", AddEmployeeClass.employee.Пол },
                { "<номер договора>", AddEmployeeClass.empl_activity.C__договора },
                { "<дата договора>", (AddEmployeeClass.empl_activity.Дата_договора.ToString() != "01.01.0001 0:00:00") ? AddEmployeeClass.empl_activity.Дата_договора.ToString().Replace(" 0:00:00", "") : "" },
                { "<фамилия>", AddEmployeeClass.employee.Фамилия },
                { "<имя>", AddEmployeeClass.employee.Имя },
                { "<отчество>", AddEmployeeClass.employee.Отчество },
                { "<дата рождения>", (AddEmployeeClass.employee.Дата_рождения.ToString() != "01.01.0001 0:00:00") ? AddEmployeeClass.employee.Дата_рождения.ToString().Replace("0:00:00", "") : "" },
                { "<место рождения>", AddEmployeeClass.employee.Место_рождения },
                { "<гражданство>", AddEmployeeClass.employee.Гражданство },
                { "<тип образования>", AddEmployeeClass.empl_education.Тип_образования },
                { "<наименование учебного заведения>", AddEmployeeClass.empl_education.Наименование_учебного_заведения },
                { "<серияДок>", AddEmployeeClass.empl_education.Серия },
                { "<номерДок>", AddEmployeeClass.empl_education.Номер },
                { "<год окончания>", AddEmployeeClass.empl_education.Дата_окончания.Value.Year.ToString() },
                { "<квалификация>", AddEmployeeClass.empl_education.Квалификация },
                { "<направление или специальность>", AddEmployeeClass.empl_education.Специальность },
                { "<наименование учебного заведения2>", AddEmployeeClass.empl_education.ВОНаименование_учебного_заведения },
                { "<наименование документа2>", AddEmployeeClass.empl_education.ВО_Наименование_документа_об_образовании },
                { "<серияДок2>", AddEmployeeClass.empl_education.ВОСерия },
                { "<номерДок2>", AddEmployeeClass.empl_education.ВОНомер },
                { "<год окончания2>", AddEmployeeClass.empl_education.ВОДата_окончания.Value.Year.ToString() },
                { "<квалификация2>", AddEmployeeClass.empl_education.ВОКвалификация },
                { "<направление или специальность2>", AddEmployeeClass.empl_education.ВОСпециальность },
                { "<ПО наименование>", AddEmployeeClass.empl_education.ПОНаименование },
                { "<ПО наименование выдавшего органа >", AddEmployeeClass.empl_education.C_ПОВыдавший_орган },
                { "<ПО домер документа>", AddEmployeeClass.empl_education.ПОДокумент_ },
                { "<ПО дата выдачи>", (AddEmployeeClass.empl_education.C_ПОДата_выдачи.ToString() != "01.01.0001 0:00:00") ? AddEmployeeClass.empl_education.C_ПОДата_выдачи.ToString().Replace(" 0:00:00", "") : "" },
                { "<ПО дата выдачи год>", AddEmployeeClass.empl_education.C_ПОДата_выдачи.Value.Year.ToString() },
                { "<ПО направление или специальность>", AddEmployeeClass.empl_education.ПОНаправление_по_диплому },
                { "<стаж работы общий>", AddEmployeeClass.empl_activity.Стаж_работы_общий },
                { "<семейное положение>", AddEmployeeClass.employee.Семейное_положение },
                { "<паспорт серия> ", AddEmployeeClass.empl_passport.Серия_паспорта + " " },
                { "<паспорт номер>", AddEmployeeClass.empl_passport.Номер_паспорта },
                { "<паспорт дата выдачи>", (AddEmployeeClass.empl_passport.Дата_выдачи.ToString() != "01.01.0001 0:00:00") ? AddEmployeeClass.empl_passport.Дата_выдачи.ToString().Replace(" 0:00:00", "") : "" },
                { "<паспорт кем выдан>", AddEmployeeClass.empl_passport.Кем_выдан },
                { "<почтовый индекс>", AddEmployeeClass.empl_passport.МРПочтовый_индекс },
                { "<город>", AddEmployeeClass.empl_passport.МРГород },
                { "<улица>", AddEmployeeClass.empl_passport.МР_Улица },
                { "<дом>", AddEmployeeClass.empl_passport.МРДом },
                { "<корпус>", AddEmployeeClass.empl_passport.МРКорпус },
                { "<квартира>", AddEmployeeClass.empl_passport.МРКвартира },
                { "<почтовый индекс2>", AddEmployeeClass.empl_passport.ФППочтовый_индекс },
                { "<город2>", AddEmployeeClass.empl_passport.ФПГород },
                { "<улица2>", AddEmployeeClass.empl_passport.ФП_Улица },
                { "<дом2>", AddEmployeeClass.empl_passport.ФПДом },
                { "<корпус2>", AddEmployeeClass.empl_passport.ФПКорпус },
                { "<квартира2>", AddEmployeeClass.empl_passport.ФПКвартира },
                { "<дата регистрации МЖ>", (AddEmployeeClass.empl_passport.МРДата_регистрации.ToString() != "01.01.0001 0:00:00") ? AddEmployeeClass.empl_passport.МРДата_регистрации.ToString().Replace(" 0:00:00", "") : "" },
                { "<телефон домашний>", AddEmployeeClass.employee.Телефон_домашний },
                { "<категория запаса>", AddEmployeeClass.empl_military_registration.Категория_запаса },
                { "<воинское звание>", AddEmployeeClass.empl_military_registration.Воинское_звание },
                { "<состав>", AddEmployeeClass.empl_military_registration.Состав },
                { "<номер вус>", AddEmployeeClass.empl_military_registration.Номер_ВУС },
                { "<комиссариат>", AddEmployeeClass.empl_military_registration.Коммисариат },
                { "<учет общий>", AddEmployeeClass.empl_military_registration.Общий_учет },
                { "<категория годности>", AddEmployeeClass.empl_military_registration.Категория_годности },
                { "<специальный учет>", AddEmployeeClass.empl_military_registration.Спец_учет },
                { "<отметка о снятии>", AddEmployeeClass.empl_military_registration.Отметка_о_снятии },
                { "<должность кадровика>", AddEmployeeClass.org.Должность_работника_кадровой_службы },
                { "<фамилия инициалы кадровика>", surname_sup + " " + N + ". " + P + "." },
                { "<наименование документа>", AddEmployeeClass.empl_education.Наименование_документа_об_образовании },
                { "<ПОдокумент>", AddEmployeeClass.empl_education.ПОНаименование },
            };

            helper.Process(items);
            Close();
        }
    }
}
