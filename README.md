# Runtime Collections

[![openupm](https://img.shields.io/npm/v/com.underlogic.runtime-collections?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.underlogic.runtime-collections/)

![image](Documentation~/src/images/cover.png)

Unity package library for sharing collections of data across components and scenes.
Uses `ScriptableObjects` to store collections and exposes events for when their contents change.

Heavily inspired by the infamous [Unite 2017: Game Architecture with Scriptable Objects](https://www.youtube.com/watch?v=raQ3iHhE_Kk) presentation by Ryan Hipple ([GitHub](https://github.com/roboryantron/Unite2017)).

:exclamation: **This repository is no longer maintained.** :exclamation:

## So long Unity...

**Due to Unity's decision to change pricing model to effectively charge developers microtransaction costs for installs, we are no longer working with Unity or building/maintaining package libraries for it.**
We will be migrating to Godot 4 for all projects.

## Installation

The package library can be installed to your Unity project in the following ways:

- Using [OpenUPM](https://openupm.com/) package manager
    - `openupm add com.underlogic.runtime-collections`
- Clone the repository and adding it as a local package
- Add the package by git URL

Installing it by git URL allows the package to be updated when new releases are available here.

## Documentation

[Online documentation](https://underlogic.github.io/runtime-collections/) is automatically published to GitHub Pages.

Offline docs can be found in the [`Documentation~`](./Documentation~) folder, and can be viewed via [`mdbook`](https://rust-lang.github.io/mdBook/index.html):

```shell
$ mdbook serve ./Documentation~ --open
```

## Samples

The package library includes several sample scenes that demonstrate how to use each type of collection.
It is highly recommended that you import the samples so you can see the library in action and experiment with it.

## Contributing

To make working on the library easier while keeping this repository minimal, it is recommended to create a separate Unity project, (i.e. `runtime-collections-project`).

Then link the following folders into the Unity project for easy editing/syncing while keeping code completion and intellisense:

```shell
$ cd runtime-collections-project/Assets
$ ln -s ~/runtime-collections/Samples~ Samples

$ mkdir -p Scripts && cd Scripts
$ ln -s ~/runtime-collections/Editor
$ ln -s ~/runtime-collections/Runtime
$ ln -s ~/runtime-collections/Tests
```

**NOTE:** This assumes both folders are in your `$HOME` folder. Adjust paths accordingly if they differ.

Now you can work in the shell project without copying files back and forth, and also generating `.meta` files automatically.
