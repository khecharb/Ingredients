using System;
using System.Data.Entity;


namespace Ingredients.Models {
    public class Ingredient {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Units { get; set; }
        public string Sku { get; set; }
        public string Supplier { get; set; }
    }

    public class IngredientDBContext : DbContext {
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}