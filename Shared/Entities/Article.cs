using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Shared.Entities
{
   public class Article
    {
        public int ArticleId { get; set; }
        [Required(ErrorMessage = "لطفا مقدار وارد نمایید")]
        public string Title { get; set; }
        public bool InTheater { get; set; }
        public string Sumamary { get; set; }
        public string? Trailer { get; set; }
        public DateTime? ReleasTime { get; set; } 
        public string? Poster { get; set; }
        [Required(ErrorMessage = "لطفا مقدار وارد نمایید")]
        public int CategoryId { get; set; }
        public virtual  Categories Categories { get; set; }
    }
}
