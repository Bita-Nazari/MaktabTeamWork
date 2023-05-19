using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maktabTeamWork.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FName { get; set; }  
        public string LName { get; set; }   
        public  string Nationalcode { get; set; }
        public string Mobile { get; set; }
        public Genders Gender { get; set; }  
        public string Email { get; set; }
    }
}
