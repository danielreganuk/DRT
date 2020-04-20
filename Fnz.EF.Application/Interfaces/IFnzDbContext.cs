﻿using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace DRT.Application.Interfaces
{
    public interface IFnzDbContext
    {
        DbSet<T> Set<T>() where T : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}