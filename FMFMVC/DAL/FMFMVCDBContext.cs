using FMFMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FMFMVC.DAL
{
    public class FMFMVCDBContext : DbContext
    {
            public FMFMVCDBContext()

                :base("name=FMFMVCDBContext")

            {

            }

            public DbSet<Category> Categories { get; set; }
            public DbSet<Company> Companies { get; set; }
            public DbSet<Country> Countries { get; set; }
            public DbSet<Product> Products { get; set; }

        
    }
}