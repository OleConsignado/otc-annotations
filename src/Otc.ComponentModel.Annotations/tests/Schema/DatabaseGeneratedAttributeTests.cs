// These sources have been forked from https://github.com/dotnet/corefx/releases/tag/v1.1.8
// then customized by Ole Consignado in order to meet it needs.
// Original sources should be found at: https://github.com/dotnet/corefx/tree/v1.1.8/src/System.ComponentModel.Annotations
// Thanks to Microsoft for making it open source!

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System;
using Xunit;

namespace Otc.ComponentModel.DataAnnotations.Schema
{
    public class DatabaseGeneratedAttributeTests
    {
        [Fact]
        public static void DatabaseGeneratedOption_can_be_got_and_set()
        {
            Assert.Equal(
                DatabaseGeneratedOption.Computed, new DatabaseGeneratedAttribute(DatabaseGeneratedOption.Computed).DatabaseGeneratedOption);
        }

        [Fact]
        public static void DatabaseGeneratedOption_cannot_be_set_to_a_value_not_in_the_enum()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new DatabaseGeneratedAttribute((DatabaseGeneratedOption)10));
        }
    }
}
