function calculateWeatherImpact(weatherCondition, baseFuelConsumption) {
    const weatherMultipliers = {
        'Clear': 1.0,
        'Cloudy': 1.1,
        'Rainy': 1.3,
        'Stormy': 1.5,
        'Foggy': 1.2
    };

    const multiplier = weatherMultipliers[weatherCondition] || 1.0;
    const adjustedFuel = baseFuelConsumption * multiplier;

    return {
        originalFuel: baseFuelConsumption,
        weatherCondition: weatherCondition,
        multiplier: multiplier,
        adjustedFuel: adjustedFuel,
        recommendation: multiplier > 1.2 ? 'Consider postponing flight' : 'Safe to fly'
    };
}

// Read from command line args
const args = process.argv.slice(2);
const weather = args[0];
const fuel = parseFloat(args[1]);

const result = calculateWeatherImpact(weather, fuel);
console.log(JSON.stringify(result));