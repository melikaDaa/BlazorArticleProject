using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Shared.DTo
{
    public class UserForAuthenticationDto
    {
        [Required(ErrorMessage = "ایمیل وارد نمایید.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "گذرواژه وارد نمایید.")]
        public string Password { get; set; }
    }
}
