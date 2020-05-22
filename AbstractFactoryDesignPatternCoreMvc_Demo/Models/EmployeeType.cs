using System.ComponentModel.DataAnnotations;

namespace AbstractFactoryDesignPatternCoreMvc_Demo.Models
{
    public class EmployeeType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please choose Employee Type")]
        [StringLength(100)]
        [Display(Name = "Employee Type")]
        public string EmployeeTypeName { get; set; }
    }
}
