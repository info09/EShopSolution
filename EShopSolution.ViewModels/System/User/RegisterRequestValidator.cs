using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopSolution.ViewModels.System.User
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(i => i.UserName).NotEmpty().WithMessage("Bạn phải nhập UserName");
            RuleFor(i => i.FirstName).NotEmpty().WithMessage("Bạn phải nhập FirstName")
                                    .MaximumLength(200).WithMessage("FirstName không được vượt quá 200 kí tự");
            RuleFor(i => i.LastName).NotEmpty().WithMessage("Bạn phải nhập LastName")
                                    .MaximumLength(200).WithMessage("LastName không được vượt quá 200 kí tự");
            RuleFor(i => i.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("DOB không được lớn hơn 100 tuổi");
            RuleFor(i => i.Email).NotEmpty().WithMessage("Bạn phải nhập Email")
                                    .Matches(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$").WithMessage("Email không đúng định dạng");
            RuleFor(i => i.PhoneNumber).NotEmpty().WithMessage("Bạn phải nhập phoneNumber");

            RuleFor(i => i.Password).NotEmpty().WithMessage("Bạn phải nhập mật khẩu");
            RuleFor(i => i).Custom((requset, context) =>
            {
                if(requset.Password != requset.ConfirmPassword)
                {
                    context.AddFailure("Xác nhận mật khẩu không đúng");
                }
            });
        }
    }
}
