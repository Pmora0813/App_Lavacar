using App_Lavacar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Lavacar.Data
{
    public class AplicationDB_Conctext : DbContext
    {
        public AplicationDB_Conctext(DbContextOptions<AplicationDB_Conctext> options) :base(options)
        {

        }


        public DbSet<Vehiculo> Vehiculo { get; set; }



    }
}
