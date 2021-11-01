using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounting.Domain.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public int RegistrationNumber { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsExternalEmployee { get; set; }
        public string PositionName { get; set; }
        public Position Position { get; set; }
    }
}