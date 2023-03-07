using Cobra.Domain;
using Cobra.Domain.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cobra.Api.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            var person1 = Guid.NewGuid();
            modelBuilder.Entity<Person>().HasData(
                   new Person() {Id = person1, FirstName = "Nicolas", LastName = "Garcia" },
                    new Person() {Id = Guid.NewGuid(), FirstName = "Lionel", LastName = "Messi" });

            modelBuilder.Entity<Customer>().HasData(
                  new Customer() { Id = Guid.NewGuid(), Age=39,Occupation ="Software Developer",MartialStatus = "Married", PersonId = person1 });

            var order1 = Guid.NewGuid();
            modelBuilder.Entity<Order>().HasData(
                new Order() {Id = order1, PersonId = person1, MethodPurchase = "WebPage", DateCreated = DateTime.Now.AddDays(-30) });

            var product1 = Guid.NewGuid();
            modelBuilder.Entity<Product>().HasData(
               new Product() { Id = product1, ProductId = "1112222333", Name = "TV", Description = "Led", Category = "Electro" });

            modelBuilder.Entity<OrderDetails>().HasData(
              new OrderDetails() { Id = Guid.NewGuid(), ProductId = product1, OrderId = order1, OrderNumber = 1 , ProductOrigin= "China"});
        }
    }
}
