using Microsoft.EntityFrameworkCore;

using System;


namespace OrderMngmntSystem
{
    public class OrderMngmntDbContext:DbContext
    {
        public OrderMngmntDbContext(DbContextOptions<OrderMngmntDbContext> options) : base(options) { }


        DbSet<Customer> Customers { get; set; }
        DbSet<ProductService> Products { get; set; }
        DbSet<CustomerOrder> customerOrders { get; set; }
    }
}
