using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Dtos.Posts
{
    public class SalaryPostDTO
    {
        public string name { set; get; }
        public string surname { set; get; }
        public DateTime fromDate { set; get; }
        public DateTime toDate { set; get; }
        public string code { set; get; }
        public int grade { set; get; }
        public DateTime beginDate { set; get; }
        public DateTime birthDay { set; get; }
        public string identification { set; get; }
        public decimal baseSalary { set; get; }
        public decimal productionBonus { set; get; }
        public decimal compensationBonus { set; get; }
        public decimal comission { set; get; }
        public decimal contribution { set; get; }
        public int officeId { set; get; }
        public int divisionId { set; get; }
        public int positionId { set; get; }
        public bool updateRecord { set; get; }
    }
}
