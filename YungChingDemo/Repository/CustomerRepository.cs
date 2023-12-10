using Microsoft.EntityFrameworkCore;
using YungChingDemo.Models;

namespace YungChingDemo.Repository
{
    public interface ICustomerRepository 
    {
        // Create
        void AddCustomer(Customers customer);


        // Read
        Customers GetCustomerById(int customerId);


        List<Customers> GetAllCustomers();


        // Update
        void UpdateCustomer(Customers updatedCustomer);


        // Delete
        void DeleteCustomer(int customerId);
      
    }

    public class CustomerRepository: ICustomerRepository
    {
     
            private readonly YCDBContext _dbContext;

            public CustomerRepository(YCDBContext dbContext)
            {
                _dbContext = dbContext;
            }

            // Create
            public void AddCustomer(Customers customer)
            {
                _dbContext.Set<Customers>().Add(customer);
                _dbContext.SaveChanges();
            }

            // Read
            public Customers GetCustomerById(int customerId)
            {
                return _dbContext.Set<Customers>().Find(customerId);
            }

            public List<Customers> GetAllCustomers()
            {
                return _dbContext.Set<Customers>().ToList();
            }

            // Update
            public void UpdateCustomer(Customers updatedCustomer)
            {
                _dbContext.Update(updatedCustomer);
                _dbContext.SaveChanges();
            }

            // Delete
            public void DeleteCustomer(int customerId)
            {
                var customerToDelete = _dbContext.Set<Customers>().Find(customerId);
                if (customerToDelete != null)
                {
                    _dbContext.Set<Customers>().Remove(customerToDelete);
                    _dbContext.SaveChanges();
                }
            }

           
    }
}
