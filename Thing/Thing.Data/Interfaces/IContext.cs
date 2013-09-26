using System;
using System.Data.Entity;
using Thing.DomainClasses.Models;

namespace Thing.Data.Interfaces
{
  public interface IContext : IDisposable
  {
    IDbSet<Person> Persons { get; set; }
    IDbSet<PersonType> PersonTypes { get; set; }
    IDbSet<InterestingStatisticsSource> InterestingStatisticsSources { get; set; }
    IDbSet<OtherInterestingStatisticsSource> OtherInterestingStatisticsSources { get; set; }
    IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    void SaveChanges();
  }
}
