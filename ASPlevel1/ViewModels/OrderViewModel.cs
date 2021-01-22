using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ASPlevel1.ViewModels
{
    public class OrderViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
