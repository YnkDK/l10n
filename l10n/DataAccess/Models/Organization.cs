using System;
using System.ComponentModel.DataAnnotations;

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
        [MaxLength(255)]
        [Required]
        public string Name { get; set; }
    }
}
