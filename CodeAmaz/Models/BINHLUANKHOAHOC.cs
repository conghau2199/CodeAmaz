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
    
    public partial class BINHLUANKHOAHOC
    {
        public int ID_COMMENT { get; set; }
        public string USERNAME_CMT { get; set; }
        public string MAKH_CMT { get; set; }
        public string HOVATEN_CMT { get; set; }
        public string ANHDAIDIEN_CMT { get; set; }
        public string NOIDUNG_CMT { get; set; }
        public Nullable<System.DateTime> TIME_CMT { get; set; }
    
        public virtual KHOAHOC KHOAHOC { get; set; }
    }
}