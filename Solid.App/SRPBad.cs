namespace Solid.App.SRPBad
{
    //Single Responsibility Principle (Tek sorumluluk prensibi)  - Kötü Kod

    //Entityleri ,Delete update crud operasyonları ,Ekrana yazdırma işlemlerini tek class'a yükleyerek prensibe  uygun olmayacak şekilde davranıldı.

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> ProductList = new List<Product>();

        public List<Product> GetProducts => ProductList;

        public Product()
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
        public void WriteToConsole()
        {
            ProductList.ForEach(p => { Console.WriteLine($"{p.Id} - {p.Name}"); });
        }
    }
}
