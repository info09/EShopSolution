using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopSolution.ViewModels.System.User
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(i => i.UserName).NotEmpty().WithMessage("Tài khoản không được để trống");
            RuleFor(i => i.Password).NotEmpty().WithMessage("Mật khẩu không được để trống")
                                    .MinimumLength(6).WithMessage("Mật khẩu tối thiểu 6 kí tự");
        }
    }
}
