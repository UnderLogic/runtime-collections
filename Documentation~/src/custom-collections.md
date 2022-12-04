# Custom Collections

While this library provides many of the common Unity types you will use, you may want to extend this library with your own custom collections specific to your application.
Fortunately, this is rather easy and typically only involves creating a derived class from one of the base classes.
You may also add any additional helper properties and methods as you need.

## Sets

1. Create a new class that derives from [`RuntimeSet<T>`](sets/runtime-set.md), where `T` should be the type of set.
2. Ensure the new type is marked with the `CreateAssetMenu` attribute, so you can create instances in the Editor.
3. Create any instances of the new variable in your `Assets` folder.
4. Configure the `isReadOnly` and `initialValues` as needed.
5. Now you can use them throughout your application.

**NOTE:** While most people create `ScriptableObject` instances in the Editor, you can create them at runtime as well!

### Watchers

1. Create a new class that derives from [`RuntimeSetWatcher<T, TSet>`](watchers/runtime-set-watcher.md), where `T` should be the underlying type and `TSet` is the set type.
2. You can now use the watcher component in your scenes.
