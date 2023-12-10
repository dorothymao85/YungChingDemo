using YungChingDemo.Models;
using YungChingDemo.Repository;

namespace YungChingDemo.Service
{
    public interface IEmployeeService
    {
        List<Employees> GetAllEmployees();


        Employees GetEmployeeById(int employeeId);


        void AddEmployee(Employees employee);


        void UpdateEmployee(Employees employee);


        void DeleteEmployee(int employeeId);
      

    }

    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<Employees> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public Employees GetEmployeeById(int employeeId)
        {
            return _employeeRepository.GetEmployeeById(employeeId);
        }

        public void AddEmployee(Employees employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public void UpdateEmployee(Employees employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }

        public void DeleteEmployee(int employeeId)
        {
            _employeeRepository.DeleteEmployee(employeeId);
        }
    }
}
