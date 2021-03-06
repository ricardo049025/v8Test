using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Dtos
{
    /// <summary>
    /// Ricardo Martinez
    /// Method for return a DTO with the
    /// columns required for the client
    /// in the frontend
    /// </summary>
    public class SalaryCalculateDTO
    {
        public string FullName { set; get; }
        public string Divition { set; get; }
        public string Position { set; get; }
        public string BeginDate { set; get; }
        public string Birthday { set; get; }
        public string IdentificationNumber { set; get; }
        public int grade { set; get; }
        public string office { set; get; }
        public decimal TotalSalary { set; get; }

    }
}
