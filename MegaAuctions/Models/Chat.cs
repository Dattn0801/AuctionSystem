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
    
    public partial class Chat
    {
        public int idchat { get; set; }
        public string contentchat { get; set; }
        public Nullable<System.DateTime> datechat { get; set; }
        public string timechat { get; set; }
        public string imagechat { get; set; }
        public Nullable<int> idroom { get; set; }
    
        public virtual RoomChat RoomChat { get; set; }
    }
}
