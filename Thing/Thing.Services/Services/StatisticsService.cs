using System.Collections.Generic;
using Thing.Data.Interfaces;
using Thing.Data.Repositories;
using Thing.DomainClasses.Models;

namespace Thing.Services.Services
{
  public class StatisticsService
  {
    private static IContext _container;

    private readonly EntityRepository<Person> _personRepository;
    private readonly EntityRepository<InterestingStatisticsSource> _interestingStatisticsSourceRepository;
    private readonly EntityRepository<OtherInterestingStatisticsSource> _otherInterestingStatisticsSourceRepository;


    public StatisticsService(IContext container)
    {
      _container = container;
      _personRepository = new EntityRepository<Person>(_container);
      _interestingStatisticsSourceRepository = new EntityRepository<InterestingStatisticsSource>(_container);
      _otherInterestingStatisticsSourceRepository = new EntityRepository<OtherInterestingStatisticsSource>(_container);
    }


    /// <summary>
    ///   Gets all of the active people in the database. 
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Person> GetActivePeople()
    {
      return _personRepository.Get();
    }


    /// <summary>
    ///   Gets a person based on the given id (primary key)
    /// </summary>
    /// <param name="id">The primary key of the peson.</param>
    /// <returns></returns>
    public Person GetPersonById(int id)
    {
      return _personRepository.First(d => d.Id == id);
    }

    /// <summary>
    ///   Gets all the active records from the Person table that are of type GrandparentManagers. 
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Person> GetActiveGrandparentManagers()
    {
      return _personRepository.Where(p => p.Active && p.PersonType.Id == 3);
    }

  }

}
