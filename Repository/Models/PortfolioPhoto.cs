using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class PortfolioPhoto:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Photo { get; set; }
        public ICollection<PortfolioIcon> Icons { get; set; }
        public int PhortfolioLevelId { get; set; }


    }
}
