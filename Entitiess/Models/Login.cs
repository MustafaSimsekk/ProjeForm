using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Models
{
    [Table("UserTb")]
    public class Login
    {
        [Key]
        public int UserID { get; set; }
       
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
