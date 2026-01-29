---
name: flight-log
description: Understands flight log signatures, can explain flight logs and can parse them into structured data.
---

# Flight log

## Instructions

A flight log signature is a string, separaded by dashes (-), taht encodes information about a flight. This information is in the string:

- Departure Date (fromat: ddMMyy)
- Departure Airfield
- Arrival Airfield
- Flight number

## Examples

Example: 171203-DEP-ARR-WB001

17th of December 1903
Departure from DEP
Arrival at ARR
Flight number WB001

Example: 050721-JFK-LAX-AA123

5th of July 1921
Departure from JFK
Arrival at LAX
Flight number AA123
