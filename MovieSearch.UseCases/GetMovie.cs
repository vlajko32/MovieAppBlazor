using MovieSearch.CoreBusiness.Model;
using MovieSearch.UseCases.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSearch.UseCases
{
    public class GetMovie : IGetMovie
    {
        private readonly IMovieRepository movieRepository;

        public GetMovie(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }
        public Movie Execute(int id)
        {
            return movieRepository.GetMovie(id);
        }
    }
}
