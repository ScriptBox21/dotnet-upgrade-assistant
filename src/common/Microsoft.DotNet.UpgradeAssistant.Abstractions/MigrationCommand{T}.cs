﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.DotNet.UpgradeAssistant
{
    public abstract class MigrationCommand<T> : MigrationCommand
        where T : notnull
    {
        public T Value { get; init; } = default!;
    }
}