using System;
namespace Domain.Domain.Dtos
{
    public class SalaryPrincipalDTO
    {
        public int id { set; get; }
        public int year { set; get; }
        public int month { set; get; }
        public string name { set; get; }
        public string surname { set; get; }
        public int grade { set; get; }
        public DateTime beginDate { set; get; }
        public DateTime birthday { set; get; }
        public string identification { set; get; }
        public string employeeCode { set; get; }
        public decimal baseSalary { set; get; }
        public decimal productionBonus { set; get; }
        public decimal compensationBonus { set; get; }
        public decimal comission { set; get; }
        public decimal contribution { set; get; }
        public int officeId { set; get; }
        public int divisionId { set; get; }
        public int positionId { set; get; }
    }
}
