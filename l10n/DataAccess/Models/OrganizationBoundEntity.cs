using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class OrganizationBoundEntity : MetaDataEntity
    {
        /// <summary>
        /// The related organization.
        /// </summary>
        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }
    }
}
