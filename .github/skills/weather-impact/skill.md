---
name: weather-impact
description: Calculates how weather conditions affect aircraft fuel consumption using an external JavaScript calculator
---

# Weather Impact Calculator

## Overview

Calculates the adjusted fuel requirements for early aviation aircraft based on weather conditions using an external JavaScript calculator and provides safety recommendations based on used multiplier from calculator response.

## Instructions

When a user asks about weather impact on flights, you should:

1. Call the weather calculator script with the weather condition and base fuel amount
2. Explain the fuel adjustment based on the weather multiplier
3. Provide safety recommendations based on the conditions
4. Reference historical Wright Brothers flight logs when relevant

## Weather Conditions

The calculator supports these weather conditions:

- **Clear**: Perfect flying conditions (1.0x multiplier)
- **Cloudy**: Slight visibility reduction (1.1x multiplier)
- **Rainy**: Reduced visibility and wind resistance (1.3x multiplier)
- **Stormy**: Dangerous conditions (1.5x multiplier)
- **Foggy**: Poor visibility (1.2x multiplier)

## Example Usage

**User**: "How much fuel do I need for a flight in rainy weather if I normally use 100 liters?"

**Expected Response**:

```md
For rainy weather conditions:
- Original fuel requirement: 100 liters
- Weather multiplier: 1.3x
- Adjusted fuel needed: 130 liters
- Recommendation: Safe to fly (with caution)

In rainy conditions, you should plan for 30% additional fuel due to:
- Increased air resistance from moisture
- Potential headwinds
- Need for altitude adjustments

The Wright Brothers often grounded their aircraft in wet conditions at Kitty Hawk.
```

## API Integration

The skill uses the Weather Calculator Service which calls an external Node.js script:

- Endpoint: `GET /api/flights/weather-impact?weather={condition}&fuel={amount}`
- Script: `Scripts/weather-calculator.js`
- Response format: JSON with original/adjusted fuel and recommendations

## Safety Guidelines

Always recommend postponing flights when:

- Weather multiplier exceeds 1.2x
- Stormy conditions are present
- Visibility is severely impaired

For early aviation aircraft (1903-1910), even minor weather can be significant!

## Historical Context

Reference these historical facts when appropriate:

- The Wright Brothers conducted most test flights in clear, calm conditions
- Their aircraft had no weather instruments
- Wind speed was critical - they needed 15-20 mph headwinds for takeoff
- Wilbur Wright once said: "The only bird that talks is a parrot, and it doesn't fly very high"

## Examples

### Example 1: Clear Weather

```md
User: What's the fuel impact for clear weather with 80 liters?
Assistant: Excellent conditions! Clear weather has no impact on fuel consumption.
- Base fuel: 80 liters
- Weather multiplier: 1.0x
- Total needed: 80 liters
- Recommendation: Perfect conditions for aerobatic maneuvers!
```

### Example 2: Stormy Weather

```md
User: Can I fly in stormy weather with 150 liters of fuel?
Assistant: ⚠️ CAUTION - Stormy conditions detected!
- Base fuel: 150 liters
- Weather multiplier: 1.5x
- Adjusted fuel: 225 liters
- Recommendation: Consider postponing flight

Stormy weather poses serious risks for early aircraft:
- 50% increase in fuel consumption
- Severe turbulence likely
- Risk of structural damage to canvas and wood construction

The Wright Brothers would NEVER fly in these conditions. Safety first!
```

### Example 3: Multiple Flight Comparison

```md
User: Compare fuel needs for the same flight in foggy vs cloudy weather
Assistant: Great question! Let me compare both scenarios:

**Foggy conditions:**
- Base fuel: 100 liters
- Multiplier: 1.2x = 120 liters needed
- Risk: Reduced visibility

**Cloudy conditions:**
- Base fuel: 100 liters  
- Multiplier: 1.1x = 110 liters needed
- Risk: Minimal

Recommendation: Cloudy weather is safer with 10 liters less fuel required. 
In the Wright Brothers era, pilots relied entirely on visual navigation!
```

## Integration with Flight System

This skill works with:

- Flight planning and fuel calculations
- The aerobatic sequence system (weather affects maneuver safety)
- Historical airfield data (different locations have different weather patterns)
- Flight status updates (weather can change status from Scheduled to Delayed)

## Tips for Pilots

- Always add 10-20% safety margin to calculated fuel
- Check weather before AND during flight planning
- Remember: Early aircraft had no fuel gauges!
- Plan alternate landing sites for deteriorating weather