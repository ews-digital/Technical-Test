using System;
using TechnicalTest.Data.Context;

namespace TechnicalTest.Data.Database
{
    public class ProductsDatabase : IProductsDatabase
    {
        private readonly Func<IProductDatabaseContext> _contextCreator;

        public ProductsDatabase(Func<IProductDatabaseContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public IProductDatabaseContext OpenContext()
        {
            return _contextCreator.Invoke();
        }
    }
}
