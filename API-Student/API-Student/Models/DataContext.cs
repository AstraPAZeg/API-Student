using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_Student.Models
{
    public class DataContext: DbContext 
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API_Student.Models.Student> Students { get; set; }
    }
}