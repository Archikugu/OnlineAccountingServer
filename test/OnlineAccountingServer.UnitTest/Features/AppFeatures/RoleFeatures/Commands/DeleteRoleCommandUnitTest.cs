using Moq;
using OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class DeleteRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleServiceMock;

        public DeleteRoleCommandUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task AppRoleShouldNotBeNull()
        {
            _roleServiceMock.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());
        }

        [Fact]
        public async Task DeleteRoleCommandResponseShouldNotBeNull()
        {
            var command = new DeleteRoleCommand(
                Id: "4d262f4d-33f6-48f6-adaa-f2a8212d4f24");

            _roleServiceMock.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());

            var handler = new DeleteRoleCommandHandler(_roleServiceMock.Object);

            DeleteRoleCommandResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
