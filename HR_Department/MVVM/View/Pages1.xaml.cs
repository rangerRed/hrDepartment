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
    /// Логика взаимодействия для Pages1.xaml
    /// </summary>
    public partial class Pages1 : UserControl
    {
        public Pages1()
        {
            InitializeComponent();
            frame1.Navigate(new Page1());
            frame3.Navigate(new Page2());
        }
        
    }
}
