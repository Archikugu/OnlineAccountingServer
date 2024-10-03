﻿namespace OnlineAccountingServer.Domain.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
