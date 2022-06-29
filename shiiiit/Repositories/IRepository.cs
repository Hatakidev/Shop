using shiiiit.Models;
namespace shiiiit.Repositories
{
    public interface IRepository : IDisposable
    {
        User? GetUser(Guid id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(Guid id);
        IEnumerable<Product> GetAllProducts();
        Product? GetProduct(Guid id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);    
        void DeleteProduct(Guid id);
        void Save();
    }
}
