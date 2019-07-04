using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class User : OrganizationBoundEntity
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Identifier for the End-User at the Issuer.
        /// </summary>
        [MaxLength(255)]
        [Required]
        public string Subject { get; set; }

        /// <summary>
        /// End-User's full name in displayable form including all name parts, possibly including titles and suffixes,
        /// ordered according to the End-User's locale and preferences.
        /// </summary>
        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// End-User's preferred e-mail address. Its value MUST conform to the RFC 5322 [RFC5322] addr-spec syntax.
        /// </summary>
        [MaxLength(255)]
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// URL of the End-User's profile picture. This URL MUST refer to an image file (for example, a PNG, JPEG, or GIF image file),
        /// rather than to a Web page containing an image. 
        /// Note that this URL SHOULD specifically reference a profile photo of the End-User suitable for displaying when describing the End-User,
        /// rather than an arbitrary photo taken by the End-User.
        /// </summary>
        [MaxLength(2047)]
        public string Picture { get; set; }
    }
}
