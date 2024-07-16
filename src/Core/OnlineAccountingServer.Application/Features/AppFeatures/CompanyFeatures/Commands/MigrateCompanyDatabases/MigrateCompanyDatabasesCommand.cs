using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabases
{
    public sealed record MigrateCompanyDatabasesCommand() : ICommand<MigrateCompanyDatabasesCommandResponse>;
}
