using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YungChingDemo.Models
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(20)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string? FirstName { get; set; }

        [StringLength(30)]
        public string? Title { get; set; }

        [StringLength(25)]
        public string? TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

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
        public string? HomePhone { get; set; }

        [StringLength(4)]
        public string? Extension { get; set; }

        [Column(TypeName = "ntext")]
        public string? Notes { get; set; }

        public int? ReportsTo { get; set; }

        [StringLength(255)]
        public string? PhotoPath { get; set; }

    }
}
