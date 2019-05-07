using System.ComponentModel.DataAnnotations;

namespace LaptimeLV.Models
{
    public class Track
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string Street { get; set; }
        [StringLength(100)]
        public string Number { get; set; }
        public int Lenght { get; set; }
        [StringLength(100)]
        public string Surface { get; set; }
        [Required, StringLength(1000)]
        public string Description { get; set; }
    }
}
