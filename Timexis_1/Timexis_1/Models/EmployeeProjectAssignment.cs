//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Timexis_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeProjectAssignment
    {
        public int AssignmentID { get; set; }
        public int UserID { get; set; }
        public int ProjectID { get; set; }
        public System.DateTime AssignmentDate { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}
