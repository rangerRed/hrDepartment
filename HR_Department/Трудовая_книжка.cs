//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR_Department
{
    using System;
    using System.Collections.Generic;
    
    public partial class Трудовая_книжка
    {
        public int ID { get; set; }
        public int Код_сотрудника { get; set; }
        public int C_пп { get; set; }
        public Nullable<System.DateTime> Дата { get; set; }
        public string Сведения_о_приеме_переводах_и_увольнении { get; set; }
        public string ОснованиеНаименование { get; set; }
        public Nullable<System.DateTime> ОснованиеДата { get; set; }
        public string ОснованиеНомер { get; set; }
        public string ОснованиеСерия { get; set; }
        public string Вид_кадрового_мероприятия { get; set; }
        public string Статья_ФЗ_причины_при_увольнении { get; set; }
        public string Пункт_ФЗ_причины_при_увольнении { get; set; }
        public string выполняемая_функция_при_наличии_ { get; set; }
        public Nullable<System.DateTime> С_даты { get; set; }
        public Nullable<System.DateTime> по_дату { get; set; }
        public Nullable<bool> признак_отмены_записи { get; set; }
        public Nullable<System.DateTime> дата_отмены_записи { get; set; }
        public Nullable<bool> совместитель { get; set; }
        public string должность { get; set; }
        public string отдел { get; set; }
        public string работа_в_районах_крайнего_севера { get; set; }
        public string UUID { get; set; }
    
        public virtual Сотрудник Сотрудник { get; set; }
    }
}
