using FluentValidator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidator.Shell
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            AddRule(employee => employee.Age)
                .LessThan(20)
                .WithMessage("Employee age should be less than 20");
            AddRule(employee => employee.Experience)
                .GreaterThan(10)
                .WithMessage("Employee experience should be greater than 10");
            AddRule(employee => employee.NumberOfBadges)
                .GreaterThan(5)
                .WithMessage("Employee should have greater than 5 badges");
            AddRule(employee => employee.Name)
                .Contains("Pavan")
                .WithMessage("Employee name should contain Pavan");
        }
    }
}
