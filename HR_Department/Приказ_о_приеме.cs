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
    
    public partial class Приказ_о_приеме
    {
        public int C__приказа { get; set; }
        public System.DateTime Дата_подписи { get; set; }
        public int Код_сотрудника { get; set; }
        public int Код_штатной_единицы { get; set; }
        public int Количество_ставок { get; set; }
    
        public virtual Сотрудник Сотрудник { get; set; }
    }
}
