using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Nc.People
{

    /// <summary>
    /// The Person Entity
    /// Entity Best Practices: https://docs.abp.io/en/abp/latest/Best-Practices/Entities
    /// </summary>
    public class Person : FullAuditedAggregateRoot<Guid>
    {
        public virtual Guid PersonalNameId { get; protected set; }

        public virtual PersonalName PersonalName { get; protected set; }

        public virtual Gender Gender { get; protected set; }

        public virtual PhysicalAttributes PhysicalAttributes { get; protected set; }

        public virtual DateTime? DateOfBirth { get; protected set; }

        public virtual DateTime? DateOfDeath { get; protected set; }

        protected Person()
        {

        }

        public Person(
            Guid id,
            [NotNull] string firstName, 
            string middleName,
            [NotNull] string lastName,
            DateTime? dateOfBirth = null, 
            Gender gender = Gender.NotSpecified, 
            EyeColor eyeColor = EyeColor.NotSpecified, 
            HairColor hairColor = HairColor.NotSpecified,
            SkinColor skinColor = SkinColor.NotSpecified,
            int? heightCm = null, 
            int? weightKg = null,
            DateTime? dateOfDeath = null) 
            : base(id)
        {

            PersonalName = new PersonalName(id, firstName, middleName, lastName);

            Gender = gender;

            PhysicalAttributes = new PhysicalAttributes(id, eyeColor, hairColor, skinColor, heightCm, weightKg);

            DateOfBirth = dateOfBirth;
            DateOfDeath = dateOfDeath;
        }
    }
}
