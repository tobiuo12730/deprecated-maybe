# deprecated-maybe

## Objective

Like NASA's mission in which a Mars explorer fallen to the planet because of mistake in conversion from yards to meters, unit conversion is a sometimes problematic. 
A well-known approach to combat this problem is exploiting typing system, in which units are converted by cast operator.
However, this approach is also a big burden to apply to existing non-typed 'raw double' codes.
The dominant reason is that it can cause degration by mistaking in guessing units, for example, if we assign `Yard` class to a meter value, casting cause unintended value changes.
So, decreasing a risk of these kind of degration is needed.

## Approach

'deprected-maybe' classes are introduced. In this approach, thinking some variables' units are known and others unknown.

- Known variables are assigned with non-labelled unit classes, such as `Meter`, `Yard`, `Pound`, `Kilogram`.
- Unknown variables are assigned with deprecated-maybe (DM) unit classes, such as `DMMeter`, `DMYard`, `DMPound`, `DMKilogram`.

Non-labelled unit class and DM unit class both have a similar casting operators, for example:

- `Meter` * `Newton` = `Joule`
- `DMMeter` * `DMNewton` = `DMJoule`

The big difference is that while non-labelled units have real unit conversion, such as `(Meter)(x_yard)` produces `(0.9144 * x_yard.Value)`, DM units have no real unit conversion, so `(DMMeter)(x_yard)` produces `x_yard.Value`.
This DM unit is useful because it can represent a guessed but not certain unit of a variable.
After debugging and variable's unit is confirmed, `DMMeter` is replaced with `Meter`.
If even there is a mistake in guessing units, the original value is retained because casting acutally does nothing but bypassing the value.

## Examples

- In `Calc` folder, there is a demonstration of modifying conventional code to unit-aware classes.
- `DM` and `Unit` folder have demonstartion of DM and non-labelled unit classes, respectively.
