using YungChingDemo.Models;
using YungChingDemo.Repository;

namespace YungChingDemo.Service
{
    public interface ICustomerService
    {
        List<Customers> GetAllCustomer();

        Customers GetCustomerById(int employeeId);

        void AddCustomer(Customers customer);

        void UpdateCustomer(Customers customer);

        void DeleteCustomer(int customerId);
       
    }

    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customers> GetAllCustomer()
        {
            return _customerRepository.GetAllCustomers();
        }

        public Customers GetCustomerById(int employeeId)
        {
            return _customerRepository.GetCustomerById(employeeId);
        }

        public void AddCustomer(Customers customer)
        {
            _customerRepository.AddCustomer(customer);
        }

        public void UpdateCustomer(Customers customer)
        {
            _customerRepository.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            _customerRepository.DeleteCustomer(customerId);
        }
    }

   
}
