//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Store.Domain.Concrete
{
    using System;
    using System.Collections.Generic;
    
    public partial class Categories
    {
        public int category_id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public Nullable<int> parent_id { get; set; }
    }
}