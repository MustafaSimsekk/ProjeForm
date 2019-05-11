using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Contexts
{
    public class FormDBContext:DbContext
    {
        public FormDBContext() : base("FormDB") 
        {
        }
        public DbSet<FormList> FormList { get; set; }
        public DbSet<Login> Login { get; set; }

    }
}
