using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using maktabTeamWork.Models
namespace maktabTeamWork.Datebase
{
    class AppDB
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee{EmployeeID= 1,FName="Omid", LName="khaleghi",Nationalcode="1111111111",Mobile="111", Gender=Genders.Male ,Email="omid@gmail.com"},
            new Employee{EmployeeID= 2,FName="Bita", LName="Nazari",Nationalcode="2222222222",Mobile="222", Gender=Genders.Female ,Email="Bita@gmail.com"},
            new Employee{EmployeeID= 3,FName="Mohammad", LName="Adeli",Nationalcode="3333333333",Mobile="333", Gender=Genders.Male ,Email="Mohammad@gmail.com"},
            new Employee{EmployeeID= 4,FName="Mohammadhassan", LName="yazdani",Nationalcode="4444444444",Mobile="444", Gender=Genders.Male ,Email="Mohammadhassan@gmail.com"},
            new Employee{EmployeeID= 5,FName="Hossein", LName="Besharati",Nationalcode="5555555555",Mobile="555", Gender=Genders.Male ,Email="Hossein@gmail.com"},
        };
        List<Salary> salaries = new List<Salary>
        {
            new Salary{Id=1, Amount=900, Tax=10, OrtherBenefit=150, EmployeeId=1, Month="Farvardin",Year=1402 },
            new Salary{Id=2, Amount=1200, Tax=10, OrtherBenefit=200, EmployeeId=1, Month="Ordibehesht",Year=1402 },
            new Salary{Id=3, Amount=900, Tax=10, OrtherBenefit=100, EmployeeId=2, Month="Farvardin",Year=1402 },
            new Salary{Id=4, Amount=1000, Tax=10, OrtherBenefit=150, EmployeeId=2, Month="Ordibehesht",Year=1402 },
            new Salary{Id=5, Amount=800, Tax=10, OrtherBenefit=100, EmployeeId=3, Month="Farvardin",Year=1402 },
            new Salary{Id=6, Amount=1000, Tax=10, OrtherBenefit=150, EmployeeId=3, Month="Ordibehesht",Year=1402 },
            new Salary{Id=7, Amount=800, Tax=10, OrtherBenefit=100, EmployeeId=4, Month="Farvardin",Year=1402 },
            new Salary{Id=8, Amount=900, Tax=10, OrtherBenefit=150, EmployeeId=4, Month="Ordibehesht",Year=1402 },
            new Salary{Id=9, Amount=900, Tax=10, OrtherBenefit=150, EmployeeId=5, Month="Farvardin",Year=1402 },
            new Salary{Id=10, Amount=1200, Tax=10, OrtherBenefit=200, EmployeeId=5, Month="Ordibehesht",Year=1402 }
        };
    }
}



