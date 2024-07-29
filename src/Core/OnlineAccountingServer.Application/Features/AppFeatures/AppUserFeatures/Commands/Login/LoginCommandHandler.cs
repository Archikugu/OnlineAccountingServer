using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Abstractions;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users.Where(p => p.Email == request.EmailOrUserName || p.UserName == request.EmailOrUserName).FirstOrDefaultAsync();
            if (user == null)
                throw new Exception("Kullanıcı Bulunamadı");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);

            if (!checkUser) throw new Exception("Şifreniz Yanlış!");

            List<string> roles = new List<string>();

            LoginCommandResponse response = new(
                user.Email,
                user.FirstName,
                user.LastName,
                user.Id,
                await _jwtProvider.CreateTokenAsync(user, roles));

            return response;
        }
    }
}
