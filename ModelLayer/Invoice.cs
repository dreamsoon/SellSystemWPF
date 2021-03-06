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
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.InvoceItems = new HashSet<InvoceItem>();
        }
    
        public int InvoiceId { get; set; }
        public string InvoiceDate { get; set; }
        public Nullable<long> InvoicePrice { get; set; }
        public string InvocieDesc { get; set; }
        public int CoustoemrId { get; set; }
        public int UserID { get; set; }
        public Nullable<long> InvocePrice_Pourche { get; set; }
        public Nullable<byte> InvoiceType { get; set; }
    
        public virtual Coustomer Coustomer { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoceItem> InvoceItems { get; set; }
    }
}
