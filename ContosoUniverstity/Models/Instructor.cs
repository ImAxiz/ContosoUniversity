using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        
        [Display(Name = "Full Name")]
        public string FullName 
        { get 
            { return LastName + ", " + FirstMidName; }
        }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "(0:yyyy-MM-dd)")]
        [Display(Name = "Hired on:")]
        public DateTime HireDate { get; set; }

        public ICollection<CourseAssignment>? CourseAssignments { get; set; }
        public OfficeAssignment? OfficeAssignment { get; set; }

        //igaühel on oma kolm unikaalset propetyt
        public int? Vanus { get; set; }
        public Linn? Linn { get; set; }
        [Display(Name = "Algne Sugu:")]
        public string? Sugu { get; set; }
    }
    public enum Linn 
    {
        Tallinn, Paide, Kiviõli
    }
}
