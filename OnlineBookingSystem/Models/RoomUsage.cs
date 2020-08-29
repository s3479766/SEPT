//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineBookingSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomUsage
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int UserID { get; set; }
        public decimal TotalAmount { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string NumberOfMembers { get; set; }
        public System.DateTime BookingDate { get; set; }
        public int BookingHoursID { get; set; }
    
        public virtual BookingHour BookingHour { get; set; }
        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
    }
}
