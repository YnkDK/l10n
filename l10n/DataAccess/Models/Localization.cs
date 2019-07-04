using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Localization : OrganizationBoundEntity
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public Guid LocalizationId { get; set; }

        /// <summary>
        /// The appropriate translation for the given locale.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The locale related to the translation.
        /// </summary>
        [ForeignKey("LocaleId")]
        public Locale Locale { get; set; }

        /// <summary>
        /// The phrase related to the translation.
        /// </summary>
        [ForeignKey("PhraseId")]
        public Phrase Phrase { get; set; }

    }
}
