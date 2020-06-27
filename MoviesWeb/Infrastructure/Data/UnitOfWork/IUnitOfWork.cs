using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Infrastructure.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
        void BeginTransaction();
    }
}
