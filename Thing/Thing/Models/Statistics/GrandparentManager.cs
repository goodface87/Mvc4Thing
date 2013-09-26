using System.Collections.Generic;
using System.Linq;
using Thing.DomainClasses.Models;

namespace Thing.Models.Statistics
{
  public class GrandparentManager : StatisticsModel
  {
    public IEnumerable<Manager> Managers { get; set; } 
    public GrandparentManager()
    {
      Managers = new List<Manager>();
    }
    public GrandparentManager(Person person) : base(person)
    {
      Managers = person.Children.Select(c => new Manager(c));
    }
  }}