using Microsoft.EntityFrameworkCore;
using YungChingDemo.Models;

namespace YungChingDemo.Repository
{
    public interface IEmployeeRepository
    {
        // Create
        void AddEmployee(Employees employee);


        // Read
        Employees GetEmployeeById(int employeeId);


        List<Employees> GetAllEmployees();


        // Update
        void UpdateEmployee(Employees updatedEmployee);


        // Delete
        void DeleteEmployee(int employeeId);
       

    }

    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly YCDBContext _dbContext;

        public EmployeeRepository(YCDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create
        public void AddEmployee(Employees employee)
        {
            _dbContext.Set<Employees>().Add(employee);
            _dbContext.SaveChanges();
        }

        // Read
        public Employees GetEmployeeById(int employeeId)
        {
            return _dbContext.Set<Employees>().Find(employeeId);
        }

        public List<Employees> GetAllEmployees()
        {
            return _dbContext.Set<Employees>().ToList();
        }

        // Update
        public void UpdateEmployee(Employees updatedEmployee)
        {
            _dbContext.Update(updatedEmployee);
            _dbContext.SaveChanges();
        }

        // Delete
        public void DeleteEmployee(int employeeId)
        {
            var employeeToDelete = _dbContext.Set<Employees>().Find(employeeId);
            if (employeeToDelete != null)
            {
                _dbContext.Set<Employees>().Remove(employeeToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}
