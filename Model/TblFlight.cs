//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Console_Application.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblFlight
    {
        public int FlightID { get; set; }
        public Nullable<int> DepartureLocation { get; set; }
        public Nullable<int> ArrivalLocation { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<byte> Capacity { get; set; }
        public Nullable<System.DateTime> FlightDate { get; set; }
        public string Description { get; set; }
    
        public virtual TblCountry TblCountry { get; set; }
        public virtual TblCountry TblCountry1 { get; set; }
    }
}
