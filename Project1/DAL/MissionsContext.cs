using Project1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project1.DAL
{
    public class MissionsContext : DbContext
    {
        public MissionsContext() : base("MissionsContext")
        {

        }

        public DbSet<Mission> Missions { get; set; }
    }
}