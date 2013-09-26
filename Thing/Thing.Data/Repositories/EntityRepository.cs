using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Thing.Data.Interfaces;

namespace Thing.Data.Repositories
{
  /// <summary>
  ///   Entity repository.
  /// </summary>
  public class EntityRepository<T> : IRepository<T> where T : class
  {

    /// <summary>
    ///         Db context.
    /// </summary>
    private readonly IContext _context;


    ///<summary>
    /// Table
    ///</summary>
    private readonly IQueryable<T> _table;

    /// <summary>
    ///         Key property column name.
    /// </summary>
    private string _keyProperty = "Id";

    #region Constructor and Initialization


    /// <summary>
    ///         Initialize the entity repository with an object context.
    /// </summary>
    /// <param name="objectContext"> </param>
    public EntityRepository(IContext objectContext)
    {
      _context = objectContext;
      _table = objectContext.Set<T>();
    }


    #endregion

    #region Implementation of IRepository<T>

    /// <summary>
    ///         Returns an entity based on its primary key integer value.
    /// </summary>
    /// <param name="id"> Integer value of the entity's primary key column. </param>
    /// <returns> Entity object. </returns>
    public T Get(int id)
    {
      return _context.Set<T>().Find(id);
    }

    /// <summary>
    ///         Returns all entities in the table.
    /// </summary>
    /// <returns> Enumerable collection of all entities in a table. </returns>
    public IEnumerable<T> Get()
    {
      return _table;
    }

    ///<summary>
    /// Returns the first entity.
    ///</summary>
    ///<returns> First entity found. </returns>
    public T First()
    {
      return _table.FirstOrDefault();
    }

    /// <summary>
    ///         Returns the first entity that matches a specific expression condition.
    /// </summary>
    /// <param name="where"> Predicate function to test each entity. </param>
    /// <returns> First entity found. </returns>
    public T First(Expression<Func<T, bool>> @where)
    {
      return _table.FirstOrDefault(@where);
    }


    /// <summary>
    ///         Returns entities that match a specific expression condition.
    /// </summary>
    /// <param name="where"> Predicate function to test each entity. </param>
    /// <returns> Enumerable collection of all entities that match expression. </returns>
    public IEnumerable<T> Where(Expression<Func<T, bool>> @where)
    {
      return _table.Where(@where);
    }

    /// <summary>
    ///   Returns a List of entities.
    /// </summary>
    /// <returns> A List of entities. </returns>
    public List<T> ToList()
    {
      return _table.ToList();
    }

    /// <summary>
    ///  Returns a boolean indicating a match of a specific expression condition.
    /// </summary>
    /// <param name="any"> Predicate function to test each entity. </param>
    /// <returns> True if there are entities that match the expresssion. Otherwise, false. </returns>
    public bool Any(Expression<Func<T, bool>> @any)
    {
      return _table.Any(@any);
    }

    /// <summary>
    ///         Adds an entity to the data context; to be inserted into the database.
    /// </summary>
    /// <param name="entity"> Entity to add. </param>
    /// <returns> Entity added. </returns>
    public T Add(T entity)
    {
      _context.Set<T>().Add(entity);

      return entity;
    }

    /// <summary>
    ///         Deletes an entity from the database.
    /// </summary>
    /// <param name="entity"> Entity to be deleted. </param>
    public void Delete(T entity)
    {
      _context.Set<T>().Remove(entity);
    }

    /// <summary>
    ///         Deletes a collection of entities from the database.
    /// </summary>
    /// <param name="entities"> List of entities to delete. </param>
    public void Delete(IEnumerable<T> entities)
    {
      foreach (var entity in entities)
        _context.Set<T>().Remove(entity);
    }

    /// <summary>
    ///         Commit changes to the persistance layer.
    /// </summary>
    public void Commit()
    {
      _context.SaveChanges();



    }


    /// <summary>
    /// Updates an entity. Attached to the data context if it is not attached.
    /// </summary>
    /// <param name="entity">Entity to update</param>
    /// <returns> Entity updated. </returns>
    public void Update(T entity)
    {
      _context.Set<T>().Attach(entity);
    }

    #endregion

    #region Public Properties

    /// <summary>
    ///         Key property.
    /// </summary>
    public string KeyProperty
    {
      get { return _keyProperty; }
      set { _keyProperty = value; }
    }

    #endregion

    #region Implementation of IDisposable

    /// <summary>
    ///         Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    public void Dispose()
    {
      _context.Dispose();
    }

    #endregion
  }
}
