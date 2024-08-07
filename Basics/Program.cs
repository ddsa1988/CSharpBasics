﻿// using System; => This directive enables types within the system namespace to be directly referenced in code.

// namespace Basics; => A namespace is a hierarchical organizational facility.

using Basics.Strings;

namespace Basics;

// public class Program {} => Class organized under the namespace.
public class Program {
    // public static void Main() {} => Application entry point.
    public static void Main(string[] args) {
        // Console.WriteLine("Hello World!!!"); => Static class organized under the System namespace.

        StringFormat.UserMain();
    }
}