//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerCart
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
        public System.DateTime CreatedDatetime { get; set; }
        public bool IsDeleted { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
