using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Models
{
    [Table("FormList")]
    public class FormList
    {
        [Key]
        public int FormId { get; set; }
        public string FormName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public int UserAge { get; set; }

    }
}
