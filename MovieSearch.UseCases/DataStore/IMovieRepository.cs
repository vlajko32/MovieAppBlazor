using MovieSearch.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSearch.UseCases.DataStore
{
    public interface IMovieRepository
    {
        Response GetMovies(string filter, int page);

        Movie GetMovie(int id);
    }
}
