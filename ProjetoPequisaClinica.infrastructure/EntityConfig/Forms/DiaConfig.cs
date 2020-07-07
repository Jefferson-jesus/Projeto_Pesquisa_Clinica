using Microsoft.EntityFrameworkCore;
using ProjetoPesquisaClinica.Domain.Entity.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace ProjetoPequisaClinica.infrastructure.EntityConfig.Forms
{
   public class DiaConfig : EntityTypeConfiguration<Dia>
    {
        public DiaConfig()
        {
            HasKey(x => x.DiaId);

            Property(x => x.dt_d)
                .IsOptional();

            Property(x => x.catur_d)
                .IsOptional();

            Property(x => x.vm_d)
                .IsOptional();

            Property(x => x.cvc_d)
                .IsOptional();

            Property(x => x.atb_d)
                .IsOptional()
                .HasMaxLength(400);
            Property(x => x.qatb_d)
                .IsOptional();

            Property(x => x.atbc1_d)
                .IsOptional();
            Property(x => x.qatbc1_d)
                .IsOptional()
                .HasMaxLength(150);

            Property(x => x.atbc2_d)
                .IsOptional();
            Property(x => x.qatbc2_d)
                .IsOptional()
                .HasMaxLength(150);

            Property(x => x.atbc3_d)
                .IsOptional();
            Property(x => x.qatbc3_d)
                .IsOptional()
                .HasMaxLength(150);

            Property(x => x.atbc4_d)
                .IsOptional();
            Property(x => x.qatbc4_d)
                .IsOptional()
                .HasMaxLength(150);

            Property(x => x.atbc5_d)
                .IsOptional();
            Property(x => x.qatbc5_d)
                .IsOptional()
                .HasMaxLength(150);

            Property(x => x.atbc6_d)
                .IsOptional();
            Property(x => x.qatbc6_d)
                .IsOptional()
                .HasMaxLength(150);

            Property(x => x.atbc7_d)
                .IsOptional();
            Property(x => x.qatbc7_d)
                .IsOptional()
                .HasMaxLength(150);

            Property(x => x.atbc8_d)
                .IsOptional();
            Property(x => x.qatbc8_d)
                .IsOptional()
                .HasMaxLength(150);

            Property(x => x.sofaresp_d)
                .IsOptional();
            Property(x => x.sofacoag_d)
                .IsOptional();
            Property(x => x.sofahep_d)
                .IsOptional();
            Property(x => x.sofacard_d)
                .IsOptional();
            Property(x => x.sofasnc_d)
                .IsOptional();
            Property(x => x.sofaren_d)
                .IsOptional();

            Property(x => x.sofa_d)
                .IsOptional().HasMaxLength(150);

            ToTable("Pesquisa_Clinica_Dia");
        }

    }
}
