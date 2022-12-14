# Overview

![image](images/cover.png)

Unity package library for sharing collections of data across components and scenes, allowing other components to react when their contents change.

Heavily inspired by the infamous [Unite 2017: Game Architecture with Scriptable Objects](https://www.youtube.com/watch?v=raQ3iHhE_Kk) presentation by Ryan Hipple ([GitHub](https://github.com/roboryantron/Unite2017)).

Unfortunately Unity does not understand generics in the Editor and Inspectors, so only concrete types can be used.
Fortunately, this can be made easy by deriving from a single generic type allowing the same common behaviors.

**NOTE:** This package is still in development and may have breaking changes in future versions until a stable v1.0.0 release is made.
