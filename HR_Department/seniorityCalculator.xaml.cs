using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для seniorityCalculator.xaml
    /// </summary>
    public partial class SeniorityCalculator : Window
    {
        public SeniorityCalculator()
        {
            InitializeComponent();
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

        private void But_add_Click(object sender, RoutedEventArgs e)
        {
            int id_datePICKs1 = 1, id_datePICKs2 = 1, id_chekboxV1 = 1, id_chekboxV3 = 1, id_chekboxV2 = 1;

            DatePicker datePicker1 = new DatePicker();
            datePicker1.Margin = new Thickness(109, 10, 0, 10);
            datePicker1.Name = "datePick1_" + (++id_datePICKs1);
            datePicker1.Width = 160;
            datePicker1.HorizontalAlignment = HorizontalAlignment.Left;

            DatePicker datePicker2 = new DatePicker();
            datePicker2.Margin = new Thickness(300, 14, 20, 14);
            datePicker2.Name = "datePick2_" + (++id_datePICKs2);
            datePicker2.Width = 160;
            datePicker2.HorizontalAlignment = HorizontalAlignment.Left;

            CheckBox box1 = new CheckBox();
            box1.Name = "V1_" + (++id_chekboxV1);
            box1.Margin = new Thickness(480, 15, 105, 15);

            CheckBox box2 = new CheckBox();
            box2.Name = "V2_" + (++id_chekboxV2);
            box2.Margin = new Thickness(510, 15, 75, 15);

            TextBlock tb1 = new TextBlock();
            tb1.Margin = new Thickness(484, 30, 100, 5);
            tb1.Text = "V1";

            TextBlock tb2 = new TextBlock();
            tb2.Margin = new Thickness(514, 30, 75, 5);
            tb2.Text = "V2";

            Grid grid = new Grid();
            grid.Children.Add(datePicker1);
            grid.Children.Add(datePicker2);
            grid.Children.Add(box1);
            grid.Children.Add(box2);
            grid.Children.Add(tb1);
            grid.Children.Add(tb2);
            MyPanel.Children.Add(grid);
            
        }

        public static T GetChildOfType<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj == null) return null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                var child = VisualTreeHelper.GetChild(depObj, i);

                var result = (child as T) ?? GetChildOfType<T>(child);
                if (result != null) return result;
            }
            return null;
        }

        private void save(object sender, RoutedEventArgs e)
        {
            try
            {
                TimeSpan dateTimeV1 = new TimeSpan();
                TimeSpan dateTimeV2 = new TimeSpan();
                TimeSpan dateTimeV3 = new TimeSpan();
                int yV1 = 0, mV1 = 0, dV1 = 0, iii = 0;
                int yV2 = 0, mV2 = 0, dV2 = 0;
                int yV3 = 0, mV3 = 0, dV3 = 0;
                while (0 != MyPanel.Children.Count)
                {
                    string spriem = Convert.ToString(GetChildOfType<DatePicker>(MyPanel));
                    GetChildOfType<Grid>(MyPanel).Children.RemoveAt(0);
                    string s2uvolnen = Convert.ToString(GetChildOfType<DatePicker>(MyPanel));
                    GetChildOfType<Grid>(MyPanel).Children.RemoveAt(0);
                    bool checkV1 = Convert.ToBoolean(GetChildOfType<CheckBox>(MyPanel).IsChecked);
                    GetChildOfType<Grid>(MyPanel).Children.RemoveAt(0);
                    bool checkV2 = Convert.ToBoolean(GetChildOfType<CheckBox>(MyPanel).IsChecked);
                    MyPanel.Children.RemoveAt(0);

                    DateTime tempdateTime1 = Convert.ToDateTime(spriem);
                    DateTime tempdateTime2 = Convert.ToDateTime(s2uvolnen);
                    TimeSpan span = tempdateTime2 - tempdateTime1;
                    dateTimeV1 += span;
                    if (checkV1 == true)
                    {
                        dateTimeV2 += span;
                    }
                    if (checkV2 == true)
                    {
                        dateTimeV3 += span;
                    }
                }
                iii = dateTimeV1.Days;
                yV1 = iii / 365;
                iii = iii % 365;
                mV1 = iii / 30;
                dV1 = iii % 30;
                if (dateTimeV2 != null)
                {
                    iii = dateTimeV2.Days;
                    yV2 = iii / 365;
                    iii = iii % 365;
                    mV2 = iii / 30;
                    dV2 = iii % 30;
                }
                if (dateTimeV3 != null)
                {
                    iii = dateTimeV3.Days;
                    yV3 = iii / 365;
                    iii = iii % 365;
                    mV3 = iii / 30;
                    dV3 = iii % 30;
                }

                AddEmployeeClass.empl_activity.Стаж_работы_общий = yV1 + " лет " + mV1 + " месяцев " + dV1 + " дней";
                AddEmployeeClass.empl_activity.Стаж_работы_страховой = yV2 + " лет " + mV2 + " месяцев " + dV2 + " дней";
                AddEmployeeClass.empl_activity.Стаж_работы_на_предприятии = yV3 + " лет " + mV3 + " месяцев " + dV3 + " дней";

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_stazh(object sender, RoutedEventArgs e)
        {
            try {
                MyPanel.Children.RemoveAt(MyPanel.Children.Count - 1);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
