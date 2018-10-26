using System.Collections.Generic;

namespace DDD.Framework.Core.CQS
{
    public interface IUser
    {
        string Id { get; }
        string Name { get; }
        IEnumerable<IRole> Roles { get; }
    }
}