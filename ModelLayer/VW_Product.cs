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
    
    public partial class VW_Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public long ProdactLastPrice { get; set; }
        public int ProductLastSuply { get; set; }
        public byte[] ProductImage { get; set; }
        public string ProductStartTime { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserFamily { get; set; }
        public string FullName { get; set; }
        public Nullable<byte> ProudactActive { get; set; }
        public Nullable<long> ProudactLastPourchFee { get; set; }
    }
}
