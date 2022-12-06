# RuntimeSetWatcher\<T, TSet>

Abstract base class that all other runtime set watchers derive from.

## Description

Component that watches a [`RuntimeSet<T>`](../sets/runtime-set.md) for changes and raises events.

## Serialized Fields (Inspector)

- `collection : TSet` - The collection to watch for changes.
- `raiseOnAwake : bool` - Whether the `onItemsChanged` event should be raised when `Awake()` is called.
- `raiseOnEnable : bool` - Whether the `onItemsChanged` event should be raised when `OnEnable()` is called.
- `raiseOnStart : bool` - Whether the `onItemsChanged` event should be raised when `Start()` is called.

## Public Events (Inspector)

- `onItemAdded : UnityEvent<T>` - The actions to perform when an item is added to the set.
- `onItemRemoved : UnityEvent<T>` - The actions to perform when an item is remove from the set.
- `onItemsChanged : UnityEvent` - The actions to perform when an item is added or removed from the set.

## Public Properties

- `Collection : TSet` - The collection being watched for changes.

## Public Methods

- `RaiseItemAdded(T)` - Manually raises the `onItemAdded` event with the value `T` provided.
- `RaiseItemRemoved(T)` - Manually raises the `onItemRemoved` event with the value `T` provided.
- `RaiseItemsChanged` - Manually raises the `onItemsChanged` event.

**NOTE:** Manually raising these events will only trigger the `UnityEvent` actions on **this** component.
