//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyList.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Posting
    {
        public int Id { get; set; }
        public string status { get; set; }
        public string customerStatus { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string postedDate { get; set; }
        public string details { get; set; }
        public Nullable<decimal> price { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string contactInfo { get; set; }
        public int customerId { get; set; }
        public Nullable<int> images { get; set; }
        public string other1 { get; set; }
        public string other2 { get; set; }
        public byte[] image1 { get; set; }
        public byte[] image2 { get; set; }
        public byte[] image3 { get; set; }
        public byte[] image4 { get; set; }
    }
}
