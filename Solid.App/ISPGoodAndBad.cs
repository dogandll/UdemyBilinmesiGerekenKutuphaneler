namespace Solid.App.ISPGoodAndBad
{

    //Class Library Read Impl.
    //Class Library Create/Update/Delete Impl.

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // 1.Example  Class  Bad Library

    //public interface IProductRepository
    //{
    //    List<Product> GetList();
    //    Product GetById(int id);
    //    Product Create(Product product);
    //    Product Update(Product product);
    //    Product Delete(int id); 
    //} 


    //ReadProductRepository -> Sadece okuma yapması gerekiyor fakat diğer crud opersyonları da barındırdığı için bu prensibe uygun olmamaktadır. Bu kodu aşağıda daha iyi hale nasıl gideriyorum.
    //public class ReadProductRepository : IProductRepository
    //{
    //    public Product Create(Product product)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Product> GetList()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Update(Product product)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


     
    // 2.Example  Class  Bad Library
    //Burada okuma ve yazma sınıflarını birbirinden ayırdık 
    public interface IReadRepository
    {
        List<Product> GetList();
        Product GetById(int id);
    }
    public interface IWriteRepository
    {
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(int id);
    }
    public class ReadProductRepository : IReadRepository
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }

    public class WriteProductRepository : IWriteRepository
    {
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
