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
    
    public partial class FastFoodOrder
    {
        public int FFID { get; set; }
        public int OrderID { get; set; }
        public string Qty { get; set; }
    
        public virtual FastFood FastFood { get; set; }
        public virtual Order Order { get; set; }
    }
}
