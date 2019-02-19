using TechnicalTest.Data.Context;

namespace TechnicalTest.Data.Database
{
    public interface IProductsDatabase
    {
        IProductDatabaseContext OpenContext();
    }
}