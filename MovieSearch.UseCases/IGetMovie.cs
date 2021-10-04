using MovieSearch.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSearch.UseCases
{
    public interface IGetMovie
    {
        Movie Execute(int id);
    }
}
