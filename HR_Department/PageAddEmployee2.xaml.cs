using System;
using System.Windows;
using System.Windows.Controls;

namespace HR_Department
{
    /// <summary>
    /// Логика взаимодействия для PageAddEmployee2.xaml
    /// </summary>
    public partial class PageAddEmployee2 : Page
    {
        public PageAddEmployee2()
        {
            InitializeComponent();
            OPSeria.Text = AddEmployeeClass.empl_passport.Серия_паспорта;
            OPNomer.Text = AddEmployeeClass.empl_passport.Номер_паспорта;
            OPVidavshiyOrg.Text = AddEmployeeClass.empl_passport.Кем_выдан;
            OPKodPodrazd.Text = AddEmployeeClass.empl_passport.Код_подразделения;
            MRStrana.Text = AddEmployeeClass.empl_passport.МРСтрана;
            MRRegion.Text = AddEmployeeClass.empl_passport.МРРегион;
            MRPochtoviyIndex.Text = AddEmployeeClass.empl_passport.МРПочтовый_индекс;
            MRGorod.Text = AddEmployeeClass.empl_passport.МРГород;
            MRUlica.Text = AddEmployeeClass.empl_passport.МР_Улица;
            MRDom.Text = AddEmployeeClass.empl_passport.МРДом;
            MRKorpus.Text = AddEmployeeClass.empl_passport.МРКорпус;
            MRKvartira.Text = AddEmployeeClass.empl_passport.МРКвартира;
            MFPstrana.Text = AddEmployeeClass.empl_passport.ФПСтрана;
            MFPregion.Text = AddEmployeeClass.empl_passport.ФПРегион;
            MFPpochtoviyindex.Text = AddEmployeeClass.empl_passport.ФППочтовый_индекс;
            MFPgorod.Text = AddEmployeeClass.empl_passport.ФПГород;
            MFPulica.Text = AddEmployeeClass.empl_passport.ФП_Улица;
            MFPdom.Text = AddEmployeeClass.empl_passport.ФПДом;
            MFPkorpus.Text = AddEmployeeClass.empl_passport.ФПКорпус;
            MFPkvartira.Text = AddEmployeeClass.empl_passport.ФПКвартира;
            ZPseriya.Text = AddEmployeeClass.empl_passport.ЗПСерия;
            ZPnomer.Text = AddEmployeeClass.empl_passport.ЗПНомер;
            ZPvidavshiyorgan.Text = AddEmployeeClass.empl_passport.ЗПВыдавший_орган;
            check_MF.IsChecked = AddEmployeeClass.check1;
            if (AddEmployeeClass.empl_passport.Дата_выдачи.ToString() != "01.01.0001 0:00:00")
                OPDataVidachi.Text = AddEmployeeClass.empl_passport.Дата_выдачи.ToString();
            if (AddEmployeeClass.empl_passport.Срок_действия.ToString() != "01.01.0001 0:00:00")
                OPSrokDeyst.Text = AddEmployeeClass.empl_passport.Срок_действия.ToString();
            if (AddEmployeeClass.empl_passport.МРДата_регистрации.ToString() != "01.01.0001 0:00:00")
                MRDataregistr.Text = AddEmployeeClass.empl_passport.МРДата_регистрации.ToString();
            if (AddEmployeeClass.empl_passport.МРСрок_действия_до.ToString() != "01.01.0001 0:00:00")
                MRSrokDeysDo.Text = AddEmployeeClass.empl_passport.МРСрок_действия_до.ToString();
            if (AddEmployeeClass.empl_passport.ФПДата_регистрации.ToString() != "01.01.0001 0:00:00")
                MFPDataRegistr.Text = AddEmployeeClass.empl_passport.ФПДата_регистрации.ToString();
            if (AddEmployeeClass.empl_passport.ФПСрок_действия_до.ToString() != "01.01.0001 0:00:00")
                MFPSrokdeystv.Text = AddEmployeeClass.empl_passport.ФПСрок_действия_до.ToString();
            if (AddEmployeeClass.empl_passport.ЗПДата_выдачи.ToString() != "01.01.0001 0:00:00")
                ZPdatavidachi.Text = AddEmployeeClass.empl_passport.ЗПДата_выдачи.ToString();
            if (AddEmployeeClass.empl_passport.ЗПСрок_действия_до.ToString() != "01.01.0001 0:00:00")
                ZPsrokdeystviya.Text = AddEmployeeClass.empl_passport.ЗПСрок_действия_до.ToString();
        }

