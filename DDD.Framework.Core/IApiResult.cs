using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace DDD.Framework.Core
{
    public interface IApiResult
    {
        IEnumerable<string> Errors { get; }
        bool IsCorrect { get; }
    }

    public interface IApiResult<T> : IApiResult
    {
        T Result { get; }
    }

    public class ApiResult : IApiResult
    {
        public ApiResult() { }
        public ApiResult(IEnumerable<string> errors)
        {
            Contract.Requires<ArgumentNullException>(errors != null, "errors can not be null.");
            Contract.Requires<ArgumentException>(errors.Count() < 1, "errors can not be Empty.");
            Errors = errors;
        }

        public IEnumerable<string> Errors { get; } = new List<string>();

        public bool IsCorrect => Errors.Count() > 0;
    }

    public class ApiResult<T>: ApiResult, IApiResult<T>
    {
        public T Result { get; }
    }
}
