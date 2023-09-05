using System;
using System.IO;

namespace HR_Department
{
    class AddEmployeeClass
    {
        static public string path_project = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName).Replace(@"\bin\Release", "");

        static public Трудовая_книжка empl_hist;
        static public Сотрудник employee;
        static public ОбразовниеСот empl_education;
        static public Воинский_учетСот empl_military_registration;
        static public Трудовая_деятельность empl_activity;
        static public Паспортные_данныеСот empl_passport;
        static public Информация_об_организации org;
        static public дополнительные_поля fields;

        static public bool add;
        // idшники таблиц
        static public int id_employee2;
        static public int id_obraz;
        static public int id_voinsk;
        static public int id_trudov;
        static public int id_pasport;

        static public bool yes_no = false;
        static public bool check1 = false;
        static public string path_image;
        static public string image_name;

        static public string text_to_label;
        static public int id_employee;
        

        // информация об оорганизации
        static public string short_name;
        static public string full_name;
        static public string city;
        static public string address;
        static public string INN_organization;
        static public string KPP;
        static public string calculation1;
        static public string calculation2;
        static public string OKPO;
        static public string OGRN;
        static public string number_PFR;
        static public string id_PFR;
        static public string banck;
        static public string BIK_banck;
        static public string FIO_employee_HR_department;
        static public string FIO_main_accountant;
        static public string FIO_supervisor;
        static public string position_supervisor;
        static public string position_employee_HR_department;
        static public string phone_fax;
        static public string note;
        static public string but_save;

        static public void Clear_variables()
        {
            image_name = null;
            path_image = null;
            id_employee = 0;

            empl_hist = null;
            employee = null;
            empl_education = null;
            empl_military_registration = null;
            empl_activity = null;
            empl_passport = null;
            org = null;
            fields = null;
        }
    }
}
