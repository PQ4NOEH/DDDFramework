using DDD.Framework.Core.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace DDD.Framework.Core.CQS
{
    interface ICommandDomainResult<T> where T : IEvent
    {
        T Result { get; }
        bool HasBeenDenied { get; }
        IEnumerable<string> DenialReasons { get; }
    }


    /// <summary>
    /// Represents the result of executing a command against the domain.
    /// todo: Result might be null
    /// todo: 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CommandDomainResult<T> : ICommandDomainResult<T> where T : IEvent
    {
        public T Result { get; }

        public bool HasBeenDenied => DenialReasons.Count() > 0;

        public IEnumerable<string> DenialReasons { get; } = new List<string>();

        public CommandDomainResult(T @event)
        {
            Contract.Requires<ArgumentNullException>(@event != null, "The event can not be null.");
            Result = @event;
        }

        public CommandDomainResult(IDeniedCommandEvent @event)
        {
            Contract.Requires<ArgumentNullException>(@event != null, "The event can not be null.");
            Contract.Requires<ArgumentNullException>(@event.DenialReasons != null, "Event DenialReasons can not be null.");
            Contract.Requires<ArgumentException>(@event.DenialReasons.Count() < 1, "Event DenialReasons can not be Empty.");
            DenialReasons = @event.DenialReasons;
        }
    }
}
