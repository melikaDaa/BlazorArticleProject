using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Shared.Entities;

namespace MyProject.Shared.DTo
{
    public class CategoryDto
    {
        public List<Categories> Categories { get; set; }
        public int TotalCount { get; set; }
    }
}
