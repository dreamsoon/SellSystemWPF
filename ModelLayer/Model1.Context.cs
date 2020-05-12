﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sellEntities : DbContext
    {
        public sellEntities()
            : base("name=sellEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Coustomer> Coustomers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VW_Coustomer> VW_Coustomer { get; set; }
        public virtual DbSet<VW_Product> VW_Product { get; set; }
        public virtual DbSet<VW_ProductPrice> VW_ProductPrice { get; set; }
        public virtual DbSet<VW_Users> VW_Users { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<VW_Inventory> VW_Inventory { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<VW_UserLog> VW_UserLog { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoceItem> InvoceItems { get; set; }
        public virtual DbSet<VW_InvoiceItem> VW_InvoiceItem { get; set; }
        public virtual DbSet<VW_InvoiceShow> VW_InvoiceShow { get; set; }
        public virtual DbSet<SystemPart> SystemParts { get; set; }
        public virtual DbSet<VW_SystemPart> VW_SystemPart { get; set; }
        public virtual DbSet<UserAccess> UserAccesses { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int sp_ins_product(string productName, string productDescription, byte[] productImage, string productStartTime, Nullable<int> userID)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var productDescriptionParameter = productDescription != null ?
                new ObjectParameter("ProductDescription", productDescription) :
                new ObjectParameter("ProductDescription", typeof(string));
    
            var productImageParameter = productImage != null ?
                new ObjectParameter("ProductImage", productImage) :
                new ObjectParameter("ProductImage", typeof(byte[]));
    
            var productStartTimeParameter = productStartTime != null ?
                new ObjectParameter("ProductStartTime", productStartTime) :
                new ObjectParameter("ProductStartTime", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ins_product", productNameParameter, productDescriptionParameter, productImageParameter, productStartTimeParameter, userIDParameter);
        }
    
        public virtual int sp_lastfe_Product(Nullable<int> productId, Nullable<long> productLastprice, Nullable<long> productLastPurche)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var productLastpriceParameter = productLastprice.HasValue ?
                new ObjectParameter("ProductLastprice", productLastprice) :
                new ObjectParameter("ProductLastprice", typeof(long));
    
            var productLastPurcheParameter = productLastPurche.HasValue ?
                new ObjectParameter("ProductLastPurche", productLastPurche) :
                new ObjectParameter("ProductLastPurche", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_lastfe_Product", productIdParameter, productLastpriceParameter, productLastPurcheParameter);
        }
    
        public virtual int sp_Update_LastSuplay(Nullable<int> proudactCount, Nullable<int> proudactID)
        {
            var proudactCountParameter = proudactCount.HasValue ?
                new ObjectParameter("ProudactCount", proudactCount) :
                new ObjectParameter("ProudactCount", typeof(int));
    
            var proudactIDParameter = proudactID.HasValue ?
                new ObjectParameter("ProudactID", proudactID) :
                new ObjectParameter("ProudactID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Update_LastSuplay", proudactCountParameter, proudactIDParameter);
        }
    
        public virtual int sp_update_ExitTime(Nullable<int> userID, string exitTime)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var exitTimeParameter = exitTime != null ?
                new ObjectParameter("ExitTime", exitTime) :
                new ObjectParameter("ExitTime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update_ExitTime", userIDParameter, exitTimeParameter);
        }
    
        public virtual int sp_Update_exitttime(Nullable<int> userId, string exitDate)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var exitDateParameter = exitDate != null ?
                new ObjectParameter("ExitDate", exitDate) :
                new ObjectParameter("ExitDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Update_exitttime", userIdParameter, exitDateParameter);
        }
    
        public virtual int sp_Update_Product(Nullable<int> productId, string proudactName, string proudactDes, byte[] productImage)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var proudactNameParameter = proudactName != null ?
                new ObjectParameter("ProudactName", proudactName) :
                new ObjectParameter("ProudactName", typeof(string));
    
            var proudactDesParameter = proudactDes != null ?
                new ObjectParameter("ProudactDes", proudactDes) :
                new ObjectParameter("ProudactDes", typeof(string));
    
            var productImageParameter = productImage != null ?
                new ObjectParameter("ProductImage", productImage) :
                new ObjectParameter("ProductImage", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Update_Product", productIdParameter, proudactNameParameter, proudactDesParameter, productImageParameter);
        }
    
        public virtual int sp_ins_product_whitoutimage(string productName, string productDescription, string productStartTime, Nullable<int> userID)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var productDescriptionParameter = productDescription != null ?
                new ObjectParameter("ProductDescription", productDescription) :
                new ObjectParameter("ProductDescription", typeof(string));
    
            var productStartTimeParameter = productStartTime != null ?
                new ObjectParameter("ProductStartTime", productStartTime) :
                new ObjectParameter("ProductStartTime", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ins_product_whitoutimage", productNameParameter, productDescriptionParameter, productStartTimeParameter, userIDParameter);
        }
    
        public virtual int sp_Update_Product_whitoutimage(Nullable<int> productId, string proudactName, string proudactDes)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var proudactNameParameter = proudactName != null ?
                new ObjectParameter("ProudactName", proudactName) :
                new ObjectParameter("ProudactName", typeof(string));
    
            var proudactDesParameter = proudactDes != null ?
                new ObjectParameter("ProudactDes", proudactDes) :
                new ObjectParameter("ProudactDes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Update_Product_whitoutimage", productIdParameter, proudactNameParameter, proudactDesParameter);
        }
    
        public virtual ObjectResult<sp_sell_Chart_Result> sp_sell_Chart()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_sell_Chart_Result>("sp_sell_Chart");
        }
    
        public virtual ObjectResult<sp_CoustomersellChart_Result> sp_CoustomersellChart()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CoustomersellChart_Result>("sp_CoustomersellChart");
        }
    
        public virtual ObjectResult<sp_prouductsellpricechart_Result> sp_prouductsellpricechart()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_prouductsellpricechart_Result>("sp_prouductsellpricechart");
        }
    
        public virtual ObjectResult<sp_prouductsellcountchart_Result> sp_prouductsellcountchart()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_prouductsellcountchart_Result>("sp_prouductsellcountchart");
        }
    
        public virtual ObjectResult<sp_selluser_Result> sp_selluser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_selluser_Result>("sp_selluser");
        }
    
        public virtual ObjectResult<sp_porforoshtarin_Result> sp_porforoshtarin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_porforoshtarin_Result>("sp_porforoshtarin");
        }
    
        public virtual ObjectResult<sp_porforoshtarintedad_Result> sp_porforoshtarintedad()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_porforoshtarintedad_Result>("sp_porforoshtarintedad");
        }
    
        public virtual int SP_Del_UsserAccess(Nullable<int> userID, Nullable<int> systemPartID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var systemPartIDParameter = systemPartID.HasValue ?
                new ObjectParameter("SystemPartID", systemPartID) :
                new ObjectParameter("SystemPartID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Del_UsserAccess", userIDParameter, systemPartIDParameter);
        }
    }
}
