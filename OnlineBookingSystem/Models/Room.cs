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
    
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            this.RoomUsages = new HashSet<RoomUsage>();
        }
    
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public decimal RoomPrice { get; set; }
        public int RoomTypeid { get; set; }
        public int RoomCapacity { get; set; }
        public string RoomDescription { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public bool StudentsNotAllowed { get; set; }
    
        public virtual RoomType RoomType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomUsage> RoomUsages { get; set; }
    }
}