namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar" });

            _products.Add(new Product { ProductId = 1, Name = "IPhone 14", Price = 40000, IsActive = true, CategoryId = 1, Image = "1.jpg" });
            _products.Add(new Product { ProductId = 2, Name = "IPhone 15", Price = 50000, IsActive = true, CategoryId = 1, Image = "2.jpg" });
            _products.Add(new Product { ProductId = 3, Name = "IPhone 16", Price = 60000, IsActive = true, CategoryId = 1, Image = "3.jpg" });
            _products.Add(new Product { ProductId = 4, Name = "IPhone 17", Price = 70000, IsActive = true, CategoryId = 1, Image = "4.jpg" });
            _products.Add(new Product { ProductId = 5, Name = "Macbook Air", Price = 80000, IsActive = true, CategoryId = 2, Image = "5.jpg" });
            _products.Add(new Product { ProductId = 6, Name = "Macbook Pro", Price = 90000, IsActive = true, CategoryId = 2, Image = "6.jpg" });
        }
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }
        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (entity != null)
            {
                entity.Name= updatedProduct.Name;
                entity.Price= updatedProduct.Price;
                entity.IsActive= updatedProduct.IsActive;
                entity.CategoryId= updatedProduct.CategoryId;
                entity.Image= updatedProduct.Image;
            }
        }

    }
}
