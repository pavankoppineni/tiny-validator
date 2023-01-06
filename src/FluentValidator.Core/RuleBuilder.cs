using FluentValidator.Core.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidator.Core
{
    public class RuleBuilder<TInput, TOutput>
    {
        private Rule<TInput, TOutput> _rule;

        public RuleBuilder(Rule<TInput, TOutput> rule)
        {
            _rule = rule;
        }

        internal void SetValidator(IRuleValidator<TOutput> ruleValidator)
        {
            _rule.SetValidator(ruleValidator);
        }

        public RuleBuilder<TInput, TOutput> WithMessage(string message)
        {
            _rule.SetErrorMessage(message);
            return this;
        }
    }
}
