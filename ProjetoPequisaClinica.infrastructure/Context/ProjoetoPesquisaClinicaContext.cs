using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
