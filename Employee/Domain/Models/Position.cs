using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounting.Domain.Models
{
    public class Position
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
    }
}