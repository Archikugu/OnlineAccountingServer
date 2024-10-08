﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public sealed record LoginCommandResponse(string Token, string Email, string UserId, string FirstName, string LastName)
    {
        public string FullName => $"{FirstName} {LastName.ToUpper()}";
    }
}
