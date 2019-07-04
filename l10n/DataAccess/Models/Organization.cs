using System;

namespace DataAccess.Models
{
    public class Organization : MetaDataEntity
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Organization's name in displayable form ordered according to the End-User's locale and preferences.
        /// </summary>
        public string Name { get; set; }
    }
}
