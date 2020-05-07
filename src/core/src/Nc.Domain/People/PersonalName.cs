using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Nc.People
{
    public class PersonalName : AuditedEntity<Guid>
    {
        public virtual Guid PersonId { get; protected set; }

        public virtual string FirstName { get; protected set; }
        public virtual string MiddleName { get; protected set; }
        public virtual string LastName { get; protected set; }

        protected PersonalName()
        {

        }

        internal PersonalName(Guid personId, string firstName, string lastName) : this(personId, firstName, null, lastName)
        {

        }

        internal PersonalName(Guid personId, string firstName, string middleName, string lastName)
        {
            Check.NotNull(firstName, nameof(firstName));
            Check.NotNull(lastName, nameof(lastName));

            PersonId = personId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        // based on the anglosphere structure
        //https://en.wikipedia.org/wiki/Personal_name
    }
}
