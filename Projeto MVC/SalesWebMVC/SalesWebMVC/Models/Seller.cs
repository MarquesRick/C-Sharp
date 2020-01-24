using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        /****************Atributes Name*******************************/
        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should between {2} and {1}")]
        public string Name { get; set; }

        /****************Atributes Email*******************************/
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /****************Atributes BirthDate*******************************/
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Birth Date")] //Customizar o label (head) do display
        [DataType(DataType.Date)] //Tirar horas e minutos do create new
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")] //0 indica valor do atributo
        public DateTime BirthDate { get; set; }

        /****************Atributes BaseSalary*******************************/
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        public double BaseSalary { get; set; }

        /****************Atributes Department*******************************/
        public Department Department { get; set; }

        /****************Atributes Department Id*******************************/
        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //Utilizando Linq
            //Retornar vendas onde SR tal que Sr. Date for maior ou igual data inicial e Sr. Date for menor igual data final. Somar onde SR tal que SR amount
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }


    }
}
