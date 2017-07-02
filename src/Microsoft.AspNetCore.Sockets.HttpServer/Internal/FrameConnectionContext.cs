﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.IO.Pipelines;

namespace Microsoft.AspNetCore.Sockets.HttpServer
{
    public class FrameConnectionContext
    {
        public string ConnectionId { get; set; }
        public long FrameConnectionId { get; set; }
        public ConnectionContext Connection { get; set; }
        public ServiceContext ServiceContext { get; set; }
    }
}
