using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidator.Core
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    public interface IRule<T>
    {
        public string ErrorMessage { get; }
        public bool Validate(T input);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public interface IRule<TInput, TOutput> : IRule<TInput>
    {
    }
}
