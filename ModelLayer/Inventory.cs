//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        public int InventoryID { get; set; }
        public int InventoryCount { get; set; }
        public string InventoryDate { get; set; }
        public string InventoryDesc { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
