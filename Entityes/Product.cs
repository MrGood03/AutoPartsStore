//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFProject.Entityes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public int CreatorID { get; set; }
        public int CategoryID { get; set; }
        public string NameProduct { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int QuantityInStock { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Creator Creator { get; set; }
    }
}
