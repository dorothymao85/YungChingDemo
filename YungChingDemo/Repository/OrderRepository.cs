using Microsoft.EntityFrameworkCore;
using System.Linq;
using YungChingDemo.Models;

namespace YungChingDemo.Repository
{
    public interface IOrderRepository
    {
        // Create
        void AddOrder(Orders order);


        // Read
        public Orders GetOrderById(int orderId);


        List<Orders> GetAllOrders();


        List<Orders> GetCustomerOrders(int customerId);


        List<Orders> GetEmployeeOrders(int employeeId);


        // Update
        void UpdateOrder(Orders updatedOrder);

        // Delete
        void DeleteOrder(int orderId);
       

    }

    public class OrderRepository: IOrderRepository
    {
        private readonly YCDBContext _dbContext;

        public OrderRepository(YCDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create
        public void AddOrder(Orders order)
        {
            _dbContext.Set<Orders>().Add(order);
            _dbContext.SaveChanges();
        }

        // Read
        public Orders GetOrderById(int orderId)
        {
            return _dbContext.Set<Orders>().Find(orderId);
        }

        public List<Orders> GetAllOrders()
        {
            return _dbContext.Set<Orders>().ToList();
        }

        public List<Orders> GetCustomerOrders(int customerId)
        {
            return _dbContext.Set<Orders>().Where(o => o.CustomerID == customerId).ToList();
        }

        public List<Orders> GetEmployeeOrders(int employeeId)
        {
            return _dbContext.Set<Orders>().Where(o => o.EmployeeID == employeeId).ToList();
        }


        // Update
        public void UpdateOrder(Orders updatedOrder)
        {
            _dbContext.Update(updatedOrder);
            _dbContext.SaveChanges();
        }

        // Delete
        public void DeleteOrder(int orderId)
        {
            var orderToDelete = _dbContext.Set<Orders>().Find(orderId);
            if (orderToDelete != null)
            {
                _dbContext.Set<Orders>().Remove(orderToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}
