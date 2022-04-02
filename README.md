# Units
Library for handling the representation and conversion of units

To create a value:

```
  var celsiusValue = Temperature.C.Value(100);
```

To convert a value:

```
  double kelvinValue = celsiusValue.To.K;
```

Supported quantity values:

- Acceleration
- Angle
- Density
- Energy
- Enthalpy
- Force
- Heat Capacity
- Length
- Mass
- Mass Flow
- Mass Flux
- Pressure
- Surface Tension
- Temperature
- Time
- Velocity
- Volume