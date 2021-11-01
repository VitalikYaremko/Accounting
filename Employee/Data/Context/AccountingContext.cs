using Accounting.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Accounting.Data.Context
{
    public class AccountingContext : DbContext
    {
        public AccountingContext() : base("DefaultConnection") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}