using YungChingDemo.Models;
using YungChingDemo.Repository;

namespace YungChingDemo.Service
{
    public interface IOrderService
    {
        List<Orders> GetAllOrder();


        List<Orders> GetOrderByCustomer(int customerId);


        List<Orders> GetOrderByEmployee(int employeeId);


        Orders GetOrderById(int orderId);


        void AddOrder(Orders order);


        void UpdateOrder(Orders order);


        void DeleteOrder(int orderId);
      
    }

    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Orders> GetAllOrder()
        {
            return _orderRepository.GetAllOrders();
        }

        public List<Orders> GetOrderByCustomer(int customerId)
        {
            return _orderRepository.GetCustomerOrders(customerId);
        }

        public List<Orders> GetOrderByEmployee(int employeeId)
        {
            return _orderRepository.GetEmployeeOrders(employeeId);
        }

        public Orders GetOrderById(int orderId)
        {
            return _orderRepository.GetOrderById(orderId);
        }

        public void AddOrder(Orders order)
        {
            _orderRepository.AddOrder(order);
        }

        public void UpdateOrder(Orders order)
        {
            _orderRepository.UpdateOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            _orderRepository.DeleteOrder(orderId);
        }
    }
}
