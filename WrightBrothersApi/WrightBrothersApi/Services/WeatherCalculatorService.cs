using System.Diagnostics;
using System.Text.Json;

namespace WrightBrothersApi.Services;

public class WeatherCalculatorService
{
    public async Task<WeatherImpactResult> CalculateImpactAsync(string weatherCondition, double baseFuel)
    {
        try
        {
            var scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts", "weather-calculator.js");
            
            var startInfo = new ProcessStartInfo
            {
                FileName = "node",
                Arguments = $"{scriptPath} {weatherCondition} {baseFuel}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = Process.Start(startInfo);
            if (process == null)
                throw new InvalidOperationException("Failed to start Node.js process");

            var output = await process.StandardOutput.ReadToEndAsync();
            await process.WaitForExitAsync();

            var result = JsonSerializer.Deserialize<WeatherImpactResult>(output);
            return result ?? throw new InvalidOperationException("Failed to parse result");
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Weather calculation failed: {ex.Message}", ex);
        }
    }
}

public record WeatherImpactResult(
    double originalFuel,
    string weatherCondition,
    double multiplier,
    double adjustedFuel,
    string recommendation
);