﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace FormatterWebSite
{
    public class Customer
    {
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }
}