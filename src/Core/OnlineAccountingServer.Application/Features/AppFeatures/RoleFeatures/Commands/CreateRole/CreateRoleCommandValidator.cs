using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
            RuleFor(p => p.Code).NotEmpty().WithMessage("Role Kodu Boş Olamaz!");
            RuleFor(p => p.Code).NotNull().WithMessage("Role Kodu Boş Olamaz!");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Role Adı Boş Olamaz!");
            RuleFor(p => p.Name).NotNull().WithMessage("Role Adı Boş Olamaz!");
        }
    }
}
