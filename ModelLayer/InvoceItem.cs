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
    
    public partial class InvoceItem
    {
        public int InvoceItemID { get; set; }
        public int InvoceItemCount { get; set; }
        public int ProudactID { get; set; }
        public long InvoceItemFeeSell { get; set; }
        public long InvoceItemFeePurche { get; set; }
        public int InvoiceID { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
