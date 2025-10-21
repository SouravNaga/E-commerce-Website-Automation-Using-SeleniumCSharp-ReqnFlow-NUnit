using System.Reflection;
using System.Runtime.InteropServices;
using NUnit.Compatibility;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Children)]
[assembly: LevelOfParallelism(4)]