# StringSet

Derives from [`RuntimeSet<T>`](runtime-set.md).

## Description

Represents a set of `string` values that can be shared and modified throughout the application.

## Public Methods

- `Add(bool)` - Adds the string representation of a `bool` value to the set.
- `Add(int)` - Adds the string representation of a signed `int` value to the set.
- `Add(float)` - Adds the string representation of a `float` value to the set.
- `Add(double)` - Adds the string representation of a `double` value to the set.
- `TryAdd(bool)` - Attempts to add the string representation of a `bool` value to the set. Return whether an item was added.
- `TryAdd(int)` - Attempts to add the string representation of a signed `int` value to the set. Return whether an item was added.
- `TryAdd(float)` - Attempts to add the string representation of a `float` value to the set. Return whether an item was added.
- `TryAdd(double)` - Attempts to add the string representation of a `double` value to the set. Return whether an item was added.
- `Remove(int) : bool` - Removes the string representation of a `bool` value from the set. Returns whether an item was removed.
- `Remove(int) : bool` - Removes the string representation of a signed `int` value from the set. Returns whether an item was removed.
- `Remove(float) : bool` - Removes the string representation of a `float` value from the set. Returns whether an item was removed.
- `Remove(double) : bool` - Removes the string representation of a signed `int` value from the set. Returns whether an item was removed.
