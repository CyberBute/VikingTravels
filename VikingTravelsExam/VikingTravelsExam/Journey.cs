//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VikingTravelsExam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journey
    {
        public int jour_Id { get; set; }
        public string title { get; set; }
        public string city { get; set; }
        public System.DateTime startDate { get; set; }
        public System.DateTime endDate { get; set; }
        public Nullable<short> maxTravelers { get; set; }
        public string jour_Carrier { get; set; }
        public int pricePerTravelers { get; set; }
        public string descriptions { get; set; }
    }
}
