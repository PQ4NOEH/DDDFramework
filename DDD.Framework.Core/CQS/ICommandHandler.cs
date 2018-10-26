using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Framework.Core.CQS
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Handle(T command);
    }
}
