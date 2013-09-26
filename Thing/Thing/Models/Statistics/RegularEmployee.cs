using Thing.DomainClasses.Models;

namespace Thing.Models.Statistics
{
  public class RegularEmployee : StatisticsModel
  {
    public RegularEmployee(){}

    public RegularEmployee(Person person) : base(person)
    {
    }
  }
}