# Vector3Set

Derives from [`RuntimeSet<T>`](runtime-set.md).

## Description

Represents a set of `Vector3` values that can be shared and modified throughout the application.

## Public Methods

- `Add(Vector2Int)` - Adds a `Vector2Int` value to the set.
- `Add(Vector2)` - Adds a `Vector2` value to the set.
- `TryAdd(Vector2Int) : bool` - Attempts to add a `Vector2Int` value to the set. Returns whether an item was added.
- `TryAdd(Vector2) : bool` - Attempts to add a `Vector2` value to the set. Returns whether an item was added.
- `Remove(Vector2Int) : bool` - Removes a `Vector2Int` value from the set. Returns whether an item was removed.
- `Remove(Vector2) : bool` - Removes a `Vector2` value from the set. Returns whether an item was removed.
