//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaAuctions.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public int idblog { get; set; }
        public string titleblog { get; set; }
        public string contentblog { get; set; }
        public Nullable<System.DateTime> dateblog { get; set; }
        public string imageb1 { get; set; }
        public string imageb2 { get; set; }
        public string imageb3 { get; set; }
        public Nullable<int> idtypeblog { get; set; }
        public Nullable<int> idUser { get; set; }
    
        public virtual TypeBlog TypeBlog { get; set; }
        public virtual User User { get; set; }
    }
}
