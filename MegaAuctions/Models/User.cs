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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Blogs = new HashSet<Blog>();
            this.Products = new HashSet<Product>();
            this.RoomChats = new HashSet<RoomChat>();
        }
    
        public int idUser { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> born { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string image { get; set; }
        public string password { get; set; }
        public string about { get; set; }
        public Nullable<int> idRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog> Blogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomChat> RoomChats { get; set; }
    }
}
