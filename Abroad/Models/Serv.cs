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
    
    public partial class Serv
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Serv()
        {
            this.TimeSheets = new HashSet<TimeSheet>();
        }
    
        public int ServiceID { get; set; }
        public string NameServ { get; set; }
        public string DescriptionServ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeSheet> TimeSheets { get; set; }
    }
}