using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Shared.Entities
{
   public class Categories
    {
        public int Id { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا مقدار وارد نمایید")]
        public string Name { get; set; }
        public virtual  Article Articles { get; set; }
    }
}
