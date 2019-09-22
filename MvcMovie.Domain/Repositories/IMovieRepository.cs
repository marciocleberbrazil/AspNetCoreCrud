using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMovie.Domain.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IQueryable<string> GetAllGenres();
    }
}
