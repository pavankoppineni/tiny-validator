using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentValidator.Core
{
    public class ValidationResult
    {
        public ValidationResult(IList<string> errorMessage)
        {
            ErrorMessages = errorMessage;
        }

        public bool IsValid => !ErrorMessages.Any();
        public IList<string> ErrorMessages { get; private set; }
        public static ValidationResult Success = new ValidationResult(Array.Empty<string>());
    }
}
