using Moq;
using OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class CreateRoleCommandUnitTest
    {

        private readonly Mock<IRoleService> _roleServiceMock;

        public CreateRoleCommandUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task AppRoleShouldBeNull()
        {
            AppRole appRole = await _roleServiceMock.Object.GetByCode("UCOA.Create");
            appRole.ShouldBeNull();
        }
        [Fact]
        public async Task CreateRoleCommandResponseShouldNotBeNull()
        {
            var command = new CreateRoleCommand(
                Code: "UCOA.Create",
                Name: "Hesap Planı Kayıt Ekleme");

            var handler = new CreateRoleCommandHandler(_roleServiceMock.Object);

            CreateRoleCommandResponse response = await handler.Handle(command, default); 
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
