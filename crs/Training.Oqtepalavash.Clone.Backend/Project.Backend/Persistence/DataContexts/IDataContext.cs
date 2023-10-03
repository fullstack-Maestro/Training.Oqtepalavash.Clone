namespace Project.Backend.Persistence.DataContexts;

public interface IDataContext : IAsyncDisposable
{
    ValueTask SaveChangesAsync();
}
