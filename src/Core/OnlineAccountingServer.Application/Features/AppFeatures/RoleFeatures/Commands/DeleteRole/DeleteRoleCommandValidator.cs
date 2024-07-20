using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
    {
        public DeleteRoleCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Id Bilgisi Boş Olamaz!");
            RuleFor(p => p.Id).NotNull().WithMessage("Id Bilgisi Boş Olamaz!!");
        }
    }
}
