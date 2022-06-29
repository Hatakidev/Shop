using shiiiit.Models;
using Microsoft.EntityFrameworkCore;

namespace shiiiit.Repositories
{
    public class MainRepository : IRepository
    {
        private readonly ShopContext context;
        
        public User? GetUser(Guid id)
        {
            return context.Users.Find(id);
        }
        public void CreateUser(User user)
        {
            context.Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            context.Entry(user).State = EntityState.Modified;
        }
        public void DeleteUser(Guid id)
        {
            User? user = context.Users.Find(id);
            if(user != null) context.Users.Remove(user);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return context.Products;
        }
        public void CreateProduct(Product product)
        {
            context.Products.Add(product);
        }
        public Product? GetProduct(Guid id)
        {
            return context.Products.Find(id);
        }
        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
        }
        public void DeleteProduct(Guid id)
        {
            Product? product = context.Products.Find(id);
            if(product != null) context.Products.Remove(product);
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
