using MovieSearch.CoreBusiness.Model;
using MovieSearch.UseCases.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSearch.UseCases
{
    public class SearchMovies : ISearchMovies
    {
        private readonly IMovieRepository movieRepository;

        public SearchMovies(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public Response Execute(string filter, int page)
        {
           return movieRepository.GetMovies(filter, page);
        }
    }
}
