# FloatSet

Derives from [`RuntimeSet<T>`](runtime-set.md).

## Description

Represents a set of `float` values that can be shared and modified throughout the application.

## Public Methods

- `Add(int)` - Adds a signed `int` value to the set.
- `TryAdd(int) : bool` - Attempts to add a signed `int` value to the set. Returns whether an item was added.
- `Remove(int) : bool` - Removes a signed `int` value from the set. Returns whether an item was removed.
