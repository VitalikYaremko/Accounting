using Accounting.Data.Interfaces.Repositories;
using Accounting.Data.Interfaces.Services;
using Accounting.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Accounting.Domain.Services
{
    //private readonly IMapper _mapper;
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> GetById(Guid id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task<Employee> Create(Employee employee)
        {
            return await _employeeRepository.Create(employee);
        }

        public Task<Employee> Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}