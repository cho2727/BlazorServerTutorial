namespace BlazorServerTutorial.Data
{
    public class WeatherForecastService
    {
        public WeatherForecastService(HttpClient httpClient, TestInject testInject, ILogger<WeatherForecastService> logger)
        {
            _httpClient = httpClient;
            _testInject = testInject;
            _logger = logger;
        }

        private readonly HttpClient _httpClient;
        private readonly TestInject _testInject;
        private readonly ILogger<WeatherForecastService> _logger;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            _logger.LogInformation($"{_testInject.Hello()}");

            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}