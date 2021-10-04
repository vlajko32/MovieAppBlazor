using MovieSearch.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSearch.UseCases
{
    public interface ISearchMovies
    {
        Response Execute(string filter, int page);


    }
}
