using FluentValidator.Core.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidator.Core
{
    /// <summary>
    /// 
    /// </summary>
    public static class RuleBuilderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuleBuilder<TInput, TOutput> LessThan<TInput, TOutput>(this RuleBuilder<TInput, TOutput> ruleBuilder, TOutput value) where TOutput : IComparable<TOutput>
        {
            var validator = ComparableRuleValidator<TOutput>.LessThan(value);
            ruleBuilder.SetValidator(validator);
            return ruleBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuleBuilder<TInput, TOutput> GreaterThan<TInput, TOutput>(this RuleBuilder<TInput, TOutput> ruleBuilder, TOutput value) where TOutput : IComparable<TOutput>
        {
            var validator = ComparableRuleValidator<TOutput>.GreaterThan(value);
            ruleBuilder.SetValidator(validator);
            return ruleBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuleBuilder<TInput, TOutput> EqualTo<TInput, TOutput>(this RuleBuilder<TInput, TOutput> ruleBuilder, TOutput value) where TOutput : IComparable<TOutput>
        {
            var validator = ComparableRuleValidator<TOutput>.EqualTo(value);
            ruleBuilder.SetValidator(validator);
            return ruleBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuleBuilder<TInput, TOutput> LessThanOrEqualTo<TInput, TOutput>(this RuleBuilder<TInput, TOutput> ruleBuilder, TOutput value) where TOutput : IComparable<TOutput>
        {
            var validator = ComparableRuleValidator<TOutput>.LessThanOrEqualTo(value);
            ruleBuilder.SetValidator(validator);
            return ruleBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuleBuilder<TInput, TOutput> GreaterThanOrEqualTo<TInput, TOutput>(this RuleBuilder<TInput, TOutput> ruleBuilder, TOutput value) where TOutput : IComparable<TOutput>
        {
            var validator = ComparableRuleValidator<TOutput>.GreaterThanOrEqualTo(value);
            ruleBuilder.SetValidator(validator);
            return ruleBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuleBuilder<TInput, TOutput> NotEqualTo<TInput, TOutput>(this RuleBuilder<TInput, TOutput> ruleBuilder, TOutput value) where TOutput : IComparable<TOutput>
        {
            var validator = ComparableRuleValidator<TOutput>.NotEqualTo(value);
            ruleBuilder.SetValidator(validator);
            return ruleBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuleBuilder<TInput, string> Contains<TInput>(this RuleBuilder<TInput, string> ruleBuilder, string value)
        {
            var validator = StringRuleValidator.Contains(value);
            ruleBuilder.SetValidator(validator);
            return ruleBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuleBuilder<TInput, string> BeginsWith<TInput>(this RuleBuilder<TInput, string> ruleBuilder, string value)
        {
            var validator = StringRuleValidator.BeginsWith(value);
            ruleBuilder.SetValidator(validator);
            return ruleBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuleBuilder<TInput, string> EndsWith<TInput>(this RuleBuilder<TInput, string> ruleBuilder, string value)
        {
            var validator = StringRuleValidator.EndsWith(value);
            ruleBuilder.SetValidator(validator);
            return ruleBuilder;
        }
    }
}
