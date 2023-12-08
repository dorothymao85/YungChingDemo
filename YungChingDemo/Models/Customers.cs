using System.ComponentModel.DataAnnotations;

namespace YungChingDemo.Models
{
    public class Customers
    {
        [Required]
        [Key]
        [MaxLength(5)]
        public long uuid { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(30)]
        public string? ContactName { get; set; }

        [StringLength(30)]
        public string? ContactTitle { get; set; }

        [StringLength(60)]
        public string? Address { get; set; }

        [StringLength(15)]
        public string? City { get; set; }

        [StringLength(15)]
        public string? Region { get; set; }

        [StringLength(10)]
        public string? PostalCode { get; set; }

        [StringLength(15)]
        public string? Country { get; set; }

        [StringLength(24)]
        public string? Phone { get; set; }

        [StringLength(24)]
        public string? Fax { get; set; }

    }
}
