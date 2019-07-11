using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Phrase : OrganizationBoundEntity
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public Guid PhraseId { get; set; }

        /// <summary>
        /// Any group of words, or sometimes a single word, which plays a particular
        /// role within the grammatical structure of a sentence.
        /// </summary>
        [MaxLength(2047)]
        [Required]
        public string Key { get; set; }
    }
}
