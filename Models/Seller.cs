using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BasicSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(int iD, string name, string email, DateTime birthDate, double basicSalary, Department department)
        {
            ID = iD;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BasicSalary = basicSalary;
            Department = department;
        }

        public void AddSales(SalesRecord SR)
        {
            Sales.Add(SR);
        }

        public void RemoveSales(SalesRecord SR)
        {
            Sales.Remove(SR);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
         }
    }
}
