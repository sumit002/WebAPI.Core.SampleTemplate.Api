using System;

namespace Expenses.Data.Model.Interfaces
{
    /// <summary>
    /// Interface for entities that provide audit fields.
    /// </summary>
    public interface IAuditFields
    {
        Guid CreatedById { get; set; }
        DateTime CreatedOn { get; set; }
        Guid ModifiedById { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}
