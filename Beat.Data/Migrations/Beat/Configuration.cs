using Beat.Model;

namespace Beat.Data.Migrations.Beat
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BeatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\Beat";
        }

        protected override void Seed(BeatContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var member = new Member();
            member.Id = 1;
            member.Name = "ahmad";
            member.BirthDate=DateTime.Now;
            member.JoinDate=DateTime.Now;

            context.Members.AddOrUpdate(member);
        }
    }
}
