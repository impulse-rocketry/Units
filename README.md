# Units
Library for handling the representation and conversion of units

To create a value:

```
  Temperature temperature = Temperature.Celsius.Value(100);
```

To convert a value:

```
  double kelvin = temperature.In.Kelvin;
```