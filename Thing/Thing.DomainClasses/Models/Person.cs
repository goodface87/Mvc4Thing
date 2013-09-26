using System;
using System.Collections.Generic;

namespace Thing.DomainClasses.Models
{
    public class Person
    {
      private ICollection<Person> _children;
      private ICollection<InterestingStatisticsSource> _interestingStatisticsSources;
      private ICollection<OtherInterestingStatisticsSource> _otherInterestingStatisticsSources; 

        public Person()
        {
          _children = new HashSet<Person>();
          _interestingStatisticsSources = new HashSet<InterestingStatisticsSource>();
          _otherInterestingStatisticsSources = new HashSet<OtherInterestingStatisticsSource>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }

        public virtual Person Parent { get; set; }
        public virtual PersonType PersonType { get; set; }

        public virtual ICollection<Person> Children
        {
            get { return _children; }
            set { _children = value; }
        }

        public virtual ICollection<InterestingStatisticsSource> InterestingStatisticsSources
        {
          get { return _interestingStatisticsSources; }
          set { _interestingStatisticsSources = value; }
        }

        public virtual ICollection<OtherInterestingStatisticsSource> OtherInterestingStatisticsSources
        {
          get { return _otherInterestingStatisticsSources; }
          set { _otherInterestingStatisticsSources = value; }
        }
    }
}
