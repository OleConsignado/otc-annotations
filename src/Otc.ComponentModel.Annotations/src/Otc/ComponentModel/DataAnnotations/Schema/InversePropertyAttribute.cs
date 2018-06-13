// These sources have been forked from https://github.com/dotnet/corefx/releases/tag/v1.1.8
// then customized by Ole Consignado in order to meet it needs.
// Original sources should be found at: https://github.com/dotnet/corefx/tree/v1.1.8/src/System.ComponentModel.Annotations
// Thanks to Microsoft for making it open source!

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;

namespace Otc.ComponentModel.DataAnnotations.Schema
{
    /// <summary>
    ///     Specifies the inverse of a navigation property that represents the other end of the same relationship.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class InversePropertyAttribute : Attribute
    {
        private readonly string _property;

        /// <summary>
        ///     Initializes a new instance of the <see cref="InversePropertyAttribute" /> class.
        /// </summary>
        /// <param name="property">The navigation property representing the other end of the same relationship.</param>
        public InversePropertyAttribute(string property)
        {
            if (string.IsNullOrWhiteSpace(property))
            {
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture,
                    SR.ArgumentIsNullOrWhitespace, "property"));
            }
            _property = property;
        }

        /// <summary>
        ///     The navigation property representing the other end of the same relationship.
        /// </summary>
        public string Property
        {
            get { return _property; }
        }
    }
}
