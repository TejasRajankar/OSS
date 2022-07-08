using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIProject.Models;
using System.Data.Entity;
using MySql.Data.EntityFramework;
//new comment
namespace WebAPIProject.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DbORMContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbORMContext() : base("WebAppCon")
        {
        }
    }
}
// comment by rishabh
// Comment by Rohit
