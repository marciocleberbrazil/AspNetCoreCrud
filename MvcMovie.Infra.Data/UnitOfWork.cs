using MvcMovie.Domain;
using MvcMovie.Domain.Repositories;
using MvcMovie.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvcMovie.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MvcMovieContext _context;

        public UnitOfWork(MvcMovieContext context)
        {
            _context = context;
            Movies = new MovieRepository(_context);
        }

        public IMovieRepository Movies { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
