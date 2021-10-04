using MovieSearch.CoreBusiness.Model;
using MovieSearch.DataStore.Helpers;
using MovieSearch.UseCases.DataStore;
using System;
using System.Collections.Generic;

namespace MovieSearch.DataStore
{
    public class MovieRepository : IMovieRepository
    {


        public Movie GetMovie(int id)
        {
            return ApiService.GetMovie(id);
        }

        public Response GetMovies(string filter, int page)
        {
            Response r = ApiService.GetMovies(filter, page);
            return r;
        }
    }
}
