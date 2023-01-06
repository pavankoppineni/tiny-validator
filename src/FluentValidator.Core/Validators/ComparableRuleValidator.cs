using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidator.Core.Validators
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ComparableRuleValidator<T> : IRuleValidator<T> where T : IComparable<T>
    {
        private readonly T _value;
        private readonly Func<int, bool> _predicate;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="predicate"></param>
        public ComparableRuleValidator(T value, Func<int, bool> predicate)
        {
            _value = value;
            _predicate = predicate;
        }

        public bool Validate(T input)
        {
            var result = input.CompareTo(_value);
            return _predicate(result);
        }

        public static IRuleValidator<T> LessThan(T value) => new ComparableRuleValidator<T>(value, result => result < 0);
        public static IRuleValidator<T> GreaterThan(T value) => new ComparableRuleValidator<T>(value, result => result > 0);
        public static IRuleValidator<T> EqualTo(T value) => new ComparableRuleValidator<T>(value, result => result == 0);
        public static IRuleValidator<T> NotEqualTo(T value) => new ComparableRuleValidator<T>(value, result => result != 0);
        public static IRuleValidator<T> LessThanOrEqualTo(T value) => new ComparableRuleValidator<T>(value, result => result <= 0);
        public static IRuleValidator<T> GreaterThanOrEqualTo(T value) => new ComparableRuleValidator<T>(value, result => result >= 0);
    }
}
