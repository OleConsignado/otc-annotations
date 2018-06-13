// These sources have been forked from https://github.com/dotnet/corefx/releases/tag/v1.1.8
// then customized by Ole Consignado in order to meet it needs.
// Original sources should be found at: https://github.com/dotnet/corefx/tree/v1.1.8/src/System.ComponentModel.Annotations
// Thanks to Microsoft for making it open source!

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using Xunit;

namespace Otc.ComponentModel.DataAnnotations
{
    // Helpers to ease port from XUnit to CoreFXTestLibrary
    internal static class AssertEx
    {
        public static void DoesNotThrow(Action action)
        {
            action();
        }

        public static void Empty(IEnumerable collection)
        {
            Assert.False(collection.GetEnumerator().MoveNext());
        }

        public static void IsType<T>(object obj)
        {
            Assert.True(obj.GetType() == typeof(T));
        }
    }
}
