using System;
using System.Collections.Generic;
using CustomerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CustomerAPI.Context;
public class CustomerContext : DbContext
{
    public CustomerContext()
    {
    }

    public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Customer>().HasData(
            new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "John123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "Jane123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 3, FirstName = "Smith", LastName = "Dow", Email = "Smith123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 4, FirstName = "Michael", LastName = "John", Email = "Michael123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 5, FirstName = "Brian", LastName = "Brian", Email = "Brian123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 6, FirstName = "Donald", LastName = "Donald", Email = "Donald123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 7, FirstName = "Jesse", LastName = "Jesse", Email = "Jesse123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 8, FirstName = "Juan", LastName = "Juan", Email = "Juan123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 9, FirstName = "Brandon", LastName = "Brandon", Email = "Brandon123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 10, FirstName = "Bradford", LastName = "Bradford", Email = "Bradford123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 11, FirstName = "Riley", LastName = "Riley", Email = "Riley123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 12, FirstName = "Catarino", LastName = "Catarino", Email = "Catarino123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 13, FirstName = "William", LastName = "William", Email = "William123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 14, FirstName = "Michael", LastName = "Michael", Email = "Michael123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 15, FirstName = "James", LastName = "Smith", Email = "James123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 16, FirstName = "Irving", LastName = "Irving", Email = "Irving123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 17, FirstName = "Donald", LastName = "Donald", Email = "Donald123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 18, FirstName = "Ryan", LastName = "Ryan", Email = "Ryan123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 19, FirstName = "Renzy", LastName = "Renzy", Email = "Renzy123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Customer { Id = 20, FirstName = "Arash", LastName = "Arash", Email = "Arash123@email.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now }
        );

    }

}
