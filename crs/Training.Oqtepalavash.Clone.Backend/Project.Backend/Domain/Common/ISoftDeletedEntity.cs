﻿namespace Project.Backend.Domain.Common;

public interface ISoftDeletedEntity : IAuditableEntity
{
    bool IsDeleted { get; set; }

    DateTimeOffset? DeletedDate { get; set; }
}