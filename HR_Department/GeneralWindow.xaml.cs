using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для GeneralWindow.xaml
    /// </summary>
    public partial class GeneralWindow : Window
    {
        public GeneralWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Page1());
            Manager.MainFrame = MainFrame;
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            using (var db = new HR_DepartmentEntities()) // Информация об организации
            {
                var tb = db.Информация_об_организации.Find(1);
                AddEmployeeClass.short_name = tb.Краткое_название;
                AddEmployeeClass.full_name = tb.Полное_наименование;
                AddEmployeeClass.city = tb.Город;
                AddEmployeeClass.address = tb.Адрес;
                AddEmployeeClass.INN_organization = tb.ИНН;
                AddEmployeeClass.KPP = tb.КПП;
                AddEmployeeClass.calculation1 = tb.Расс__счет;
                AddEmployeeClass.calculation2 = tb.Корр__счет;
                AddEmployeeClass.OKPO = tb.ОКПО;
                AddEmployeeClass.OGRN = tb.ОГРН;
                AddEmployeeClass.number_PFR = tb.Рег__номер_в_ПФР;
                AddEmployeeClass.id_PFR = tb.Код_ТО_ПФР;
                AddEmployeeClass.banck = tb.В_банке;
                AddEmployeeClass.BIK_banck = tb.БИК_банка;
                AddEmployeeClass.FIO_employee_HR_department = tb.ФИО_работника_кадровой_службы;
                AddEmployeeClass.FIO_main_accountant = tb.ФИО_Главного_бухгалтера;
                AddEmployeeClass.FIO_supervisor = tb.ФИО_Руководителя;
                AddEmployeeClass.position_supervisor = tb.Должность_руководителя;
                AddEmployeeClass.position_employee_HR_department = tb.Должность_работника_кадровой_службы;
                AddEmployeeClass.phone_fax = tb.Телефон_факс;
                AddEmployeeClass.note = tb.Примечание;
            }

        }

        private void Exit(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        

        private void Minimize(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        public static ImageSource GetImageSource(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(ImageSourceProperty);
        }

        public static void SetImageSource(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(ImageSourceProperty, value);
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.RegisterAttached(
                "ImageSource", typeof(ImageSource), typeof(GeneralWindow),
                new PropertyMetadata(null));

        private void Frame_ContentRendered(object sender, EventArgs e)
        {
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            try {
                Manager.MainFrame.Navigate(new Page1());
            }
            catch(Exception ex)
            {

            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page2());
        }
    }
}
