using System;
using System.Windows;
using System.Windows.Input;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для additional_fields_window.xaml
    /// </summary>
    public partial class additional_fields_window : Window
    {
        public additional_fields_window()
        {
            InitializeComponent();
            character_work.Text = AddEmployeeClass.fields.характер_работы;
            regim_trud.Text = AddEmployeeClass.fields.режим_труда;
            work_week.Text = AddEmployeeClass.fields.продолжительность_недели;
            graphik_rab.Text = AddEmployeeClass.fields.график_работы;
            srok.Text = (AddEmployeeClass.fields.испытательный_срок == 0) ? "" : AddEmployeeClass.fields.испытательный_срок.ToString();
            proiz_fak.Text = AddEmployeeClass.fields.вредные_производственные_факторы;
            osnovanie_priem.Text = AddEmployeeClass.fields.основание_приема_на_работу;
            razrad.Text = AddEmployeeClass.fields.разряд;
            kategory.Text = AddEmployeeClass.fields.квалификационная_категория;
            rabot_podch.Text = AddEmployeeClass.fields.работник_подчиняется;
            placement.Text = AddEmployeeClass.fields.место_нахождение_служебного_помещения;
            obazanosty.Text = AddEmployeeClass.fields.обязанности;
            dlit_otp.Text = AddEmployeeClass.fields.длительность_отпуска;
            alfa.Text = AddEmployeeClass.fields.алфавит;
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

        private void OK(object sender, RoutedEventArgs e)
        {
            AddEmployeeClass.fields.характер_работы = character_work.Text;
            AddEmployeeClass.fields.режим_труда = regim_trud.Text;
            AddEmployeeClass.fields.продолжительность_недели = work_week.Text;
            AddEmployeeClass.fields.график_работы = graphik_rab.Text;
            AddEmployeeClass.fields.испытательный_срок = (srok.Text != "") ? Convert.ToInt32(srok.Text) : 0;
            AddEmployeeClass.fields.вредные_производственные_факторы = proiz_fak.Text;
            AddEmployeeClass.fields.основание_приема_на_работу = osnovanie_priem.Text;
            AddEmployeeClass.fields.разряд = razrad.Text;
            AddEmployeeClass.fields.квалификационная_категория = kategory.Text;
            AddEmployeeClass.fields.работник_подчиняется = rabot_podch.Text;
            AddEmployeeClass.fields.место_нахождение_служебного_помещения = placement.Text;
            AddEmployeeClass.fields.обязанности = obazanosty.Text;
            AddEmployeeClass.fields.длительность_отпуска = dlit_otp.Text;
            AddEmployeeClass.fields.алфавит = alfa.Text;
            Close();
        }
    }
}
