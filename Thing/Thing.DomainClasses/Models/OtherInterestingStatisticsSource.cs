using System;

namespace Thing.DomainClasses.Models
{
    public class OtherInterestingStatisticsSource
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public int TotalUnitsWorked { get; set; }
      public int TotalDigitalUnitsWorked { get; set; }
      public string CreatedBy { get; set; }
      public DateTime CreatedDate { get; set; }
      public string ModifiedBy { get; set; }
      public DateTime ModifiedDate { get; set; }
      public bool Active { get; set; }

      public virtual Person Person { get; set; }
    }
}
