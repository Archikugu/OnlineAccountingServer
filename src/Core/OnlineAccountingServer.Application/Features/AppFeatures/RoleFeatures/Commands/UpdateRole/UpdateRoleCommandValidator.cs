using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
    {
        public UpdateRoleCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Id Bilgisi Boş Olamaz!");
            RuleFor(p => p.Id).NotNull().WithMessage("Id Bilgisi Boş Olamaz!!");
            RuleFor(p => p.Code).NotEmpty().WithMessage("Role Kodu Boş Olamaz!");
            RuleFor(p => p.Code).NotNull().WithMessage("Role Kodu Boş Olamaz!");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Role Adı Boş Olamaz!");
            RuleFor(p => p.Name).NotNull().WithMessage("Role Adı Boş Olamaz!");
        }
    }
}
