namespace Warehouse.Migrations
{
    using System.Data.Entity.Migrations;
    using Warehouse.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.WarehouseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Warehouse.Models.WarehouseContext";
        }

        protected override void Seed(WarehouseContext db)
        {

            db.Products.AddOrUpdate(
              p => p.Name,
              new Product { Name = "Toaster 2010", Price = 1399, Quantity = 12, Category = "appliances" },
              new Product { Name = "Waffler NG", Price = 139, Quantity = 19, Category = "appliances" },
              new Product { Name = "Trilobite 2", Price = 2399, Quantity = 120, Category = "appliances" }
          );
        }
    }
}
