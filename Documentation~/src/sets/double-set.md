# DoubleSet

Derives from [`RuntimeSet<T>`](runtime-set.md).

## Description

Represents a set of `double` values that can be shared and modified throughout the application.

## Public Methods

- `Add(int)` - Adds a signed `int` value to the set.
- `Add(float)` - Adds a `float` value to the set.
- `TryAdd(int) : bool` - Attempts to add a signed `int` value to the set. Returns whether an item was added.
- `TryAdd(float) : bool` - Attempts to add a `float` value to the set. Returns whether an item was added.
- `Remove(int) : bool` - Removes a signed `int` value from the set. Returns whether an item was removed.
- `Remove(float) : bool` - Removes a `float` value from the set. Returns whether an item was removed.
