﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TardeHareAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TRADEHAREDBEntities : DbContext
    {
        public TRADEHAREDBEntities()
            : base("name=TRADEHAREDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<CommodityList> CommodityLists { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<NotifyParty> NotifyParties { get; set; }
        public virtual DbSet<Packer> Packers { get; set; }
        public virtual DbSet<Packing> Packings { get; set; }
        public virtual DbSet<PortList> PortLists { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Representative> Representatives { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TagDetail> TagDetails { get; set; }
        public virtual DbSet<TagMaster> TagMasters { get; set; }
        public virtual DbSet<UserAuth> UserAuths { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<uvwLastPurchaseDetail> uvwLastPurchaseDetails { get; set; }
        public virtual DbSet<uvwLastSellerDetail> uvwLastSellerDetails { get; set; }
    
        public virtual ObjectResult<CommodityList> GetCommodity(Nullable<int> comId, string commodityName)
        {
            var comIdParameter = comId.HasValue ?
                new ObjectParameter("ComId", comId) :
                new ObjectParameter("ComId", typeof(int));
    
            var commodityNameParameter = commodityName != null ?
                new ObjectParameter("CommodityName", commodityName) :
                new ObjectParameter("CommodityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CommodityList>("GetCommodity", comIdParameter, commodityNameParameter);
        }
    
        public virtual ObjectResult<CommodityList> GetCommodity(Nullable<int> comId, string commodityName, MergeOption mergeOption)
        {
            var comIdParameter = comId.HasValue ?
                new ObjectParameter("ComId", comId) :
                new ObjectParameter("ComId", typeof(int));
    
            var commodityNameParameter = commodityName != null ?
                new ObjectParameter("CommodityName", commodityName) :
                new ObjectParameter("CommodityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CommodityList>("GetCommodity", mergeOption, comIdParameter, commodityNameParameter);
        }
    
        public virtual int AddCommodity(string commodityName, string commoditySpec, string tradeRules, Nullable<byte> userId, ObjectParameter id)
        {
            var commodityNameParameter = commodityName != null ?
                new ObjectParameter("CommodityName", commodityName) :
                new ObjectParameter("CommodityName", typeof(string));
    
            var commoditySpecParameter = commoditySpec != null ?
                new ObjectParameter("CommoditySpec", commoditySpec) :
                new ObjectParameter("CommoditySpec", typeof(string));
    
            var tradeRulesParameter = tradeRules != null ?
                new ObjectParameter("TradeRules", tradeRules) :
                new ObjectParameter("TradeRules", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddCommodity", commodityNameParameter, commoditySpecParameter, tradeRulesParameter, userIdParameter, id);
        }
    
        public virtual int UpdateCommodity(Nullable<int> comId, string commodityName, string commoditySpec, string tradeTules, Nullable<byte> active, Nullable<byte> userId)
        {
            var comIdParameter = comId.HasValue ?
                new ObjectParameter("ComId", comId) :
                new ObjectParameter("ComId", typeof(int));
    
            var commodityNameParameter = commodityName != null ?
                new ObjectParameter("CommodityName", commodityName) :
                new ObjectParameter("CommodityName", typeof(string));
    
            var commoditySpecParameter = commoditySpec != null ?
                new ObjectParameter("CommoditySpec", commoditySpec) :
                new ObjectParameter("CommoditySpec", typeof(string));
    
            var tradeTulesParameter = tradeTules != null ?
                new ObjectParameter("TradeTules", tradeTules) :
                new ObjectParameter("TradeTules", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(byte));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCommodity", comIdParameter, commodityNameParameter, commoditySpecParameter, tradeTulesParameter, activeParameter, userIdParameter);
        }
    
        public virtual ObjectResult<Buyer> GetBuyer(Nullable<int> buyId, string buyerName)
        {
            var buyIdParameter = buyId.HasValue ?
                new ObjectParameter("BuyId", buyId) :
                new ObjectParameter("BuyId", typeof(int));
    
            var buyerNameParameter = buyerName != null ?
                new ObjectParameter("BuyerName", buyerName) :
                new ObjectParameter("BuyerName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Buyer>("GetBuyer", buyIdParameter, buyerNameParameter);
        }
    
        public virtual ObjectResult<Buyer> GetBuyer(Nullable<int> buyId, string buyerName, MergeOption mergeOption)
        {
            var buyIdParameter = buyId.HasValue ?
                new ObjectParameter("BuyId", buyId) :
                new ObjectParameter("BuyId", typeof(int));
    
            var buyerNameParameter = buyerName != null ?
                new ObjectParameter("BuyerName", buyerName) :
                new ObjectParameter("BuyerName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Buyer>("GetBuyer", mergeOption, buyIdParameter, buyerNameParameter);
        }
    
        public virtual ObjectResult<Nullable<byte>> AddSupplier(string supplierName, string addressLine1, string addressLine2, string city, string state, string postalCode, string contactPerson, string phone, string fax, string email1, string email2, Nullable<byte> userId, ObjectParameter id)
        {
            var supplierNameParameter = supplierName != null ?
                new ObjectParameter("SupplierName", supplierName) :
                new ObjectParameter("SupplierName", typeof(string));
    
            var addressLine1Parameter = addressLine1 != null ?
                new ObjectParameter("AddressLine1", addressLine1) :
                new ObjectParameter("AddressLine1", typeof(string));
    
            var addressLine2Parameter = addressLine2 != null ?
                new ObjectParameter("AddressLine2", addressLine2) :
                new ObjectParameter("AddressLine2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var postalCodeParameter = postalCode != null ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(string));
    
            var contactPersonParameter = contactPerson != null ?
                new ObjectParameter("ContactPerson", contactPerson) :
                new ObjectParameter("ContactPerson", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var faxParameter = fax != null ?
                new ObjectParameter("Fax", fax) :
                new ObjectParameter("Fax", typeof(string));
    
            var email1Parameter = email1 != null ?
                new ObjectParameter("Email1", email1) :
                new ObjectParameter("Email1", typeof(string));
    
            var email2Parameter = email2 != null ?
                new ObjectParameter("Email2", email2) :
                new ObjectParameter("Email2", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<byte>>("AddSupplier", supplierNameParameter, addressLine1Parameter, addressLine2Parameter, cityParameter, stateParameter, postalCodeParameter, contactPersonParameter, phoneParameter, faxParameter, email1Parameter, email2Parameter, userIdParameter, id);
        }
    
        public virtual int UpdateSupplier(Nullable<int> supId, string supplierName, string addressLine1, string addressLine2, string city, string state, string postalCode, string contactPerson, string phone, string fax, string email1, string email2, Nullable<byte> active, Nullable<byte> userId)
        {
            var supIdParameter = supId.HasValue ?
                new ObjectParameter("SupId", supId) :
                new ObjectParameter("SupId", typeof(int));
    
            var supplierNameParameter = supplierName != null ?
                new ObjectParameter("SupplierName", supplierName) :
                new ObjectParameter("SupplierName", typeof(string));
    
            var addressLine1Parameter = addressLine1 != null ?
                new ObjectParameter("AddressLine1", addressLine1) :
                new ObjectParameter("AddressLine1", typeof(string));
    
            var addressLine2Parameter = addressLine2 != null ?
                new ObjectParameter("AddressLine2", addressLine2) :
                new ObjectParameter("AddressLine2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var postalCodeParameter = postalCode != null ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(string));
    
            var contactPersonParameter = contactPerson != null ?
                new ObjectParameter("ContactPerson", contactPerson) :
                new ObjectParameter("ContactPerson", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var faxParameter = fax != null ?
                new ObjectParameter("Fax", fax) :
                new ObjectParameter("Fax", typeof(string));
    
            var email1Parameter = email1 != null ?
                new ObjectParameter("Email1", email1) :
                new ObjectParameter("Email1", typeof(string));
    
            var email2Parameter = email2 != null ?
                new ObjectParameter("Email2", email2) :
                new ObjectParameter("Email2", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(byte));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateSupplier", supIdParameter, supplierNameParameter, addressLine1Parameter, addressLine2Parameter, cityParameter, stateParameter, postalCodeParameter, contactPersonParameter, phoneParameter, faxParameter, email1Parameter, email2Parameter, activeParameter, userIdParameter);
        }
    
        public virtual ObjectResult<Nullable<byte>> AddBuyer(string buyerName, string addressLine1, string addressLine2, string city, string state, string postalCode, string contactPerson, string phone, string fax, string email1, string email2, Nullable<byte> userId, ObjectParameter id)
        {
            var buyerNameParameter = buyerName != null ?
                new ObjectParameter("BuyerName", buyerName) :
                new ObjectParameter("BuyerName", typeof(string));
    
            var addressLine1Parameter = addressLine1 != null ?
                new ObjectParameter("AddressLine1", addressLine1) :
                new ObjectParameter("AddressLine1", typeof(string));
    
            var addressLine2Parameter = addressLine2 != null ?
                new ObjectParameter("AddressLine2", addressLine2) :
                new ObjectParameter("AddressLine2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var postalCodeParameter = postalCode != null ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(string));
    
            var contactPersonParameter = contactPerson != null ?
                new ObjectParameter("ContactPerson", contactPerson) :
                new ObjectParameter("ContactPerson", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var faxParameter = fax != null ?
                new ObjectParameter("Fax", fax) :
                new ObjectParameter("Fax", typeof(string));
    
            var email1Parameter = email1 != null ?
                new ObjectParameter("Email1", email1) :
                new ObjectParameter("Email1", typeof(string));
    
            var email2Parameter = email2 != null ?
                new ObjectParameter("Email2", email2) :
                new ObjectParameter("Email2", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<byte>>("AddBuyer", buyerNameParameter, addressLine1Parameter, addressLine2Parameter, cityParameter, stateParameter, postalCodeParameter, contactPersonParameter, phoneParameter, faxParameter, email1Parameter, email2Parameter, userIdParameter, id);
        }
    
        public virtual ObjectResult<Supplier> GetSupplier(Nullable<int> supId, string supplierName)
        {
            var supIdParameter = supId.HasValue ?
                new ObjectParameter("SupId", supId) :
                new ObjectParameter("SupId", typeof(int));
    
            var supplierNameParameter = supplierName != null ?
                new ObjectParameter("SupplierName", supplierName) :
                new ObjectParameter("SupplierName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Supplier>("GetSupplier", supIdParameter, supplierNameParameter);
        }
    
        public virtual ObjectResult<Supplier> GetSupplier(Nullable<int> supId, string supplierName, MergeOption mergeOption)
        {
            var supIdParameter = supId.HasValue ?
                new ObjectParameter("SupId", supId) :
                new ObjectParameter("SupId", typeof(int));
    
            var supplierNameParameter = supplierName != null ?
                new ObjectParameter("SupplierName", supplierName) :
                new ObjectParameter("SupplierName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Supplier>("GetSupplier", mergeOption, supIdParameter, supplierNameParameter);
        }
    
        public virtual int UpdateBuyer(Nullable<int> buyId, string buyerName, string addressLine1, string addressLine2, string city, string state, string postalCode, string contactPerson, string phone, string fax, string email1, string email2, Nullable<byte> active, Nullable<byte> userId)
        {
            var buyIdParameter = buyId.HasValue ?
                new ObjectParameter("BuyId", buyId) :
                new ObjectParameter("BuyId", typeof(int));
    
            var buyerNameParameter = buyerName != null ?
                new ObjectParameter("BuyerName", buyerName) :
                new ObjectParameter("BuyerName", typeof(string));
    
            var addressLine1Parameter = addressLine1 != null ?
                new ObjectParameter("AddressLine1", addressLine1) :
                new ObjectParameter("AddressLine1", typeof(string));
    
            var addressLine2Parameter = addressLine2 != null ?
                new ObjectParameter("AddressLine2", addressLine2) :
                new ObjectParameter("AddressLine2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var postalCodeParameter = postalCode != null ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(string));
    
            var contactPersonParameter = contactPerson != null ?
                new ObjectParameter("ContactPerson", contactPerson) :
                new ObjectParameter("ContactPerson", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var faxParameter = fax != null ?
                new ObjectParameter("Fax", fax) :
                new ObjectParameter("Fax", typeof(string));
    
            var email1Parameter = email1 != null ?
                new ObjectParameter("Email1", email1) :
                new ObjectParameter("Email1", typeof(string));
    
            var email2Parameter = email2 != null ?
                new ObjectParameter("Email2", email2) :
                new ObjectParameter("Email2", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(byte));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBuyer", buyIdParameter, buyerNameParameter, addressLine1Parameter, addressLine2Parameter, cityParameter, stateParameter, postalCodeParameter, contactPersonParameter, phoneParameter, faxParameter, email1Parameter, email2Parameter, activeParameter, userIdParameter);
        }
    
        public virtual ObjectResult<Nullable<byte>> AddNotifyParty(string partyName, string addressLine1, string addressLine2, string city, string state, string postalCode, string contactPerson, string phone, string fax, string email1, string email2, Nullable<byte> userId, ObjectParameter id)
        {
            var partyNameParameter = partyName != null ?
                new ObjectParameter("PartyName", partyName) :
                new ObjectParameter("PartyName", typeof(string));
    
            var addressLine1Parameter = addressLine1 != null ?
                new ObjectParameter("AddressLine1", addressLine1) :
                new ObjectParameter("AddressLine1", typeof(string));
    
            var addressLine2Parameter = addressLine2 != null ?
                new ObjectParameter("AddressLine2", addressLine2) :
                new ObjectParameter("AddressLine2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var postalCodeParameter = postalCode != null ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(string));
    
            var contactPersonParameter = contactPerson != null ?
                new ObjectParameter("ContactPerson", contactPerson) :
                new ObjectParameter("ContactPerson", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var faxParameter = fax != null ?
                new ObjectParameter("Fax", fax) :
                new ObjectParameter("Fax", typeof(string));
    
            var email1Parameter = email1 != null ?
                new ObjectParameter("Email1", email1) :
                new ObjectParameter("Email1", typeof(string));
    
            var email2Parameter = email2 != null ?
                new ObjectParameter("Email2", email2) :
                new ObjectParameter("Email2", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<byte>>("AddNotifyParty", partyNameParameter, addressLine1Parameter, addressLine2Parameter, cityParameter, stateParameter, postalCodeParameter, contactPersonParameter, phoneParameter, faxParameter, email1Parameter, email2Parameter, userIdParameter, id);
        }
    
        public virtual ObjectResult<NotifyParty> GetNotifyParty(Nullable<int> parId, string partyName)
        {
            var parIdParameter = parId.HasValue ?
                new ObjectParameter("ParId", parId) :
                new ObjectParameter("ParId", typeof(int));
    
            var partyNameParameter = partyName != null ?
                new ObjectParameter("PartyName", partyName) :
                new ObjectParameter("PartyName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NotifyParty>("GetNotifyParty", parIdParameter, partyNameParameter);
        }
    
        public virtual ObjectResult<NotifyParty> GetNotifyParty(Nullable<int> parId, string partyName, MergeOption mergeOption)
        {
            var parIdParameter = parId.HasValue ?
                new ObjectParameter("ParId", parId) :
                new ObjectParameter("ParId", typeof(int));
    
            var partyNameParameter = partyName != null ?
                new ObjectParameter("PartyName", partyName) :
                new ObjectParameter("PartyName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NotifyParty>("GetNotifyParty", mergeOption, parIdParameter, partyNameParameter);
        }
    
        public virtual int UpdateNotifyParty(Nullable<int> parId, string partyName, string addressLine1, string addressLine2, string city, string state, string postalCode, string contactPerson, string phone, string fax, string email1, string email2, Nullable<byte> active, Nullable<byte> userId)
        {
            var parIdParameter = parId.HasValue ?
                new ObjectParameter("ParId", parId) :
                new ObjectParameter("ParId", typeof(int));
    
            var partyNameParameter = partyName != null ?
                new ObjectParameter("PartyName", partyName) :
                new ObjectParameter("PartyName", typeof(string));
    
            var addressLine1Parameter = addressLine1 != null ?
                new ObjectParameter("AddressLine1", addressLine1) :
                new ObjectParameter("AddressLine1", typeof(string));
    
            var addressLine2Parameter = addressLine2 != null ?
                new ObjectParameter("AddressLine2", addressLine2) :
                new ObjectParameter("AddressLine2", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var postalCodeParameter = postalCode != null ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(string));
    
            var contactPersonParameter = contactPerson != null ?
                new ObjectParameter("ContactPerson", contactPerson) :
                new ObjectParameter("ContactPerson", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var faxParameter = fax != null ?
                new ObjectParameter("Fax", fax) :
                new ObjectParameter("Fax", typeof(string));
    
            var email1Parameter = email1 != null ?
                new ObjectParameter("Email1", email1) :
                new ObjectParameter("Email1", typeof(string));
    
            var email2Parameter = email2 != null ?
                new ObjectParameter("Email2", email2) :
                new ObjectParameter("Email2", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(byte));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateNotifyParty", parIdParameter, partyNameParameter, addressLine1Parameter, addressLine2Parameter, cityParameter, stateParameter, postalCodeParameter, contactPersonParameter, phoneParameter, faxParameter, email1Parameter, email2Parameter, activeParameter, userIdParameter);
        }
    }
}