using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows;


namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.None; // нет стиля у окна
        }


        private void MoveWindow(object sender, System.Windows.Input.MouseButtonEventArgs e) // перетаскивание окна
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

        private void Exit(object sender, System.Windows.Input.MouseButtonEventArgs e) // закрытие окна
        {
            Application.Current.Shutdown();
        }

        private void Login(object sender, RoutedEventArgs e) // вход в систему
        {
            try
            {
                using (var db = new HR_DepartmentEntities())
                {
                    var user = db.Login.FirstOrDefault(us => us.login1 == textBox_login.Text && us.password == textBox_password.Password); // поиск логина и пароля в базе
                    if (user == null)
                    {
                        AddEmployeeClass.text_to_label = "Введен неверный логин или пароль";
                        Warning warning = new Warning();
                        warning.Show();
                    }
                    else
                    {
                        GeneralWindow generalWindow = new GeneralWindow();
                        generalWindow.Show();
                        Hide();
                    }
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                AddEmployeeClass.text_to_label = ex.Message;
                Warning warning = new Warning();
                warning.Show();
            }
        }

        private void Minimize(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void passEmail(object sender, System.Windows.Input.MouseButtonEventArgs e) // звбыл пароль
        {
            try
            {
                var db = new HR_DepartmentEntities();
                var pas = HR_DepartmentEntities.GetContext().Login.ToList()[0];
                MailAddress from = new MailAddress("tagiev2017@mail.ru", "HR Department");
                MailAddress to = new MailAddress("yardofbeetles@mail.ru");
                MailMessage m = new MailMessage(from, to);
                m.Subject = "HR Department";
                m.Body = "Вот ваш логин: " + pas.login1 + " пароль " + pas.password;
                SmtpClient smtp = new SmtpClient("mail.ru", 25);
                smtp.Credentials = new NetworkCredential("tagiev2017@mail.ru", "return65quirelllds");
                smtp.EnableSsl = true;
                smtp.Send(m);
                AddEmployeeClass.text_to_label = "Письмо отправлено";
                Warning mail = new Warning();
                mail.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
