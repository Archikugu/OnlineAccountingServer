﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.RoleFeatures.Queries.GetAllRoles
{
    public sealed class GetAllRolesRequest :IRequest<GetAllRolesResponse>
    {
    }
}
