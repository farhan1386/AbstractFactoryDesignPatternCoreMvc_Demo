using System.ComponentModel.DataAnnotations;

namespace AbstractFactoryDesignPatternCoreMvc_Demo.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please choose Department")]
        [StringLength(100)]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }
    }
}
