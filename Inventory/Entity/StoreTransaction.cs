//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoreTransaction
    {
        public int Id { get; set; }
        public Nullable<int> StoreItemId { get; set; }
        public Nullable<decimal> ItemCount { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> TransactionType { get; set; }
        public Nullable<int> ZoneId { get; set; }
        public string IndividualName { get; set; }
        public Nullable<int> IndividualId { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string Description { get; set; }
        public string ZoneName { get; set; }
    }
}
