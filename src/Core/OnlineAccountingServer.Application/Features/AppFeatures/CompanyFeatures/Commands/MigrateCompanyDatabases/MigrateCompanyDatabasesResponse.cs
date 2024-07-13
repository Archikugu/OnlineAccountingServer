using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabases
{
    public sealed class MigrateCompanyDatabasesResponse
    {
        public string Message { get; set; } = "Şirketlerin Database Bilgileri Migrate Edildi";
    }
}
