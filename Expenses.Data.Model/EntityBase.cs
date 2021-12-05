using Expenses.Data.Model.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Expenses.Data.Model
{
    /// <summary>
    /// Base class for database entities.
    /// </summary>
    public class EntityBase : IAuditFields, IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid ModifiedById { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
