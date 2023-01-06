using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidator.Core.Validators
{
    public class StringRuleValidator : IRuleValidator<string>
    {
        private Func<string, bool> _predicate;
        public StringRuleValidator(Func<string, bool> predicate)
        {
            _predicate = predicate;
        }

        public bool Validate(string input)
        {
            return _predicate(input);
        }

        public static IRuleValidator<string> Contains(string value) => new StringRuleValidator(input => input.Contains(value));
        public static IRuleValidator<string> BeginsWith(string value) => new StringRuleValidator(input => input.StartsWith(value));
        public static IRuleValidator<string> EndsWith(string value) => new StringRuleValidator(input => input.EndsWith(value));
    }
}
