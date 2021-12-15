using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Dtos
{
    public class EmployeeDTO
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public string SurName { set; get; }
        public DateTime BeginDate { set; get; }
        public DateTime BirthDay { set; get; }
        public string IdentificationNumber { set; get; }
        public decimal BaseSalary { set; get; }
    }
}
