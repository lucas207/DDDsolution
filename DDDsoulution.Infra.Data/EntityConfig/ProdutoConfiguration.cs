using DDDsoulution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DDDsoulution.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome).IsRequired().HasMaxLength(250);

            Property(p => p.Valor).IsRequired();

            HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.ClienteId);
        }
    }
}
