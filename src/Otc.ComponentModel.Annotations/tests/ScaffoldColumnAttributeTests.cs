// These sources have been forked from https://github.com/dotnet/corefx/releases/tag/v1.1.8
// then customized by Ole Consignado in order to meet it needs.
// Original sources should be found at: https://github.com/dotnet/corefx/tree/v1.1.8/src/System.ComponentModel.Annotations
// Thanks to Microsoft for making it open source!

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Xunit;

namespace Otc.ComponentModel.DataAnnotations
{
    public class ScaffoldColumnAttributeTests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Can_construct_and_get_Scaffold(bool value)
        {
            var attribute = new ScaffoldColumnAttribute(value);
            Assert.Equal(value, attribute.Scaffold);
        }
    }
}
