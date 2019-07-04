using System;

namespace DataAccess.Models
{
    public class Locale : MetaDataEntity
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public Guid LocaleId { get; set; }

        /// <summary>
        /// The ISO 639-1 alpha-2 code.
        /// Code that represents the name of language
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// The ISO 3166-1 alpha-2 code.
        /// It is a two-letter country code that represent countries, dependent territories, and special areas of geographical interest.
        /// </summary>
        public string CountryCode { get; set; }
    }
}
