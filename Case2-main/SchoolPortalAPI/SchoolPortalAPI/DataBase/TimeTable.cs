//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolPortalAPI.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeTable
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int Count { get; set; }
        public int ClassId { get; set; }
        public string DayOfTheWeek { get; set; }
        public System.TimeSpan Start { get; set; }
        public System.TimeSpan End { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Lessons Lessons { get; set; }
    }
}