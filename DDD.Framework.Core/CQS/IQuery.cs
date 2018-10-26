using System;

namespace DDD.Framework.Core.CQS
{
    public interface IQuery
    {
        IUser RequestedBy { get; }
        DateTime RequestedOn { get; }
        string Name { get; }
    }

    public interface IQuery<T>:IQuery
    {
        T Payload { get; }
    }
}
