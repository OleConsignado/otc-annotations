// These sources have been forked from https://github.com/dotnet/corefx/releases/tag/v1.1.8
// then customized by Ole Consignado in order to meet it needs.
// Original sources should be found at: https://github.com/dotnet/corefx/tree/v1.1.8/src/System.ComponentModel.Annotations
// Thanks to Microsoft for making it open source!

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Otc
{
    //
    // This class enables one to throw a NotImplementedException using the following idiom:
    //
    //     throw NotImplemented.ByDesign;
    //
    // Used by methods whose intended implementation is to throw a NotImplementedException (typically
    // virtual methods in public abstract classes that intended to be subclassed by third parties.)
    //
    // This makes it distinguishable both from human eyes and CCI from NYI's that truly represent undone work.
    //
    internal static class NotImplemented
    {
        internal static Exception ByDesign
        {
            get
            {
                return new NotImplementedException();
            }
        }

        internal static Exception ByDesignWithMessage(String message)
        {
            return new NotImplementedException(message);
        }
    }
}
