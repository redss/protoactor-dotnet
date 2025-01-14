﻿// -----------------------------------------------------------------------
//   <copyright file="Messages.cs" company="Asynkron AB">
//       Copyright (C) 2015-2020 Asynkron AB All rights reserved
//   </copyright>
// -----------------------------------------------------------------------

using System;

namespace Proto.Remote
{
    public sealed record EndpointTerminatedEvent(string Address);

    public sealed record EndpointConnectedEvent(string Address);

    public sealed record EndpointErrorEvent(string Address, Exception Exception);

    public sealed record RemoteTerminate(PID Watcher, PID Watchee);

    public sealed record RemoteWatch(PID Watcher, PID Watchee);

    public sealed record RemoteUnwatch(PID Watcher, PID Watchee);

    public sealed record RemoteDeliver(Proto.MessageHeader Header, object Message, PID Target, PID? Sender);
}