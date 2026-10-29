using System;
using System.Collections.Generic;
using System.Text;

namespace usermanagement.Infrastructure.Persistence.Entities
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
