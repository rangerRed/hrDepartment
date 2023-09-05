using System;
using System.Data.Entity.Validation;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для PageAddEmployee4.xaml
    /// </summary>
    public partial class PageAddEmployee4 : Page
    {
        public PageAddEmployee4()
        {
            InitializeComponent();
            TDDatapriyomanarab.Text = (AddEmployeeClass.employee.Дата_приема_на_работу.ToString() == "01.01.0001 0:00:00") ? "" : AddEmployeeClass.employee.Дата_приема_на_работу.ToString();
            TDDoljnost.Text = AddEmployeeClass.employee.Должность;
            TDNomerDogov.Text = AddEmployeeClass.empl_activity.C__договора;
            TDnomerprikaza.Text = Convert.ToString(AddEmployeeClass.empl_activity.C__приказа);
            TDtipmestaraboti.Text = AddEmployeeClass.empl_activity.Тип_места_работы;
            TDstazhRabotiObshiy.Text = AddEmployeeClass.empl_activity.Стаж_работы_общий;
            TDStazhNaPredpriyatii.Text = AddEmployeeClass.empl_activity.Стаж_работы_на_предприятии;
            TDStazhStrahovoy.Text = AddEmployeeClass.empl_activity.Стаж_работы_страховой;
            SVUNomerVUS.Text = AddEmployeeClass.empl_military_registration.Номер_ВУС;
            SVUVUS.Text = AddEmployeeClass.empl_military_registration.Военно_учетная_специальность;
            SVUvoinskoeZvanie.Text = AddEmployeeClass.empl_military_registration.Воинское_звание;
            SVUkategoriyaZapasa.Text = AddEmployeeClass.empl_military_registration.Категория_запаса;
            SVUSostav.Text = AddEmployeeClass.empl_military_registration.Состав;
            SVUKategoriyaGodn.Text = AddEmployeeClass.empl_military_registration.Категория_годности;
            SVUKomissariat.Text = AddEmployeeClass.empl_military_registration.Коммисариат;
            SVUObshiyUchet.Text = AddEmployeeClass.empl_military_registration.Общий_учет;
            SVUSpecUchet.Text = AddEmployeeClass.empl_military_registration.Спец_учет;
            SVUOtmetkaoSnyatii.Text = AddEmployeeClass.empl_military_registration.Отметка_о_снятии;
            TDoklad.Text = (AddEmployeeClass.empl_activity.Оклад == 0.0) ? "" : Convert.ToString(AddEmployeeClass.empl_activity.Оклад);
            TDnadbavkaPROC.Text = (AddEmployeeClass.empl_activity.Надбавка == 0.0)? "" : Convert.ToString(AddEmployeeClass.empl_activity.Надбавка);
            TDVsegoRub.Text = (AddEmployeeClass.empl_activity.Всего_рублей == 0.0)? "" : Convert.ToString(AddEmployeeClass.empl_activity.Всего_рублей);
            TDokladSNadbavkoy.Text = (AddEmployeeClass.empl_activity.Оклад_с_надбавкой == 0.0)? "" : Convert.ToString(AddEmployeeClass.empl_activity.Оклад_с_надбавкой);
            TDKTU.Text = (AddEmployeeClass.empl_activity.КТУ == 0.0)? "" : Convert.ToString(AddEmployeeClass.empl_activity.КТУ);
            TDStavkaPROC.Text = (AddEmployeeClass.empl_activity.Ставка == 0.0)? "" : Convert.ToString(AddEmployeeClass.empl_activity.Ставка);
            if (AddEmployeeClass.empl_activity.Состоит_в_профсюзе == true)
                TDYes.IsChecked = true;
            else
                TDNo.IsChecked = true;
            if (AddEmployeeClass.employee.Дата_приема_на_работу.ToString() != "01.01.0001 0:00:00")
                TDDatapriyomanarab.Text = AddEmployeeClass.empl_activity.Дата_приема_на_работу.ToString();
            if (AddEmployeeClass.empl_activity.Дата_договора.ToString() != "01.01.0001 0:00:00")
                TDdataDogov.Text = AddEmployeeClass.empl_activity.Дата_договора.ToString();
            if (AddEmployeeClass.empl_activity.Дата_приказа.ToString() != "01.01.0001 0:00:00")
                TDdataprikaza.Text = AddEmployeeClass.empl_activity.Дата_приказа.ToString();
            if (AddEmployeeClass.empl_activity.Срок_договора.ToString() != "01.01.0001 0:00:00")
                TDsrokdogovora.Text = AddEmployeeClass.empl_activity.Срок_договора.ToString();
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            using (var db = new HR_DepartmentEntities())
            {

                try
                {
                    bool if_res = !AddEmployeeClass.add;
                    // Добавление записи в таблицу "Сотрудник"
                    var tableSotr = new Сотрудник();
                    if (if_res) // если это изменение то true
                    {
                        tableSotr = db.Сотрудник.Find(AddEmployeeClass.id_employee2);
                    }
                    else
                    {
                        tableSotr.Табельный_номер = AddEmployeeClass.id_employee;
                    }
                
                    tableSotr.Фамилия = AddEmployeeClass.employee.Фамилия;
                    tableSotr.Имя = AddEmployeeClass.employee.Имя;
                    tableSotr.Отчество = AddEmployeeClass.employee.Отчество;
                    tableSotr.Дата_рождения = AddEmployeeClass.employee.Дата_рождения;
                    tableSotr.Пол = AddEmployeeClass.employee.Пол;
                    tableSotr.Отдел = AddEmployeeClass.employee.Отдел;
                    tableSotr.Должность = AddEmployeeClass.employee.Должность;
                    tableSotr.Кабинет = AddEmployeeClass.employee.Кабинет;
                    tableSotr.Телефон_домашний = AddEmployeeClass.employee.Телефон_домашний;
                    tableSotr.Телефон_рабочий = AddEmployeeClass.employee.Телефон_рабочий;
                    tableSotr.Телефон_мобильный = AddEmployeeClass.employee.Телефон_мобильный;
                    tableSotr.Дата_приема_на_работу = AddEmployeeClass.employee.Дата_приема_на_работу;
                    tableSotr.ИНН = AddEmployeeClass.employee.ИНН;
                    tableSotr.СНИЛС = AddEmployeeClass.employee.СНИЛС;
                    tableSotr.C__мед_полиса = AddEmployeeClass.employee.C__мед_полиса;
                    tableSotr.E_mail = AddEmployeeClass.employee.E_mail;
                    tableSotr.Национальность = AddEmployeeClass.employee.Национальность;
                    tableSotr.Гражданство = AddEmployeeClass.employee.Гражданство;
                    tableSotr.Место_рождения = AddEmployeeClass.employee.Место_рождения;
                    tableSotr.Семейное_положение = AddEmployeeClass.employee.Семейное_положение;
                    if (AddEmployeeClass.path_image != null)
                    {
                        tableSotr.название_фото = AddEmployeeClass.image_name;
                    }
                    if (!if_res)
                    {
                        db.Сотрудник.Add(tableSotr);
                    }

                    // Добавление записи в таблицу "Паспортные данныеСот"
                    var tabPasport = new Паспортные_данныеСот();
                    if (if_res)
                    {
                        tabPasport = db.Паспортные_данныеСот.Find(AddEmployeeClass.empl_passport.id);
                    tabPasport.Код_сотрудника = AddEmployeeClass.id_employee2;
                    }
                    else
                    {
                        tabPasport.Код_сотрудника = AddEmployeeClass.id_employee;
                    }

                
                    tabPasport.Серия_паспорта = AddEmployeeClass.empl_passport.Серия_паспорта;
                    tabPasport.Номер_паспорта = AddEmployeeClass.empl_passport.Номер_паспорта;
                    tabPasport.Кем_выдан = AddEmployeeClass.empl_passport.Кем_выдан;
                    tabPasport.Дата_выдачи = AddEmployeeClass.empl_passport.Дата_выдачи;
                    tabPasport.Код_подразделения = AddEmployeeClass.empl_passport.Код_подразделения;
                    tabPasport.Срок_действия = AddEmployeeClass.empl_passport.Срок_действия;
                    tabPasport.МРДата_регистрации = AddEmployeeClass.empl_passport.МРДата_регистрации;
                    tabPasport.МРСрок_действия_до = AddEmployeeClass.empl_passport.МРСрок_действия_до;
                    tabPasport.МРСтрана = AddEmployeeClass.empl_passport.МРСтрана;
                    tabPasport.МРРегион = AddEmployeeClass.empl_passport.МРРегион;
                    tabPasport.МРПочтовый_индекс = AddEmployeeClass.empl_passport.МРПочтовый_индекс;
                    tabPasport.МРГород = AddEmployeeClass.empl_passport.МРГород;
                    tabPasport.МР_Улица = AddEmployeeClass.empl_passport.МР_Улица;
                    tabPasport.МРДом = AddEmployeeClass.empl_passport.МРДом;
                    tabPasport.МРКорпус = AddEmployeeClass.empl_passport.МРКорпус;
                    tabPasport.МРКвартира = AddEmployeeClass.empl_passport.МРКвартира;
                    tabPasport.ФПДата_регистрации = AddEmployeeClass.empl_passport.ФПДата_регистрации;
                    tabPasport.ФПСрок_действия_до = AddEmployeeClass.empl_passport.ФПСрок_действия_до;
                    tabPasport.ФПСтрана = AddEmployeeClass.empl_passport.ФПСтрана;
                    tabPasport.ФПРегион = AddEmployeeClass.empl_passport.ФПРегион;
                    tabPasport.ФППочтовый_индекс = AddEmployeeClass.empl_passport.ФППочтовый_индекс;
                    tabPasport.ФПГород = AddEmployeeClass.empl_passport.ФПГород;
                    tabPasport.ФП_Улица = AddEmployeeClass.empl_passport.ФП_Улица;
                    tabPasport.ФПДом = AddEmployeeClass.empl_passport.ФПДом;
                    tabPasport.ФПКорпус = AddEmployeeClass.empl_passport.ФПКорпус;
                    tabPasport.ФПКвартира = AddEmployeeClass.empl_passport.ФПКвартира;
                    tabPasport.ЗПСерия = AddEmployeeClass.empl_passport.ЗПСерия;
                    tabPasport.ЗПНомер = AddEmployeeClass.empl_passport.ЗПНомер;
                    tabPasport.ЗПДата_выдачи = AddEmployeeClass.empl_passport.ЗПДата_выдачи;
                    tabPasport.ЗПВыдавший_орган = AddEmployeeClass.empl_passport.ЗПВыдавший_орган;
                    tabPasport.ЗПСрок_действия_до = AddEmployeeClass.empl_passport.ЗПСрок_действия_до;
                    tabPasport.ВУСерия = AddEmployeeClass.empl_passport.ВУСерия;
                    tabPasport.ВУНомер = AddEmployeeClass.empl_passport.ВУНомер;
                    tabPasport.ВУСрок_действия_до = AddEmployeeClass.empl_passport.ВУСрок_действия_до;

                    if (!if_res)
                        {
                            db.Паспортные_данныеСот.Add(tabPasport);
                        }
                        // Добавление записи в таблицу "ОбразованиеСот"
                        var tabObraz = new ОбразовниеСот();
                    if (if_res)
                    {
                        tabObraz = db.ОбразовниеСот.Find(AddEmployeeClass.empl_education.ID_диплома);

                        tabObraz.Код_сотрудника = AddEmployeeClass.id_employee2;
                    }
                    else
                    {
                        tabObraz.Код_сотрудника = AddEmployeeClass.id_employee;
                    }
                    tabObraz.Наименование_документа_об_образовании = AddEmployeeClass.empl_education.Наименование_документа_об_образовании;
                    tabObraz.Серия = AddEmployeeClass.empl_education.Серия;
                    tabObraz.Номер = AddEmployeeClass.empl_education.Номер;
                    tabObraz.Тип_образования = AddEmployeeClass.empl_education.Тип_образования;
                    tabObraz.Наименование_учебного_заведения = AddEmployeeClass.empl_education.Наименование_учебного_заведения;
                    tabObraz.Специальность = AddEmployeeClass.empl_education.Специальность;
                    tabObraz.Квалификация = AddEmployeeClass.empl_education.Квалификация;
                    tabObraz.Дата_окончания = AddEmployeeClass.empl_education.Дата_окончания;
                    tabObraz.ВО_Наименование_документа_об_образовании = AddEmployeeClass.empl_education.ВО_Наименование_документа_об_образовании;
                    tabObraz.ВОСерия = AddEmployeeClass.empl_education.ВОСерия;
                    tabObraz.ВОНомер = AddEmployeeClass.empl_education.ВОНомер;
                    tabObraz.ВОТип_образования = AddEmployeeClass.empl_education.ВОТип_образования;
                    tabObraz.ВОНаименование_учебного_заведения = AddEmployeeClass.empl_education.ВОНаименование_учебного_заведения;
                    tabObraz.ВОСпециальность = AddEmployeeClass.empl_education.ВОСпециальность;
                    tabObraz.ВОКвалификация = AddEmployeeClass.empl_education.ВОКвалификация;
                    tabObraz.ВОДата_окончания = AddEmployeeClass.empl_education.ВОДата_окончания;
                    tabObraz.ПОНаименование = AddEmployeeClass.empl_education.ПОНаименование;
                    tabObraz.ПОДокумент_ = AddEmployeeClass.empl_education.ПОДокумент_;
                    tabObraz.C_ПОДата_выдачи = AddEmployeeClass.empl_education.C_ПОДата_выдачи;
                    tabObraz.C_ПОВыдавший_орган = AddEmployeeClass.empl_education.C_ПОВыдавший_орган;
                    tabObraz.C_ПОУченая_степень = AddEmployeeClass.empl_education.C_ПОУченая_степень;
                    tabObraz.ПОНаправление_по_диплому = AddEmployeeClass.empl_education.ПОНаправление_по_диплому;

                    if (!if_res) { 
                        db.ОбразовниеСот.Add(tabObraz);
                    }
                    // добавление в таблицу "Трудовая деятельность"
                    var tabTrudov = new Трудовая_деятельность();
                    if (if_res)
                    {
                        tabTrudov = db.Трудовая_деятельность.Find(AddEmployeeClass.empl_activity.id);
                        tabTrudov.Код_сотрудника = AddEmployeeClass.id_employee2;
                    }
                    else
                    {
                        tabTrudov.Код_сотрудника = AddEmployeeClass.id_employee;
                    }
                    tabTrudov.Дата_приема_на_работу = (TDDatapriyomanarab.Text != "") ? Convert.ToDateTime(TDDatapriyomanarab.Text) : Convert.ToDateTime("01.01.0001 0:00:00");
                    tabTrudov.Должность = TDDoljnost.Text;
                    tabTrudov.C__договора = TDNomerDogov.Text;
                    tabTrudov.C__приказа = TDnomerprikaza.Text;
                    tabTrudov.Дата_договора = (TDdataDogov.Text != "") ? Convert.ToDateTime(TDdataDogov.Text) : Convert.ToDateTime("01.01.0001 0:00:00");
                    tabTrudov.Дата_приказа = (TDdataprikaza.Text != "") ? Convert.ToDateTime(TDdataprikaza.Text) : Convert.ToDateTime("01.01.0001 0:00:00");
                    tabTrudov.Срок_договора = (TDsrokdogovora.Text != "") ? Convert.ToDateTime(TDsrokdogovora.Text) : Convert.ToDateTime("01.01.0001 0:00:00");
                    tabTrudov.Тип_места_работы = TDtipmestaraboti.Text;
                    tabTrudov.Оклад = (TDoklad.Text != "") ? Convert.ToDouble(TDoklad.Text) : 0.0;
                    tabTrudov.Надбавка = (TDnadbavkaPROC.Text != "") ? Convert.ToDouble(TDnadbavkaPROC.Text) : 0.0;
                    tabTrudov.Всего_рублей = (TDVsegoRub.Text != "") ? Convert.ToDouble(TDVsegoRub.Text) : 0.0;
                    tabTrudov.Оклад_с_надбавкой = (TDokladSNadbavkoy.Text != "") ? Convert.ToDouble(TDokladSNadbavkoy.Text) : 0.0;
                    tabTrudov.КТУ = (TDKTU.Text != "") ? Convert.ToDouble(TDKTU.Text) : 0.0;
                    tabTrudov.Ставка = (TDStavkaPROC.Text != "") ? Convert.ToDouble(TDStavkaPROC.Text) : 0.0;
                    tabTrudov.Стаж_работы_общий = TDstazhRabotiObshiy.Text;
                    tabTrudov.Стаж_работы_страховой = TDStazhStrahovoy.Text;
                    tabTrudov.Стаж_работы_на_предприятии = TDStazhNaPredpriyatii.Text;
                    tabTrudov.Состоит_в_профсюзе = TDYes.IsChecked;
                    if (!if_res) {
                        db.Трудовая_деятельность.Add(tabTrudov);
                    }

                    // добавление в таблицу "Воинский учетСот"
                    var tabVoinsk = new Воинский_учетСот();
                    if (if_res)
                    {
                        tabVoinsk = db.Воинский_учетСот.Find(AddEmployeeClass.empl_military_registration.id);
                        tabVoinsk.Код_сотрудника = AddEmployeeClass.id_employee2;
                    }
                    else
                    {
                        tabVoinsk.Код_сотрудника = AddEmployeeClass.id_employee;
                    }
                    tabVoinsk.Номер_ВУС = SVUNomerVUS.Text;
                    tabVoinsk.Военно_учетная_специальность = SVUVUS.Text;
                    tabVoinsk.Воинское_звание = SVUvoinskoeZvanie.Text;
                    tabVoinsk.Категория_запаса = SVUkategoriyaZapasa.Text;
                    tabVoinsk.Состав = SVUSostav.Text;
                    tabVoinsk.Категория_годности = SVUKategoriyaGodn.Text;
                    tabVoinsk.Коммисариат = SVUKomissariat.Text;
                    tabVoinsk.Общий_учет = SVUObshiyUchet.Text;
                    tabVoinsk.Спец_учет = SVUSpecUchet.Text;
                    tabVoinsk.Отметка_о_снятии = SVUOtmetkaoSnyatii.Text;
                    if (!if_res) {
                        db.Воинский_учетСот.Add(tabVoinsk);
                    }


                    // добавление записи в трудовую книжку о приеме на работу
                    if (!if_res)
                    {
                        var eh = new Трудовая_книжка();
                        eh.Код_сотрудника = AddEmployeeClass.id_employee;
                        eh.Дата = DateTime.Now;
                        if (AddEmployeeClass.employee.Отдел != "" && AddEmployeeClass.employee.Должность != "")
                        {
                            StreamReader reader = new StreamReader(AddEmployeeClass.path_project + "\\Resources\\id_pp_eh.txt");
                            eh.C_пп = Convert.ToInt32(reader.ReadLine());
                            reader.Close();
                            StreamWriter writer = new StreamWriter(AddEmployeeClass.path_project + "\\Resources\\id_pp_eh.txt");
                            writer.WriteLine(++eh.C_пп);
                            writer.Close();
                            eh.Сведения_о_приеме_переводах_и_увольнении = "Зачисление в отдел " + AddEmployeeClass.employee.Отдел + " на должность " + AddEmployeeClass.employee.Должность;
                            eh.ОснованиеНаименование = "Приказ";
                            eh.ОснованиеДата = DateTime.Now;
                            eh.ОснованиеНомер = eh.C_пп + "-к";
                            eh.ОснованиеСерия = "";
                            eh.Вид_кадрового_мероприятия = "Прием";
                            eh.должность = AddEmployeeClass.employee.Должность;
                            eh.отдел = AddEmployeeClass.employee.Отдел;
                            eh.Статья_ФЗ_причины_при_увольнении = "";
                            eh.Пункт_ФЗ_причины_при_увольнении = "";
                            eh.выполняемая_функция_при_наличии_ = "";
                            eh.признак_отмены_записи = false;
                            eh.дата_отмены_записи = Convert.ToDateTime("01.01.0001 0:00:00");
                            eh.совместитель = false;
                            eh.работа_в_районах_крайнего_севера = "";
                            eh.UUID = "";
                            eh.С_даты = Convert.ToDateTime("01.01.0001 0:00:00");
                            eh.по_дату = Convert.ToDateTime("01.01.0001 0:00:00");
                            db.Трудовая_книжка.Add(eh);
                    }
                }
                    // допольнительные поля 
                    var tabFields = new дополнительные_поля();
                    if (if_res)
                    {
                        tabFields = db.дополнительные_поля.Find(AddEmployeeClass.fields.id);
                        tabFields.код_сотрудника = AddEmployeeClass.id_employee2;
                    }
                    else
                    {
                        tabFields.код_сотрудника = AddEmployeeClass.id_employee;
                    }
                    tabFields.алфавит = (AddEmployeeClass.fields.алфавит == null) ? "" : AddEmployeeClass.fields.алфавит;
                    tabFields.вредные_производственные_факторы = (AddEmployeeClass.fields.вредные_производственные_факторы == null) ? "" : AddEmployeeClass.fields.вредные_производственные_факторы;
                    tabFields.график_работы = (AddEmployeeClass.fields.график_работы == null) ? "" : AddEmployeeClass.fields.график_работы;
                    tabFields.длительность_отпуска = (AddEmployeeClass.fields.длительность_отпуска == null) ? "" : AddEmployeeClass.fields.длительность_отпуска;
                    tabFields.испытательный_срок = (AddEmployeeClass.fields.испытательный_срок == null) ? 0 : AddEmployeeClass.fields.испытательный_срок;
                    tabFields.квалификационная_категория = (AddEmployeeClass.fields.квалификационная_категория == null) ? "" : AddEmployeeClass.fields.квалификационная_категория;
                    tabFields.разряд = (AddEmployeeClass.fields.разряд == null) ? "" : AddEmployeeClass.fields.разряд;
                    tabFields.место_нахождение_служебного_помещения = (AddEmployeeClass.fields.место_нахождение_служебного_помещения == null) ? "" : AddEmployeeClass.fields.место_нахождение_служебного_помещения;
                    tabFields.обязанности = (AddEmployeeClass.fields.обязанности == null) ? "" : AddEmployeeClass.fields.обязанности;
                    tabFields.основание_приема_на_работу = (AddEmployeeClass.fields.основание_приема_на_работу == null) ? "" : AddEmployeeClass.fields.основание_приема_на_работу;
                    tabFields.продолжительность_недели = (AddEmployeeClass.fields.продолжительность_недели == null) ? "" : AddEmployeeClass.fields.продолжительность_недели;
                    tabFields.работник_подчиняется = (AddEmployeeClass.fields.работник_подчиняется == null) ? "" : AddEmployeeClass.fields.работник_подчиняется;
                    tabFields.режим_труда = (AddEmployeeClass.fields.режим_труда == null) ? "" : AddEmployeeClass.fields.режим_труда;
                    tabFields.характер_работы = (AddEmployeeClass.fields.характер_работы == null) ? "" : AddEmployeeClass.fields.характер_работы;
                    if (!if_res)
                    {
                        db.дополнительные_поля.Add(tabFields);
                    }

                    if (!if_res)
                    {
                        StreamWriter writer = new StreamWriter(AddEmployeeClass.path_project + "\\Resources\\IdEmployee.txt");
                        writer.WriteLine(++AddEmployeeClass.id_employee);
                        writer.Close();
                    }

                    try
                    {

                        db.SaveChanges();

                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                        {
                            MessageBox.Show("Object: " + validationError.Entry.Entity.ToString());

                            foreach (DbValidationError err in validationError.ValidationErrors)
                            {
                                MessageBox.Show(err.ErrorMessage + "");
                            }
                        }
                    }
                    finally
                    {
                        AddEmployeeClass.text_to_label = "Сотрудник добавлен";
                        if (if_res)
                        {
                            AddEmployeeClass.text_to_label = "Изменения сохранены";
                        }
                        Warning update = new Warning();
                        update.Show();
                        try // фото
                        {
                            if (AddEmployeeClass.path_image != null)
                            {
                                string path_image_from_disk = AddEmployeeClass.path_image.Replace("\\" + AddEmployeeClass.image_name, "");
                                string path_directory = AddEmployeeClass.path_project + "\\Image\\";
                                string sourceFile = Path.Combine(path_image_from_disk, AddEmployeeClass.image_name);
                                string destFile = Path.Combine(path_directory, AddEmployeeClass.image_name);
                                File.Copy(sourceFile, destFile, true);
                            }
                        }
                        catch (IOException ex)
                        {

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        AddEmployeeClass.employee = null;
                        AddEmployeeClass.Clear_variables();
                        Manager.MainFrame.Navigate(new Page1());

                    }

                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SeniorityCalculator seniority = new SeniorityCalculator();
            seniority.ShowDialog();
            try
            {
                TDstazhRabotiObshiy.Text = AddEmployeeClass.empl_activity.Стаж_работы_общий;
                TDStazhStrahovoy.Text = AddEmployeeClass.empl_activity.Стаж_работы_страховой;
                TDStazhNaPredpriyatii.Text = AddEmployeeClass.empl_activity.Стаж_работы_на_предприятии;
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox_to_AddEmployeeClass()
        {
            AddEmployeeClass.empl_activity.Должность = TDDoljnost.Text;
            AddEmployeeClass.empl_activity.C__договора = TDNomerDogov.Text;
            AddEmployeeClass.empl_activity.C__приказа = TDnomerprikaza.Text;
            AddEmployeeClass.empl_activity.Тип_места_работы = TDtipmestaraboti.Text;
            AddEmployeeClass.empl_activity.Оклад = (TDoklad.Text == "")? 0.0 : Convert.ToDouble(TDoklad.Text);
            AddEmployeeClass.empl_activity.Надбавка = (TDnadbavkaPROC.Text == "") ? 0.0 : Convert.ToDouble(TDnadbavkaPROC.Text);
            AddEmployeeClass.empl_activity.Всего_рублей = (TDVsegoRub.Text == "") ? 0.0 : Convert.ToDouble(TDVsegoRub.Text);
            AddEmployeeClass.empl_activity.Оклад_с_надбавкой = (TDokladSNadbavkoy.Text == "") ? 0.0 : Convert.ToDouble(TDokladSNadbavkoy.Text);
            AddEmployeeClass.empl_activity.КТУ = (TDKTU.Text == "") ? 0.0 : Convert.ToDouble(TDKTU.Text);
            AddEmployeeClass.empl_activity.Ставка = (TDStavkaPROC.Text == "") ? 0.0 : Convert.ToDouble(TDStavkaPROC.Text);
            AddEmployeeClass.empl_activity.Стаж_работы_общий = TDstazhRabotiObshiy.Text;
            AddEmployeeClass.empl_activity.Стаж_работы_страховой = TDStazhStrahovoy.Text;
            AddEmployeeClass.empl_activity.Стаж_работы_на_предприятии = TDStazhNaPredpriyatii.Text;

            if (TDYes.IsChecked == true)
                AddEmployeeClass.empl_activity.Состоит_в_профсюзе = true;
            else
                AddEmployeeClass.empl_activity.Состоит_в_профсюзе = false;
            AddEmployeeClass.empl_military_registration.Номер_ВУС = SVUNomerVUS.Text;
            AddEmployeeClass.empl_military_registration.Военно_учетная_специальность = SVUVUS.Text;
            AddEmployeeClass.empl_military_registration.Воинское_звание = SVUvoinskoeZvanie.Text;
            AddEmployeeClass.empl_military_registration.Категория_запаса = SVUkategoriyaZapasa.Text;
            AddEmployeeClass.empl_military_registration.Состав = SVUSostav.Text;
            AddEmployeeClass.empl_military_registration.Категория_годности = SVUKategoriyaGodn.Text;
            AddEmployeeClass.empl_military_registration.Коммисариат = SVUKomissariat.Text;
            AddEmployeeClass.empl_military_registration.Общий_учет =  SVUObshiyUchet.Text;
            AddEmployeeClass.empl_military_registration.Спец_учет = SVUSpecUchet.Text;
            AddEmployeeClass.empl_military_registration.Отметка_о_снятии = SVUOtmetkaoSnyatii.Text;
            if (TDDatapriyomanarab.Text != "")
                AddEmployeeClass.empl_activity.Дата_приема_на_работу = Convert.ToDateTime(TDDatapriyomanarab.Text);
            if (TDdataDogov.Text != "")
                AddEmployeeClass.empl_activity.Дата_договора = Convert.ToDateTime(TDdataDogov.Text);
            if (TDdataprikaza.Text != "")
                AddEmployeeClass.empl_activity.Дата_приказа = Convert.ToDateTime(TDdataprikaza.Text);
            if (TDsrokdogovora.Text != "")
                AddEmployeeClass.empl_activity.Срок_договора = Convert.ToDateTime(TDsrokdogovora.Text);
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            textBox_to_AddEmployeeClass();
            Manager.MainFrame.Navigate(new PageAddEmployee3());

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddEmployeeClass.employee = null;
            AddEmployeeClass.Clear_variables();
            Manager.MainFrame.Navigate(new Page1());
        }

        private void additional_fields(object sender, RoutedEventArgs e) // дополнительные поля
        {
            additional_fields_window _Window = new additional_fields_window();
            _Window.ShowDialog();
        }

        private void TDnadbavkaPROC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TDnadbavkaPROC.Text != "")
            {
                try
                {
                    double oklad = Convert.ToDouble(TDoklad.Text);
                    double proc = Convert.ToDouble(TDnadbavkaPROC.Text);
                    proc /= 100;
                    TDVsegoRub.Text = (oklad * proc).ToString();
                    TDokladSNadbavkoy.Text = (Convert.ToDouble(TDVsegoRub.Text) + oklad).ToString();
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                TDVsegoRub.Text = "";
                TDokladSNadbavkoy.Text = "";
            }
        }
    }
}
