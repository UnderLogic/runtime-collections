# Changelog
All notable changes to this library will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.2.3] - 2022-12-29

### Added

- `BoolSet` collection
- `BoolSetWatcher` component
- `AllowDuplicates` property for `RuntimeSet` collection
- `AddRange(IEnumerable<T>)` method for `RuntimeSet` collection
- Icons for `RuntimeSet` collections in the Editor

### Changed

- `Add(T)` method for `RuntimeSet` collection optionally allows duplicates
- `TryReplace(T, T)` method for `RuntimeSet` collection now checks for duplicates prior to replacing

## [0.2.2] - 2022-12-08

### Fixed

- Missing meta files

## [0.2.1] - 2022-12-06

### Added

- `TryAdd(int) : bool` method to `DoubleSet` variant
- `TryAdd(float) : bool` method to `DoubleSet` variant
- `TryAdd(int) : bool` method to `FloatSet` variant
- `TryAdd(bool) : bool` method to `StringSet` variant
- `TryAdd(int) : bool` method to `StringSet` variant
- `TryAdd(float) : bool` method to `StringSet` variant
- `TryAdd(double) : bool` method to `StringSet` variant
- `TryAdd(Vector2Int) : bool` method to `Vector2Set` variant
- `TryAdd(Vector2Int) : bool` method to `Vector3Set` variant
- `TryAdd(Vector2) : bool` method to `Vector3Set` variant
- `TryAdd(Vector2Int) : bool` method to `Vector4Set` variant
- `TryAdd(Vector2) : bool` method to `Vector4Set` variant
- `TryAdd(Vector3) : bool` method to `Vector4Set` variant
- `TryAdd(T) : bool` method to `RuntimeSet<T>` base class
- `TryReplace(T, T)` method to `RuntimeSet<T>` base class
- Docs via `mdbook` in `Documentation~` directory
- GitHub CI/CD workflows for documentation

### Changed

- Renamed `collectionSet` serialized field to `collection` in `RuntimeSetWatcher` base class
- Expose `Collection` getter property in `RuntimeSetWatcher` base class

## [0.2.0] - 2022-12-02

### Added

- `RuntimeSetWatcher<T>` abstract base class
- `ColorSetWatcher` component
- `DoubleSetWatcher` component
- `FloatSetWatcher` component
- `IntSetWatcher` component
- `ScriptableObjectSetWatcher` component
- `StringSetWatcher` component
- `TransformSetWatcher` component
- `Vector2IntSetWatcher` component
- `Vector2SetWatcher` component
- `Vector3SetWatcher` component
- `Vector4SetWatcher` component
- Set Watchers sample scene

## [0.1.3] - 2022-12-02

### Added

- `InitialItems` readonly property to `RuntimeSet<T>` base class
- `MakeReadOnly()` method to `RuntimeSet<T>` base class

## [0.1.2] - 2022-12-01

### Added

- `Add(int)` method to `FloatSet` collection
- `Remove(int)` method to `FloatSet` collection
- `Add(int)` method to `DoubleSet` collection
- `Add(float)` method to `DoubleSet` collection
- `Remove(int)` method to `DoubleSet` collection
- `Remove(float)` method to `DoubleSet` collection
- `Add(bool)` method to `StringSet` collection
- `Add(int)` method to `StringSet` collection
- `Add(float)` method to `StringSet` collection
- `Add(double)` method to `StringSet` collection
- `Remove(bool)` method to `StringSet` collection
- `Remove(int)` method to `StringSet` collection
- `Remove(float)` method to `StringSet` collection
- `Remove(double)` method to `StringSet` collection
- `Add(Vector2Int)` method to `Vector2Set` collection
- `Remove(Vector2Int)` method to `Vector2Set` collection
- `Vector2IntSet` collection
- `Vector4Set` collection
- `ColorSet` collection

## [0.1.1] - 2022-12-01

### Added

- `IntSet` collection
- `FloatSet` collection
- `DoubleSet` collection
- `Vector2Set` collection
- `Vector3Set` collection

## [0.1.0] - 2022-12-01

### Added

- `RuntimeSet<T>` abstract base class
- `ScriptableObjectSet` collection
- `StringSet` collection
- `TransformSet` collection
- Sets sample scene
