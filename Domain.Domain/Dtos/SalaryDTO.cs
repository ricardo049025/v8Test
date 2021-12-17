using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Dtos
{
    public class SalaryDTO
    {
        public int id { set; get; }
        public string fullName { set; get; }
        public string employeeCode { set; get; }
        public int year { set; get; }
        public int month { set; get; }
        public decimal baseSalary { set; get; }
    }
}
