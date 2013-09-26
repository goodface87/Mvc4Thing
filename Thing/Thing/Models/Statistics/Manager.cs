using System.Collections.Generic;
using System.Linq;
using Thing.DomainClasses.Models;

namespace Thing.Models.Statistics
{
  public class Manager : StatisticsModel
  {
    public IEnumerable<RegularEmployee> Employees { get; set; } 
    public Manager()
    {
      Employees = new List<RegularEmployee>();
    }
    public Manager(Person person) : base(person)
    {
      Employees = person.Children.Select(c => new RegularEmployee(c));
      
    }
  }
}