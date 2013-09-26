using System;
using System.Collections.Generic;

namespace Thing.DomainClasses.Models
{
    public class PersonType
    {
        private ICollection<Person> _people;

        public PersonType()
        {
            _people = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Person> People
        {
            get { return _people; }
            set { _people = value; }
        }
    }
}
