using MyProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Shared.DTo
{
   public class ArticleDetailsDto
    {
        public Article Article { get; set; }
        public List<Categories> Categories { get; set; }
    }
}
