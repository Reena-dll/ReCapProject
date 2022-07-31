using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MaximumLength(50);
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).MaximumLength(50);
            RuleFor(u => u.LastName).MinimumLength(3);
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).MaximumLength(75);
            RuleFor(u => u.Email).MinimumLength(5);
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).MaximumLength(50);
            RuleFor(u => u.Email).MinimumLength(5);
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MaximumLength(50);
            RuleFor(u => u.Password).MinimumLength(6);


        }
    }
}
