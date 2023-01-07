namespace ASP.NET_PA1._2_z4_Blzr.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(
            DateTime startDate,
            int numberOfDays = 5
            )
        {
            WeatherForecast[] rezultat = new WeatherForecast[numberOfDays];
            for(int index = 0; index < rezultat.Length; index++)
                rezultat[index] = new WeatherForecast()
                {
                    Date = startDate.AddDays(index+1),
                    TemperatureC = Random.Shared.Next(-20,55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                };
            return Task.FromResult(rezultat);
            /*return Task.FromResult(
                Enumerable.Range(1, numberOfDays).Select(
                    index => new WeatherForecast
                    {
                        Date = startDate.AddDays(index),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                    }
                    ).ToArray()
                );*/
        }
    }
}