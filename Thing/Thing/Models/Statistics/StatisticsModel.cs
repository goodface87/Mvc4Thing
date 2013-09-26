using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Thing.DomainClasses.Models;

namespace Thing.Models.Statistics
{
  public class StatisticsModel
  {
    public StatisticsModel()
    {
    }

    public StatisticsModel(Person person)
    {
      Id = person.Id;
      FirstName = person.FirstName;
      LastName = person.LastName;
      DateOfBirth = person.DateOfBirth;
      var interestingStatisticsSource = person.InterestingStatisticsSources.FirstOrDefault();
      if (interestingStatisticsSource != null)
      {
        TotalSomething = interestingStatisticsSource.TotalSomething;
        TotalDigitalSomething = interestingStatisticsSource.TotalDigitalSomething;
      }

      var otherInterestingStatisticsSource = person.OtherInterestingStatisticsSources.FirstOrDefault();
      if (otherInterestingStatisticsSource != null)
      {
        TotalUnitsWorked = otherInterestingStatisticsSource.TotalUnitsWorked;
        TotalDigitalUnitsWorked = otherInterestingStatisticsSource.TotalDigitalUnitsWorked;
      }
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [DisplayFormat(DataFormatString = "{0:d}")]
    public DateTime DateOfBirth { get; set; }
    public int TotalSomething { get; set; }
    public double PercentageOfSomething { get; set; }
    public int TotalDigitalSomething { get; set; }
    public int TotalUnitsWorked { get; set; }
    public int TotalDigitalUnitsWorked { get; set; }
  }
}