﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace Microsoft.DotNet.UpgradeAssistant.Steps.Solution
{
    public class SolutionOptions
    {
        public IReadOnlyCollection<string> Entrypoints { get; set; } = Array.Empty<string>();
    }
}
