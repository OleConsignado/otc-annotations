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
    public class TableAttributeTests
    {
        [Fact]
        public static void Name_can_be_got_and_set()
        {
            Assert.Equal("Black Aliss", new TableAttribute("Black Aliss").Name);
        }

        [Fact]
        public static void Name_cannot_be_set_to_null_or_whitespace()
        {
            Assert.Throws<ArgumentException>(() => new TableAttribute(null));
            Assert.Throws<ArgumentException>(() => new TableAttribute(string.Empty));
            Assert.Throws<ArgumentException>(() => new TableAttribute(" \t\r\n"));
        }

        [Fact]
        public static void Default_value_for_schema_is_null()
        {
            Assert.Null(new TableAttribute("Perspicacia Tick").Schema);
        }

        [Fact]
        public static void Schema_can_be_got_and_set()
        {
            Assert.Equal(
                "Mrs Letice Earwig", new TableAttribute("Perspicacia Tick")
                {
                    Schema = "Mrs Letice Earwig"
                }.Schema);
        }

        [Fact]
        public static void Schema_cannot_be_set_to_null_or_whitespace()
        {
            Assert.Throws<ArgumentException>(
                () => new TableAttribute("Perspicacia Tick")
                {
                    Schema = null
                });
            Assert.Throws<ArgumentException>(
                () => new TableAttribute("Perspicacia Tick")
                {
                    Schema = string.Empty
                });
            Assert.Throws<ArgumentException>(
                () => new TableAttribute("Perspicacia Tick")
                {
                    Schema = " \t\r\n"
                });
        }
    }
}
