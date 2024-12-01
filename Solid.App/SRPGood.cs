namespace Solid.App.SRPGood
{
    //Single Responsibility Principle (Tek sorumluluk prensibi)  - İyi Kod

    //Entityleri Product
    // Delete update crud operasyonları repository
    // Ekrana yazdırma işlemlerini Presenter class'a ayırarak prensibe uygun şekilde davranılmış oldu.

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ProductPresenter
    {
        public void WriteToConsole(List<Product> ProductList)
        {
            ProductList.ForEach(p => { Console.WriteLine($"{p.Id} - {p.Name}"); });
        }
    } 
    public class ProductRepository
    {
        private static List<Product> ProductList = new List<Product>(); 
        public List<Product> GetProducts => ProductList;

        public ProductRepository()
        {
            ProductList = new()
            {
                new() { Id = 1, Name="Kalem 1" },
                new() { Id = 2, Name="Kalem 2" },
                new() { Id = 3, Name="Kalem 3" },
                new() { Id = 4, Name="Kalem 4" },
                new() { Id = 5, Name="Kalem 5" },
            };
        }
        public void SaveOrUpdate(Product product)
        {
            var hasProduct = ProductList.Any(p => p.Id == product.Id);
            if (!hasProduct)
            {
                ProductList.Add(product);
            }
            else
            {
                var index = ProductList.FindIndex(p => p.Id == product.Id);
                ProductList[index] = product;
            }
        }
        public void Delete(int id)
        {
            var hasProduct = ProductList.Find(x => x.Id == id);

            if (hasProduct == null)
            {
                throw new Exception($"Ürün : {hasProduct.Name} bulunamadı");
            }
            ProductList.Remove(hasProduct);
        }
    }
}
