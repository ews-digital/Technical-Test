using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TechnicalTest.Data.Entities;

namespace TechnicalTest.Data.Context
{
    public interface IProductDatabaseContext
    {
        DbSet<Product> Products { get; set; }

        int SaveChanges();
    }
}