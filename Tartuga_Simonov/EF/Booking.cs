//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tartuga_Simonov.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int IdBooking { get; set; }
        public int IdTable { get; set; }
        public System.DateTime DataBooking { get; set; }
    
        public virtual Table Table { get; set; }
    }
}