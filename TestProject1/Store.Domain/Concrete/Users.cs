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
    
    public partial class Users
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Nullable<int> access_level { get; set; }
        public Nullable<System.DateTime> last_login { get; set; }
    }
}
