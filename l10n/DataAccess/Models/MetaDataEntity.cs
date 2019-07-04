using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class MetaDataEntity
    {
        /// <summary>
        /// The date and time for when the user was first created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Automatically set on insert or update.
        /// The property is also treated as a concurrency token. This ensures that an exception is thrown if anyone else has modified this row since the row was queried.
        /// </summary>
        [Timestamp]
        public byte[] Updated { get; set; }
    }
}
