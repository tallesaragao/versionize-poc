using System.Text.Json.Serialization;

namespace Api;

// Classe que representa uma temperatura
public class WeatherForecast
{
    [JsonIgnore]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public string Hash { get; set; } = "static-hash";
}
