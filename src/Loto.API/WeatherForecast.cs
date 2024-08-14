using LotoBackend.API.Controllers;

namespace LotoBackend.API;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
    
    public static WeatherForecast FunctionToBeInSelect(int novoInt)
    {
        string[] summariesInternal = WeatherForecastController.Summaries;
        WeatherForecast wf = new WeatherForecast();
        wf.Date = DateOnly.FromDateTime(DateTime.Now.AddDays(novoInt));
        wf.TemperatureC = Random.Shared.Next(-20, 55);
        wf.Summary = summariesInternal[Random.Shared.Next(summariesInternal.Length)];

        return wf;
    }
}