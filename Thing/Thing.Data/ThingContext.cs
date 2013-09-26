using System.Data.Entity;
using Thing.Data.Interfaces;
using Thing.DomainClasses.Models;

namespace Thing.Data
{
  public class ThingContext : DbContext, IContext
  {
    public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
    {
      return base.Set<TEntity>();
    }

    public new void SaveChanges()
    {
      base.SaveChanges();
    }

    public IDbSet<Person> Persons { get; set; }
    public IDbSet<PersonType> PersonTypes { get; set; }
    public IDbSet<InterestingStatisticsSource> InterestingStatisticsSources { get; set; }
    public IDbSet<OtherInterestingStatisticsSource> OtherInterestingStatisticsSources { get; set; }
  }
}
