﻿using FluentValidation;

namespace OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA
{
    public sealed class CreateUCOACommandValidator:AbstractValidator<CreateUCOACommand>
    {
        public CreateUCOACommandValidator()
        {
            RuleFor(p => p.Code).NotEmpty().WithMessage("Hesap planı kodu boş olamaz!");
            RuleFor(p => p.Code).NotNull().WithMessage("Hesap planı kodu boş olamaz!");
            RuleFor(p => p.Code).MinimumLength(5).WithMessage("Hesap planı kodu en az 5 karakter olmalıdır!");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Hesap planı adı boş olamaz!");
            RuleFor(p => p.Name).NotNull().WithMessage("Hesap planı adı boş olamaz!");
            RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket bilgisi adı boş olamaz!");
            RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket bilgisi adı boş olamaz!");
            RuleFor(p => p.Type).NotNull().WithMessage("Hesap planı tipi boş olamaz!");
            RuleFor(p => p.Type).NotEmpty().WithMessage("Hesap planı tipi boş olamaz!");
            RuleFor(p => p.Type.ToString()).Length(1).WithMessage("Hesap planı tipi 1 karakter olmalıdır!");
        }
    }
}
