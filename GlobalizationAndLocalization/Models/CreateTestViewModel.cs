using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalizationAndLocalization.Models
{
    public class CreateTestViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

    }
}
