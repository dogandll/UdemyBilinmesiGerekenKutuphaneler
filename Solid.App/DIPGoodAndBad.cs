namespace Solid.App.DIPGoodAndBad
{
    //Bad
    //public class ProductService
    //{
    //    private readonly ProductRepositoryFromSqlServer _repository;

    //    public ProductService(ProductRepositoryFromSqlServer repository)
    //    {
    //        _repository = repository;
    //    }

    //    public List<string> GetAll()
    //    {
    //        return _repository.GetAll();
    //    }
    //}
    //public class ProductRepositoryFromSqlServer
    //{
    //    public List<string> GetAll()
    //    {
    //        return new List<string>() { "SqlServer Kalem 1", "SqlServer Kalem 2 " };
    //    }
    //}



    //Good

    public class ProductGoodService
    {
        private readonly IRepository _repository;

        public ProductGoodService(IRepository repository)
        {
            _repository = repository;
        }
        public List<string> GetAll()
        {
            return _repository.GetAll();
        }

        public interface IRepository
        {
            List<string> GetAll();
        }
        public class ProductRepositoryFromSqlServer : IRepository
        {
            public List<string> GetAll()
            {
                return new List<string>() { "SqlServer Kalem 1", "SqlServer Kalem 2 " };
            }
        }
        public class ProductRepositoryFromOracle : IRepository
        {
            public List<string> GetAll()
            {
                return new List<string>() { "Oracle Kalem 1", "Oracle Kalem 2 " };
            }
        }
    }
}