using System;

namespace Expenses.Data.Model.Interfaces
{
    public interface IEntityBase
    {
        /// <summary>
        /// Primary key / Id of the database record.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Id of the user that created the record.
        /// </summary>
        Guid CreatedById { get; set; }

        /// <summary>
        /// UTC time that the database record was created.
        /// </summary>
        DateTime CreatedOn { get; set; }

        /// <summary>
        /// Id of the user that last modified the record.
        /// </summary>
        Guid ModifiedById { get; set; }

        /// <summary>
        /// UTC time that the database record was last modified.
        /// </summary>
        DateTime ModifiedOn { get; set; }
    }
}
