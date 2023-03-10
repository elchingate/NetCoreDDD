using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePerformance
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime  LastSalaryUpgradeDate { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        
    }
}