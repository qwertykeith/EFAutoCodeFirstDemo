namespace DatabaseBit.Migrations
{
    using DatabaseBit.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseBit.Contexts.SomeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DatabaseBit.Contexts.SomeDBContext context)
        {

            context.ALinkedTable.AddOrUpdate(new SomeTable()
            {
                ID = Guid.Parse("3148c191-7236-4092-9449-2ce0b29f9d72"),
                IAmMadeByMagic=true,
                Title="1234567"
            });

            context.ALinkedTable.AddOrUpdate(new SomeTable()
            {
                ID = Guid.Parse("f0d01e5b-4281-439b-b0f2-6e1ee0a43f7b"),
                IAmMadeByMagic = true,
                Title = "abcdefg"
            });

            base.Seed(context);
        }
    }

}
