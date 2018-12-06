using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NET_Teach_GQL_Appointment.MVCModel;

namespace NET_Teach_GQL_Appointment.Models
{
    public class MVCDbContext : DbContext
    {
        private static bool _created = false;
        public MVCDbContext (DbContextOptions<MVCDbContext> options)
            : base(options)
        {
            /*
            Database.EnsureDeleted();
            _created = false; // */

            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        public DbSet<NET_Teach_GQL_Appointment.MVCModel.Customer> Customer { get; set; }

        public DbSet<NET_Teach_GQL_Appointment.MVCModel.Order> Order { get; set; }

        public DbSet<NET_Teach_GQL_Appointment.MVCModel.Team> Team { get; set; }

        public DbSet<NET_Teach_GQL_Appointment.MVCModel.Player> Player { get; set; }
    }
}
