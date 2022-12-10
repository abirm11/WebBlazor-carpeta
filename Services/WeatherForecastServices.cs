using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static WebBlazor.Pages.FetchData;

namespace BlazorServices
{
     public class WeatherForecastServices : IWeatherForecastServices
     {
          //Constructor para Nuneable
          public WeatherForecastServices(HttpClient http)
          {
               Http = http;
          }

          //metodo para http
          public HttpClient Http {get; set;}

          //Metodo ansincronico para inyeccion de dependecias
          public async Task<WeatherForecast[]> GetWeatherForecasts()
          {
               return await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
          }
     }

     //Interfaz para invocar dependecia
     public interface IWeatherForecastServices
     {
          Task<WeatherForecast[]> GetWeatherForecasts();
     }


}


 







