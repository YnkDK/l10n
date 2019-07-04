using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Organization : BaseModel
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
