using Accounting.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Data.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(Guid id);
        Task<Employee> Create(Employee employee);
        Task<Employee> Update(Employee employee);
        Task Delete(Guid id);

    }
}
