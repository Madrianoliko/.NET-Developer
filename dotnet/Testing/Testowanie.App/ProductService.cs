namespace Testowanie.App;

public record Product(int Id, string Name);

public interface IProductRepository
{
    Product GetProduct(int id);
}

public class ProductRepository : IProductRepository
{
    public Product GetProduct(int id)
    {
        return new Product(id, "Product Name");
    }
}

public interface IProductService
{
    Product GetProduct(int id);
}
public class ProductService(IProductRepository productRepository) : IProductService
{
    public Product GetProduct(int id)
    {
        return productRepository.GetProduct(id);
    }
}
