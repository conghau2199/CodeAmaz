//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeAmaz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHANGE_PASS
    {
        public int ID_CHANGE { get; set; }
        public string USERNAME_CHANGE { get; set; }
        public string OLDPASSWORD { get; set; }
        public string NEWPASSWORD { get; set; }
        public string CONFIRMNEWPASSWORD { get; set; }
        public Nullable<System.DateTime> TIMECHANGE { get; set; }
    }
}