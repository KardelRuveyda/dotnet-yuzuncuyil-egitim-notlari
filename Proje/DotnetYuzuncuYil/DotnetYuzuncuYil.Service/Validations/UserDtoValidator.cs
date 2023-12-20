using DotnetYuzuncuYil.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Validations
{
    public class UserDtoValidator: AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.")
                .NotNull().WithMessage("Kullanıcı adı null olamaz!")
                .MaximumLength(50).WithMessage("Kullanıcı adı en fazla 50 karakter olabilir. ");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email boş geçilemez.")
                .NotNull().WithMessage("Email null olamaz.")
                .EmailAddress().WithMessage("Geçeri bir e-posta adresi giriniz.");
        }
    }
}
