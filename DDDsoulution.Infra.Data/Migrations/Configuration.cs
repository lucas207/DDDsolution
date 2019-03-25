using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.Migrations;

namespace DDDsoulution.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.ProjetoModeloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexto.ProjetoModeloContext context)
        {
            base.Seed(context);
        }
    }
}
