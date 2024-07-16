using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA
{
    public sealed record CreateUCOACommand(string Code, string Name, char Type, string CompanyId) :ICommand<CreateUCOACommandResponse>;
}
