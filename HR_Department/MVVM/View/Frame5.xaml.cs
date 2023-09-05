using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HR_Department.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для Frame5.xaml
    /// </summary>
    public partial class Frame5 : UserControl
    {
        public Frame5()
        {
            InitializeComponent();
            frame.Navigate(new PageFrame5_1());
        }
    }
}
