//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abroad.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeSheet
    {
        public int TimeSheetID { get; set; }
        public Nullable<int> MaNguoiDung { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public System.DateTime WorkDate { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal Salary { get; set; }
    
        public virtual Serv Serv { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
