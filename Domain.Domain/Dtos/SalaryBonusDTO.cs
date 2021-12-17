using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Dtos
{
    public class SalaryBonusDTO
    {
       public List<SalaryDTO> salaries { set; get; }
        public decimal bonus { set; get; }
    }
}
