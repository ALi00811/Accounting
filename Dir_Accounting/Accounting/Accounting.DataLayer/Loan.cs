//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loan
    {
        public int ID { get; set; }
        public long Amount { get; set; }
        public string Date_Received { get; set; }
        public string Description { get; set; }
        public Nullable<int> Profit { get; set; }
        public Nullable<long> Refund_Amount { get; set; }
        public Nullable<int> Number_Of_Installment { get; set; }
    }
}
