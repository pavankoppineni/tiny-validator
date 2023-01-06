using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidator.Core.Validators
{
    public interface IRuleValidator<T>
    {
        bool Validate(T input);
    }
}
