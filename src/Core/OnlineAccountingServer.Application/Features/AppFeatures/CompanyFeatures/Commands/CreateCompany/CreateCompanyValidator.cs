using FluentValidation;

namespace OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyValidator : AbstractValidator<CreateCompanyCommand>
    {
        public CreateCompanyValidator()
        {
            RuleFor(p => p.DatabaseName).NotEmpty().WithMessage("Database Bilgisi Yazılmalıdır!");
            RuleFor(p => p.DatabaseName).NotNull().WithMessage("Database Bilgisi Yazılmalıdır!");
            RuleFor(p => p.ServerName).NotEmpty().WithMessage("Server Bilgisi Yazılmalıdır!");
            RuleFor(p => p.ServerName).NotNull().WithMessage("Server Bilgisi Yazılmalıdır!");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Şirket Adı Yazılmalıdır!");
            RuleFor(p => p.Name).NotNull().WithMessage("Şirket Adı Yazılmalıdır!");
        }
    }
}
