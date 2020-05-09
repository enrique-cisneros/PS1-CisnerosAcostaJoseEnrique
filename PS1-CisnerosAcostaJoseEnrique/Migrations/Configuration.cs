namespace PS1_CisnerosAcostaJoseEnrique.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PS1_CisnerosAcostaJoseEnrique.Models.EventDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PS1_CisnerosAcostaJoseEnrique.Models.EventDbContext";
        }

        protected override void Seed(PS1_CisnerosAcostaJoseEnrique.Models.EventDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
