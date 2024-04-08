namespace DatabaseFirstExample.Domain.DataContext
{
    public interface IDbDataContext
    {
        Task<int> SaveChangesAsync(bool autoAudit = true, CancellationToken cancellationToken = default(CancellationToken));

    }
}
