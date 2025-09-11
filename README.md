
> ⚠️ **This repository is no longer maintained because it is obsolete.**\
> Native solutions are now available that provide the same functionality.

[![Build status](https://ci.appveyor.com/api/projects/status/qlh7kwds6d2292g2?svg=true)](https://ci.appveyor.com/project/mathieumack/mvvx-plugins-assemblyfinder)

# Mvvx.Plugins.AssemblyFinder

### Compatibility ###
The plugin is compatible with android, WPF and UWP applications.
Perhaps iOS ! Not tested but the code seems ok.

Using the AssemblyFinder for MvvmCross is quite simple. The plugin injects the IAssemblyFinder interface into the IoC container.
Each resolve to IAssemblyFinder from the Mvx.Resolve<IAssemblyFinder>() will create a new instance of the service.

## Search samples

### Search class in loaded assemblies

```c#
var typeFinder = Mvx.Resolve<IAssemblyFinder>();
var myListOfClassesOrInterfaces = typeFinder.FindClassesOfType(typeof(<Set Class or interface here>)).ToList();
```

You can search class ou interface.