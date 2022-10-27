using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Employee
    {

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }

      //  https://www.youtube.com/watch?v=CdE6rVfPJ9I&ab_channel=SameerSaini      start from 40 minutes
      //Tools --> NuGet Package manager --> Package Manager Console
      // Add-Migration "Initial Migration"
      // Update-Database
        
    }
}
