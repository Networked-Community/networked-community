using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Nc.People
{
    public class PhysicalAttributes : AuditedEntity<Guid>
    {
        public Guid PersonId { get; set; }

        public virtual EyeColor EyeColor { get; protected set; }

        public virtual HairColor NaturalHairColor { get; protected set; }

        public virtual SkinColor SkinColor { get; protected set; }

        /// <summary>
        /// Height in centimeters
        /// </summary>
        public virtual int? HeightCm { get; protected set; }

        /// <summary>
        /// Weight in kilograms
        /// </summary>
        public virtual int? WeightKg { get; protected set; }

        protected PhysicalAttributes()
        {

        }

        internal PhysicalAttributes(Guid personId, EyeColor eyeColor = EyeColor.NotSpecified, HairColor naturalHairColor = HairColor.NotSpecified, SkinColor skinColor = SkinColor.NotSpecified, int? heightCm = null, int? weightKg = null)
        {
            PersonId = personId;
            EyeColor = eyeColor;
            NaturalHairColor = naturalHairColor;
            SkinColor = skinColor;
            HeightCm = heightCm;
            WeightKg = weightKg;
        }
    }
}
