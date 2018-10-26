using System;
using System.Collections.Generic;

namespace DDD.Framework.Core.CQS
{
    public interface IEvent
    {
        string Id { get; }
        IVersion Version { get; }
        string RaisedByCommandId { get; }
        DateTime RaisedOn { get; }
        string Name { get; }
    }

    public interface IDeniedCommandEvent:IEvent
    {
        IEnumerable<string> DenialReasons { get; }
    }

    public interface IEvent<T>:IEvent
    {
        T Payload { get; }
    }
}
