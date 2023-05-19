using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maktabTeamWork.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public  decimal Amount { get; set; }    
        public decimal Tax { get; set; }
        public decimal OrtherBenefit { get; set; }
        public int EmployeeId { get; set; } 
        public int Year { get; set; }   
        public string Month { get; set; }
    }
}
