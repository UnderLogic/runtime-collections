# RuntimeSet\<T>

Abstract base class that all other runtime sets derive from.

Implements `ICollection<T>` and `IEnumerable<T>` interfaces.

## Description

Represents an observable set of `T` values that can be shared and modified throughout the application.

## Serialized Fields (Inspector)

- `isReadOnly : bool` - Whether the set can be mutated.
- `initialItems : List<T>` - Initial list of items, will be re-applied on restart.
- `items : List<T>` - The current items in the set.

**NOTE:** Any duplicates in the `initialItems` will **not** be preserved when copied to `items` during `OnEnable()`.

## Public Properties

- `IsReadOnly : bool` **(get)** - Whether the set can be mutated.
- `InitialItems : IReadOnlyCollection<T>` **(get)** - Read-only view of the initial items for the set.
- `Count : int` **(get)** - The number of items currently in the set.
- `this[int] : T` **(get)** - Returns the item in the set by index, zero-based.

## Public Events

- `ItemAdded : UnityAction<T>` - Raised when an item is added to the set.
- `ItemRemoved : UnityAction<T>` - Raised when an item is removed from the set.
- `ItemsChanged : UnityAction` - Raised when an item is added or removed from the set.

## Public Methods

- `Contains(T) : bool` - Returns whether the set contains the value `T` provided.
- `IndexOf(T) : int` - Returns the index of the value `T` within the set, or `-1` if not found.
- `TryGet(int, out T) : bool` - Attempts to get an item by index and returns the item as an `out` parameter. Returns whether an item was found.
- `Add(T)` - Adds a value `T` to the set. If the set already contains the value, it is ignored.
- `TryAdd(T) : bool` - Attempts to add a value `T` to the set, returns whether an item was added.
- `Remove(T) : bool` - Attempts to remove a value `T` from the set. Returns whether an item was removed.
- `TryReplace(T, T) : bool` - Attempts to replace one value `T` with another `T` within the set. Returns whether an item was found to be replaced.
- `Clear()` - Removes all items from the set. **Will raise events for each item removed.**
- `CopyTo(T[], int)` - Copies the items from this set to another `T[]` array.
- `MakeReadOnly()` - Marks the set as readonly, useful for freezing the collection after initialization.
- `GetEnumerator() : IEnumerator<T>` - Get an enumerator that can be used to iterate over the set.
- `RaiseItemsChanged()` - Manually raises the `ItemsChanged` event, useful for forcing refreshes on observers.

**NOTE:** Trying to modify a readonly set will result in an `InvalidOperationException` being thrown.
