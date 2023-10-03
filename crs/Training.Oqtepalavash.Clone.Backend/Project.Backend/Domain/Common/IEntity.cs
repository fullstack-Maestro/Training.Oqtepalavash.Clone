using FileBaseContext.Abstractions.Models.Entity;
using FileBaseContext.Abstractions.Models.FileSet;

namespace Project.Backend.Domain.Common;

public interface IEntity : IFileSetEntity<Guid>
{
}