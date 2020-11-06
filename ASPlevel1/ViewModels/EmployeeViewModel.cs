using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required ")]
        [Display(Name = "Name")]
        [StringLength(maximumLength:200, MinimumLength = 2, ErrorMessage = "The name must be between 2 and 200 characters")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required ")]
        [Display(Name = "Surname")]
        public string SurName { get; set; }

        [Display(Name = "Patronymic")]
        public string Patronymic { get; set; }

        public int Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Position is required ")]
        [Display(Name = "Position")]
        public string Position { get; set; }
    }
}
