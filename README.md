# F# Mutable Variables and Pass-by-Value Bug

This example demonstrates a common pitfall in F#: the unexpected behavior when attempting to modify mutable variables within a function that receives them by value.  In F#, function arguments are passed by value by default, meaning the function receives a copy of the variable's value, not a reference to the variable itself.

The `bug.fs` file shows the issue: modifications made to `x` and `y` within the `add` function don't affect the original variables outside the function.

The `bugSolution.fs` file provides a solution by demonstrating how to pass variables by reference using tuples and destructuring or using mutable references.