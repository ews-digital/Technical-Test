﻿using Microsoft.EntityFrameworkCore;
using TechnicalTest.Data.Context;
using TechnicalTest.Data.Entities;

namespace TechnicalTest.Data
{
    public class ProductDatabaseContext : DbContext, IProductDatabaseContext
    {
        public ProductDatabaseContext(DbContextOptions<ProductDatabaseContext> options) 
            : base(options)
        {

        }        

        public virtual DbSet<Product> Products { get; set; }
    }
}
