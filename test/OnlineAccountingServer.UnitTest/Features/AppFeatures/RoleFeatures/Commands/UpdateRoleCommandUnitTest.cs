using Moq;
using OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class UpdateRoleCommandUnitTest
    {

        private readonly Mock<IRoleService> _roleServiceMock;

        public UpdateRoleCommandUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task AppRoleShouldNotBeNull()
        {
            _roleServiceMock.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());
        }

        [Fact]
        public async Task AppRoleCodeShouldBeUniqe()
        {
            AppRole checkRoleCode = await _roleServiceMock.Object.GetByCode("UCOA.Create");
            checkRoleCode.ShouldBeNull();
        }


        [Fact]
        public async Task UpdateRoleCommandResponseShouldNotBeNull()
        {
            var command = new UpdateRoleCommand(
                Id: "609d6ec7-ade2-4ecc-881d-e7b8198801eb",
                Code: "UCOA.Update",
                Name: "Hesap Planı Kayıt Güncelleme");

            //AppRoleShouldNotBeNull();
            _roleServiceMock.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());

            var handler = new UpdateRoleCommandHandler(_roleServiceMock.Object);

            UpdateRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }

    }
}
