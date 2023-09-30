using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    Id = 1,
                    UserName = "faisalcse3@gmail.com",
                    FirstName = "Md",
                    LastName = "Faisal",
                    EmailAddress = "faisalcse3@gmail.com",
                    Address = "Dhaka",
                    TotalPrice = 100,
                    City = "Dhaka",
                    CVV = "Test",
                    CardName = "Test",
                    CardNumber = "Test",
                    Expiraton = "Test",
                    PaymentMethod = 1,
                    CreatedBy = "Test",
                    CreatedDate = DateTime.Now,
                    PhoneNumber = "01700000000",
                    State = "Test",
                    ZipCode = "Test"
                }
                );

        }
    }
}
