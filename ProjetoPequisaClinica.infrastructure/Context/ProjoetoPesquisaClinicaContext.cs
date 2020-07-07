using Microsoft.EntityFrameworkCore;
using ProjetoPequisaClinica.infrastructure.EntityConfig.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPequisaClinica.infrastructure.Context
{
    public class ProjoetoPesquisaClinicaContext : DbContext
    {
        public ProjoetoPesquisaClinicaContext(DbContextOptions options)
            : base(options)
        {}

        public DbSet<DiaConfig> Dias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
