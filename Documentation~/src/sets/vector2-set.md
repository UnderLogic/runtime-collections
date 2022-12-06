# Vector2Set

Derives from [`RuntimeSet<T>`](runtime-set.md).

## Description

Represents a set of `Vector2` values that can be shared and modified throughout the application.

## Public Methods

- `Add(Vector2Int)` - Adds a `Vector2Int` value to the set.
- `TryAdd(Vector2Int) : bool` - Attempts to add a `Vector2Int` value to the set. Returns whether an item was added.
- `Remove(Vector2Int) : bool` - Removes a `Vector2Int` value from the set. Returns whether an item was removed.
