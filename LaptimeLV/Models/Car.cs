using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LaptimeLV.Models
{
    public enum DriveType { FWD, AWD, RWD}
    
    public class Car
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Registration { get; set; }
        [StringLength(100)]
        public string Vin { get; set; }
        [StringLength(100)]
        public string Manufacturer { get; set; }
        [StringLength(100)]
        public string Model { get; set; }
        public int? Year { get; set; }
        public int? Power { get; set; }
        public int? Torque { get; set; }
        public int? Weight { get; set; }
        public DriveType? DriveType { get; set; }
        public string ApplicationUserID { get; set; }
        public virtual IdentityUser ApplicationUser { get; set; }
    }
}
