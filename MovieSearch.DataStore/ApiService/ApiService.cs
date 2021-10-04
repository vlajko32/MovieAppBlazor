using MovieSearch.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.DataStore.Helpers
{
    public class ApiService
    {

        public static Response GetMovies(string filter, int page)
        {
            string baseUrl = "https://api.themoviedb.org/3/search/movie?api_key=03b8572954325680265531140190fd2a&query=";
            ApiHelper.InitializeClient();
            HttpResponseMessage message = ApiHelper.httpClient.GetAsync($"{baseUrl}{filter}&page={page}").Result;
            if (message.IsSuccessStatusCode)
            {
                try
                {
                    return message.Content.ReadAsAsync<Response>().Result;
                }
                catch(Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            else
            {
                throw new Exception(message.ReasonPhrase);
            }

        }

        public static Movie GetMovie(int id)
        {
            string baseUrl = "https://api.themoviedb.org/3/movie/";
            string ApiKeyUrl = "?api_key=03b8572954325680265531140190fd2a";
            string languageUrl = "language=en-US";
            ApiHelper.InitializeClient();
            HttpResponseMessage message = ApiHelper.httpClient.GetAsync($"{baseUrl}{id}{ApiKeyUrl}&{languageUrl}").Result;
            if (message.IsSuccessStatusCode)
            {
                try
                {
                    return message.Content.ReadAsAsync<Movie>().Result;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            else
            {
                throw new Exception(message.ReasonPhrase);
            }
        }
    }
}
