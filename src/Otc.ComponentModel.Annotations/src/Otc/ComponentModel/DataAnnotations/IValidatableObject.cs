// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Otc.ComponentModel.DataAnnotations
{
    public interface IValidatableObject
    {
        IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
    }
}