        private void textBox_to_AddEmployeeClass()
        {
            AddEmployeeClass.empl_passport.Серия_паспорта = OPSeria.Text;
            AddEmployeeClass.empl_passport.Номер_паспорта = OPNomer.Text;
            AddEmployeeClass.empl_passport.Кем_выдан = OPVidavshiyOrg.Text;
            AddEmployeeClass.empl_passport.Код_подразделения = OPKodPodrazd.Text;
            AddEmployeeClass.empl_passport.МРСтрана = MRStrana.Text;
            AddEmployeeClass.empl_passport.МРРегион = MRRegion.Text;
            AddEmployeeClass.empl_passport.МРПочтовый_индекс = MRPochtoviyIndex.Text;
            AddEmployeeClass.empl_passport.МРГород = MRGorod.Text;
            AddEmployeeClass.empl_passport.МР_Улица = MRUlica.Text;
            AddEmployeeClass.empl_passport.МРДом = MRDom.Text;
            AddEmployeeClass.empl_passport.МРКорпус = MRKorpus.Text;
            AddEmployeeClass.empl_passport.МРКвартира = MRKvartira.Text;
            AddEmployeeClass.empl_passport.ФПСтрана = MFPstrana.Text;
            AddEmployeeClass.empl_passport.ФПРегион = MFPregion.Text;
            AddEmployeeClass.empl_passport.ФППочтовый_индекс = MFPpochtoviyindex.Text;
            AddEmployeeClass.empl_passport.ФПГород = MFPgorod.Text;
            AddEmployeeClass.empl_passport.ФП_Улица = MFPulica.Text;
            AddEmployeeClass.empl_passport.ФПДом = MFPdom.Text;
            AddEmployeeClass.empl_passport.ФПКорпус = MFPkorpus.Text;
            AddEmployeeClass.empl_passport.ФПКвартира = MFPkvartira.Text;
            AddEmployeeClass.empl_passport.ЗПСерия = ZPseriya.Text;
            AddEmployeeClass.empl_passport.ЗПНомер = ZPnomer.Text;
            AddEmployeeClass.empl_passport.ЗПВыдавший_орган = ZPvidavshiyorgan.Text;
            AddEmployeeClass.check1 = Convert.ToBoolean(check_MF.IsChecked);
            if (OPDataVidachi.Text != "")
                AddEmployeeClass.empl_passport.Дата_выдачи = Convert.ToDateTime(OPDataVidachi.Text);
            else
                AddEmployeeClass.empl_passport.Дата_выдачи = Convert.ToDateTime("01.01.0001 0:00:00");
            if (OPSrokDeyst.Text != "")
                AddEmployeeClass.empl_passport.Срок_действия = Convert.ToDateTime(OPSrokDeyst.Text);
            else
                AddEmployeeClass.empl_passport.Срок_действия = Convert.ToDateTime("01.01.0001 0:00:00");
            if (MRDataregistr.Text != "")
                AddEmployeeClass.empl_passport.МРДата_регистрации = Convert.ToDateTime(MRDataregistr.Text);
            else
                AddEmployeeClass.empl_passport.МРДата_регистрации = Convert.ToDateTime("01.01.0001 0:00:00");
            if (MRSrokDeysDo.Text != "")
                AddEmployeeClass.empl_passport.МРСрок_действия_до = Convert.ToDateTime(MRSrokDeysDo.Text);
            else
                AddEmployeeClass.empl_passport.МРСрок_действия_до = Convert.ToDateTime("01.01.0001 0:00:00");
            if (MFPDataRegistr.Text != "")
                AddEmployeeClass.empl_passport.ФПДата_регистрации = Convert.ToDateTime(MFPDataRegistr.Text);
            else
                AddEmployeeClass.empl_passport.ФПДата_регистрации = Convert.ToDateTime("01.01.0001 0:00:00");
            if (MFPSrokdeystv.Text != "")
                AddEmployeeClass.empl_passport.ФПСрок_действия_до = Convert.ToDateTime(MFPSrokdeystv.Text);
            else
                AddEmployeeClass.empl_passport.ФПСрок_действия_до = Convert.ToDateTime("01.01.0001 0:00:00");
            if (ZPdatavidachi.Text != "")
                AddEmployeeClass.empl_passport.ЗПДата_выдачи = Convert.ToDateTime(ZPdatavidachi.Text);
            else
                AddEmployeeClass.empl_passport.ЗПДата_выдачи = Convert.ToDateTime("01.01.0001 0:00:00");
            if (ZPsrokdeystviya.Text != "")
                AddEmployeeClass.empl_passport.ЗПСрок_действия_до = Convert.ToDateTime(ZPsrokdeystviya.Text);
            else
                AddEmployeeClass.empl_passport.ЗПСрок_действия_до = Convert.ToDateTime("01.01.0001 0:00:00");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox_to_AddEmployeeClass();
            Manager.MainFrame.Navigate(new PageAddEmployee3());
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            textBox_to_AddEmployeeClass();
            Manager.MainFrame.Navigate(new PageAddEmployee(null));
        }

