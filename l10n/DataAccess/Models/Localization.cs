using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class Localization : MetaDataEntity
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public Guid LocalizationId { get; set; }

        /// <summary>
        /// The appropriate translation for the given locale.
        /// </summary>
        [MaxLength(2047)]
        [Required]
        public string Value { get; set; }

        /// <summary>
        /// The locale related to the translation.
        /// </summary>
        [ForeignKey("LocaleId")]
        [Required]
        public Locale Locale { get; set; }

        /// <summary>
        /// The phrase related to the translation.
        /// </summary>
        [ForeignKey("PhraseId")]
        [Required]
        public Phrase Phrase { get; set; }

    }
}
