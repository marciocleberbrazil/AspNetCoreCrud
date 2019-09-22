using Microsoft.EntityFrameworkCore;
using MvcMovie.Domain;
using MvcMovie.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMovie.Infra.Data.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MvcMovieContext context) : base(context)
        {

        }

        public MvcMovieContext MvcMovieContext
        {
            get { return Context as MvcMovieContext; }
        }

        public IQueryable<string> GetAllGenres()
        {
            return MvcMovieContext.Movie.OrderBy(m => m.Genre).Select(m => m.Genre);
        }
    }
}
