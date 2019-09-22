using MvcMovie.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvcMovie.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository Movies { get; }
        int Complete();
        Task<int> CompleteAsync();
    }
}
