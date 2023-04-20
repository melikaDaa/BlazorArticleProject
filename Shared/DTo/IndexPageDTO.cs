using MyProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Shared.DTo
{
   public class IndexPageDTO
    {
        public List<Article> Copyright { get; set; }
        public List<Article> ReleasesTime { get; set; }
    }
}
