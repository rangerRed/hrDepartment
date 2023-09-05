using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;


namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для PageAddEmployee.xaml
    /// </summary>
    public partial class PageAddEmployee : Page
    {

        public PageAddEmployee(Сотрудник selectedEmployee)
        {
            InitializeComponent();
            if (AddEmployeeClass.add != true)
            {
                try
                {

                    // Выделение таблицы Сотрудник
                    //

                    Familiya.Text = AddEmployeeClass.employee.Фамилия;
                    Name.Text = AddEmployeeClass.employee.Имя;
                    Otchestvo.Text = AddEmployeeClass.employee.Отчество;
                    Sex.Text = AddEmployeeClass.employee.Пол;
                    otdel.Text = AddEmployeeClass.employee.Отдел;
                    doljnost.Text = AddEmployeeClass.employee.Должность;
                    Kabinet.Text = AddEmployeeClass.employee.Кабинет;
                    phoneHome.Text = AddEmployeeClass.employee.Телефон_домашний;
                    phoneWork.Text = AddEmployeeClass.employee.Телефон_рабочий;
                    mobilePhone.Text = AddEmployeeClass.employee.Телефон_мобильный;
                    INN.Text = AddEmployeeClass.employee.ИНН;
                    SNILS.Text = AddEmployeeClass.employee.СНИЛС;
                    NumMEDPOLIS.Text = AddEmployeeClass.employee.C__мед_полиса;
                    EMail.Text = AddEmployeeClass.employee.E_mail;
                    Nacionalnost.Text = AddEmployeeClass.employee.Национальность;
                    Grajdnstvo.Text = AddEmployeeClass.employee.Гражданство;
                    MestoRojdeniya.Text = AddEmployeeClass.employee.Место_рождения;
                    Semeynoepolojenie.Text = AddEmployeeClass.employee.Семейное_положение;

                    AddEmployeeClass.id_employee2 = AddEmployeeClass.employee.Табельный_номер;


                    if (AddEmployeeClass.employee.название_фото != null)
                    {
                        BitmapImage myBitmapImage = new BitmapImage();
                        myBitmapImage.BeginInit();
                        myBitmapImage.UriSource = new Uri(AddEmployeeClass.path_project + "\\Image\\" + AddEmployeeClass.employee.название_фото);
                        AddEmployeeClass.image_name = AddEmployeeClass.employee.название_фото;
                        AddEmployeeClass.path_image = AddEmployeeClass.path_project + "\\Image\\" + AddEmployeeClass.image_name;
                        myBitmapImage.DecodePixelWidth = 125;
                        myBitmapImage.EndInit();
                        photoEmployee.Source = myBitmapImage;
                    }
                    

                    VUSeria.Text = AddEmployeeClass.empl_passport.ВУСерия;
                    VUNumber.Text = AddEmployeeClass.empl_passport.ВУНомер;
                    if (AddEmployeeClass.employee.Дата_рождения.ToString() != "01.01.0001 0:00:00" && AddEmployeeClass.employee.Дата_рождения != null)
                    {
                        DateOfBirth.Text = AddEmployeeClass.employee.Дата_рождения.ToString();
                    }
                    if (AddEmployeeClass.employee.Дата_приема_на_работу.ToString() != "01.01.0001 0:00:00" && AddEmployeeClass.employee.Дата_приема_на_работу != null)
                    {
                        datetoWork.Text = AddEmployeeClass.employee.Дата_приема_на_работу.ToString();
                    }
                    if (AddEmployeeClass.empl_passport.ВУСрок_действия_до.ToString() != "01.01.0001 0:00:00" && AddEmployeeClass.empl_passport.ВУСрок_действия_до != null)
                    {
                        VUSrokdeystviya.Text = AddEmployeeClass.empl_passport.ВУСрок_действия_до.ToString();
                    }
                    
                }
                catch (System.InvalidCastException ex)
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Familiya.Text = AddEmployeeClass.employee.Фамилия;
                Name.Text = AddEmployeeClass.employee.Имя;
                Otchestvo.Text = AddEmployeeClass.employee.Отчество;
                Sex.Text = AddEmployeeClass.employee.Пол;
                otdel.Text = AddEmployeeClass.employee.Отдел;
                doljnost.Text = AddEmployeeClass.employee.Должность;
                Kabinet.Text = AddEmployeeClass.employee.Кабинет;
                phoneHome.Text = AddEmployeeClass.employee.Телефон_домашний;
                phoneWork.Text = AddEmployeeClass.employee.Телефон_рабочий;
                mobilePhone.Text = AddEmployeeClass.employee.Телефон_мобильный;
                INN.Text = AddEmployeeClass.employee.ИНН;
                SNILS.Text = AddEmployeeClass.employee.СНИЛС;
                NumMEDPOLIS.Text = AddEmployeeClass.employee.C__мед_полиса;
                EMail.Text = AddEmployeeClass.employee.E_mail;
                Nacionalnost.Text = AddEmployeeClass.employee.Национальность;
                Grajdnstvo.Text = AddEmployeeClass.employee.Гражданство;
                MestoRojdeniya.Text = AddEmployeeClass.employee.Место_рождения;
                Semeynoepolojenie.Text = AddEmployeeClass.employee.Семейное_положение;
                VUSeria.Text = AddEmployeeClass.empl_passport.ВУСерия;
                VUNumber.Text = AddEmployeeClass.empl_passport.ВУНомер;

                if (AddEmployeeClass.path_image != null)
                {
                    BitmapImage myBitmapImage = new BitmapImage();
                    myBitmapImage.BeginInit();
                    myBitmapImage.UriSource = new Uri(AddEmployeeClass.path_image);
                    myBitmapImage.DecodePixelWidth = 125;
                    myBitmapImage.EndInit();
                    photoEmployee.Source = myBitmapImage;
                }
                
                if (AddEmployeeClass.employee.Дата_рождения.ToString() != "01.01.0001 0:00:00")
                    DateOfBirth.Text = AddEmployeeClass.employee.Дата_рождения.ToString();
                if (AddEmployeeClass.empl_passport.ВУСрок_действия_до.ToString() != "01.01.0001 0:00:00")
                    VUSrokdeystviya.Text = AddEmployeeClass.empl_passport.ВУСрок_действия_до.ToString();
                if (AddEmployeeClass.employee.Дата_приема_на_работу.ToString() != "01.01.0001 0:00:00")
                    datetoWork.Text = AddEmployeeClass.employee.Дата_приема_на_работу.ToString();
            }
        }

        private void FileDialog(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Files JPG (*.jpg)|*.jpg|Files JPEG (*.jpeg)|*.jpeg|Files PNG (*.png)|*.png*";
            fdlg.FilterIndex = 3;
            fdlg.RestoreDirectory = true;
            fdlg.ShowDialog();
            
            try
            {
                BitmapImage myBitmapImage = new BitmapImage();
                myBitmapImage.BeginInit();
                myBitmapImage.UriSource = new Uri(fdlg.FileName);
                AddEmployeeClass.path_image = fdlg.FileName;
                int i = fdlg.FileName.LastIndexOf("\\");
                AddEmployeeClass.image_name = fdlg.FileName.Substring(i + 1);
                myBitmapImage.DecodePixelWidth = 125;
                myBitmapImage.EndInit();
                photoEmployee.Source = myBitmapImage;
            }
            catch (UriFormatException ex)
            {

            }
        }

        private void Show1(object sender, MouseButtonEventArgs e)
        {
            department department = new department();
            department.Show();
        }

        private void textBox_to_AddEmployeeClass()
        {
            if (AddEmployeeClass.add)
            {
                StreamReader reader = new StreamReader(AddEmployeeClass.path_project + "\\Resources\\IdEmployee.txt");
                AddEmployeeClass.id_employee = Convert.ToInt32(reader.ReadLine());
                reader.Close();
            }
            AddEmployeeClass.employee.Фамилия = Familiya.Text;
            AddEmployeeClass.employee.Имя = Name.Text;
            AddEmployeeClass.employee.Отчество = Otchestvo.Text;
            AddEmployeeClass.employee.Пол = Sex.Text;
            AddEmployeeClass.employee.Отдел = otdel.Text;
            AddEmployeeClass.employee.Должность = doljnost.Text;
            AddEmployeeClass.employee.Кабинет = Kabinet.Text;
            AddEmployeeClass.employee.Телефон_домашний = phoneHome.Text;
            AddEmployeeClass.employee.Телефон_рабочий = phoneWork.Text;
            AddEmployeeClass.employee.Телефон_мобильный = mobilePhone.Text;
            AddEmployeeClass.employee.ИНН = INN.Text;
            AddEmployeeClass.employee.СНИЛС = SNILS.Text;
            AddEmployeeClass.employee.C__мед_полиса = NumMEDPOLIS.Text;
            AddEmployeeClass.employee.E_mail = EMail.Text;
            AddEmployeeClass.employee.Национальность = Nacionalnost.Text;
            AddEmployeeClass.employee.Гражданство = Grajdnstvo.Text;
            AddEmployeeClass.employee.Место_рождения = MestoRojdeniya.Text;
            AddEmployeeClass.employee.Семейное_положение = Semeynoepolojenie.Text;
            AddEmployeeClass.empl_passport.ВУСерия = VUSeria.Text;
            AddEmployeeClass.empl_passport.ВУНомер = VUNumber.Text;

            if (DateOfBirth.Text != "")
                AddEmployeeClass.employee.Дата_рождения = Convert.ToDateTime(DateOfBirth.Text);
            else
                AddEmployeeClass.employee.Дата_рождения = Convert.ToDateTime("01.01.0001 0:00:00");
            if (VUSrokdeystviya.Text != "")
                AddEmployeeClass.empl_passport.ВУСрок_действия_до = Convert.ToDateTime(VUSrokdeystviya.Text);
            else
                AddEmployeeClass.empl_passport.ВУСрок_действия_до = Convert.ToDateTime("01.01.0001 0:00:00");
            if (datetoWork.Text != "")
                AddEmployeeClass.employee.Дата_приема_на_работу = Convert.ToDateTime(datetoWork.Text);
            else
                AddEmployeeClass.employee.Дата_приема_на_работу = Convert.ToDateTime("01.01.0001 0:00:00");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            textBox_to_AddEmployeeClass();
            Manager.MainFrame.Navigate(new PageAddEmployee2());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox_to_AddEmployeeClass();
            AddEmployeeClass.employee = null;
            Manager.MainFrame.Navigate(new Page1());

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddEmployeeClass.Clear_variables();
            AddEmployeeClass.employee = null;
            Manager.MainFrame.Navigate(new Page1());
        }
    }
}
