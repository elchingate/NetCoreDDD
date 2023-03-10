using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePerformance
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
    }
}