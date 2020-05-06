using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Actividad3_DACS.Models
{
    public class MyDbContext : DbContext
    {
    public MyDbContext()
        :base(nameOrConnectionString: "<add connectionString=”Server=(local);Database=MyDbContext;Trusted_Connection=True;MultipleActiveResultSets=true” name=”MyDbContext” providerName=”System.Data.SqlClient”/>")
    {}

    public DbSet<Client> Clients { get; set;}

    public DbSet<Sale> Sales { get; set;}
    }
    }