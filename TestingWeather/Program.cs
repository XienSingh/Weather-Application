using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeatherTracker.Models;
using WeatherTracker.WeatherRestClient;

namespace TestingWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenWeatherMap<WeatherMainModel> _openWeatherRest = new OpenWeatherMap<WeatherMainModel>();
            var weather = _openWeatherRest.GetAllWeathers("Your City");
            while(Task.CompletedTask.Status != TaskStatus.RanToCompletion)
            {
                Console.WriteLine($"Waiting on task : {Thread.CurrentThread.ManagedThreadId}");
            }
            Console.WriteLine(weather.Result.main.temp);
            Console.ReadLine();
        }
    }
}