        private void Check_MF_Checked(object sender, RoutedEventArgs e)
        {
            MFPDataRegistr.Text = MRDataregistr.Text;
            MFPdom.Text = MRDom.Text;
            MFPgorod.Text = MRGorod.Text;
            MFPkorpus.Text = MRKorpus.Text;
            MFPkvartira.Text = MRKvartira.Text;
            MFPpochtoviyindex.Text = MRPochtoviyIndex.Text;
            MFPregion.Text = MRRegion.Text;
            MFPSrokdeystv.Text = MRSrokDeysDo.Text;
            MFPstrana.Text = MRStrana.Text;
            MFPulica.Text = MRUlica.Text;
        }

        private void Check_MF_Unchecked(object sender, RoutedEventArgs e)
        {
            MFPstrana.Text = AddEmployeeClass.empl_passport.ФПСтрана;
            MFPregion.Text = AddEmployeeClass.empl_passport.ФПРегион;
            MFPpochtoviyindex.Text = AddEmployeeClass.empl_passport.ФППочтовый_индекс;
            MFPgorod.Text = AddEmployeeClass.empl_passport.ФПГород;
            MFPulica.Text = AddEmployeeClass.empl_passport.ФП_Улица;
            MFPdom.Text = AddEmployeeClass.empl_passport.ФПДом;
            MFPkorpus.Text = AddEmployeeClass.empl_passport.ФПКорпус;
            MFPkvartira.Text = AddEmployeeClass.empl_passport.ФПКвартира;
            if (AddEmployeeClass.empl_passport.ФПДата_регистрации.ToString() != "01.01.0001 0:00:00")
                MFPDataRegistr.Text = AddEmployeeClass.empl_passport.ФПДата_регистрации.ToString();
            if (AddEmployeeClass.empl_passport.ФПСрок_действия_до.ToString() != "01.01.0001 0:00:00")
                MFPSrokdeystv.Text = AddEmployeeClass.empl_passport.ФПСрок_действия_до.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddEmployeeClass.employee = null;
            AddEmployeeClass.Clear_variables();
            Manager.MainFrame.Navigate(new Page1());

        }
    }
}
