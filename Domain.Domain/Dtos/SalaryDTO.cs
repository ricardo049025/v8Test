using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Dtos
{
    public class SalaryDTO
    {
        public int Id { set; get; }
        public int Year { set; get; }
        public int Month { set; get; }
        public decimal BaseSalary { set; get; }
    }
}
