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
    
    public partial class LeaveBalance
    {
        public int LeaveBalanceID { get; set; }
        public int UserID { get; set; }
        public int LeaveID { get; set; }
        public int Balance { get; set; }
    
        public virtual Leave Leave { get; set; }
        public virtual User User { get; set; }
    }
}