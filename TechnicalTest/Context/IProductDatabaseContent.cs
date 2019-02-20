using Microsoft.EntityFrameworkCore;
using System;
using TechnicalTest.Data.Entities;

namespace TechnicalTest.Data.Context
{
    public interface IProductDatabaseContext : IDisposable
    {
        DbSet<Product> Products { get; set; }

        int SaveChanges();
    }
}