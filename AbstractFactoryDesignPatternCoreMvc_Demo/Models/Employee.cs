using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractFactoryDesignPatternCoreMvc_Demo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter employee number")]
        [StringLength(100)]
        [Display(Name = "EMP No.")]
        public string EmployeeNumber { get; set; }

        [Required(ErrorMessage = "Please enter employee name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter employee position")]
        [StringLength(100)]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please enter employee office location")]
        [StringLength(100)]
        public string Office { get; set; }

        [Required(ErrorMessage = "Please choose Department")]
        [Display(Name = "Department")]
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("EmployeeTypeId")]
        [Required(ErrorMessage = "Please choose Employee Type")]
        [Display(Name = "Employee Type")]
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }

        [StringLength(255)]
        [Display(Name = "ComputerDetails")]
        public string ComputerDetails { get; set; }
    }
}
