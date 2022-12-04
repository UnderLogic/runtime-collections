# Getting Started

## Context

To best understand the purpose of this library and the problems it solves,
it is highly recommended to watch the [Unite 2017: Game Architecture with Scriptable Objects](https://www.youtube.com/watch?v=raQ3iHhE_Kk)
by Ryan Hipple.

## Use Cases

### Shared Data

The common case of needing to share data between various components, potentially across multiple scenes.
Easy to drag and drop references in the Editor and view/modify them in the Inspector during play mode.

See `runtime-variables` library in the [related-libraries](related-libraries.md) section for working with variable data.

### Singleton

The common case of needing a single, global instance of data that can be accessed everywhere.
This avoids the common pitfalls of traditional Unity singleton objects.

### Event-Based Architecture

The case of only wanting to update or perform actions when necessary (reactively) instead of wastefully computing each frame.
This is very common in UI-heavy applications.

See `event-channels` library in the [related-libraries](related-libraries.md) section for working with an event bus.

## Samples

The `Samples~` folder contains sample scenes showcasing various aspects of the library in action.
It is recommended to import and play around with them in Unity to get a feel for how to use the library.
