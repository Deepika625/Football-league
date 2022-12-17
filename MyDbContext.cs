using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web.Configuration;
using System.Data.Entity;

namespace Football_League.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=conn")
        {

        }

        public DbSet<match> matches { get; set; }
    }
}
      
        
      


    

    
