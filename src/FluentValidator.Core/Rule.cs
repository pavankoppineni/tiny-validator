using FluentValidator.Core.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidator.Core
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public class Rule<TInput, TOutput> : IRule<TInput, TOutput>, IRule<TInput>
    {
        private Func<TInput, TOutput> _predicate;
        private IRuleValidator<TOutput> _validator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        public Rule(Func<TInput, TOutput> predicate)
        {
            _predicate = predicate;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Validate(TInput input)
        {
            var result = _predicate(input);
            return _validator.Validate(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        internal void SetPredicate(Func<TInput, TOutput> predicate)
        {
            _predicate = predicate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="validator"></param>
        internal void SetValidator(IRuleValidator<TOutput> validator)
        {
            _validator = validator;
        }

        /// <summary>
        /// 
        /// </summary>
        internal void SetErrorMessage(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
