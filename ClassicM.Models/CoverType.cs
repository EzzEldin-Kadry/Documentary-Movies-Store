using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicM.Models
{
    public class CoverType
    {
        [Key]
        public int id { get; set; }
        [Required]
        [DisplayName("Cover Type")]
        [StringLength(200,ErrorMessage = "The name is too big")]
        public string Name { get; set; }
    }
}
