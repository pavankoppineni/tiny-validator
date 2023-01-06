using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentValidator.Core
{
    public abstract class AbstractValidator<T>
    {
        private readonly IList<IRule<T>> _rules;
        protected AbstractValidator()
        {
            _rules = new List<IRule<T>>();
        }

        protected RuleBuilder<T, TOutput> AddRule<TOutput>(Func<T, TOutput> predicate)
        {
            var rule = new Rule<T, TOutput>(predicate);
            _rules.Add(rule);
            return new RuleBuilder<T, TOutput>(rule);
        }

        public ValidationResult Validate(T input)
        {
            var errorMessages = new List<string>();
            foreach (var rule in _rules)
            {
                var result = rule.Validate(input);
                if (!result)
                {
                    errorMessages.Add(rule.ErrorMessage);
                }
            }

            if (!errorMessages.Any())
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(errorMessages);
        }
    }
}
