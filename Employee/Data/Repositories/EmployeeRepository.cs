using Accounting.Data.Context;
using Accounting.Data.Interfaces.Repositories;
using Accounting.Domain.Models;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Accounting.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<Employee> GetById(Guid id)
        {
            using (var context = new AccountingContext())
            {
                return await context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            }
        }

        public async Task<Employee> Create(Employee employee)
        {
            using (var context = new AccountingContext())
            {
                context.Employees.Add(employee);
                await context.SaveChangesAsync();
                return await GetById(employee.Id);
            }
        }

        public async Task<Employee> Update(Employee employee)
        {
            throw new NotImplementedException();
        }
        public async Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}