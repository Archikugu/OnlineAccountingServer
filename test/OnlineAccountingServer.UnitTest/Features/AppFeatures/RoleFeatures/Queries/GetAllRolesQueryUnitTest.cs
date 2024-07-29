using Moq;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.UnitTest.Features.AppFeatures.RoleFeatures.Queries
{
    public sealed class GetAllRolesQueryUnitTest
    {
        private readonly Mock<IRoleService> _roleServiceMock;

        public GetAllRolesQueryUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task GetAllQueryResponseShouldNotBeNull()
        {
            _roleServiceMock.Setup(r => r.GetAllRolesAsync()).ReturnsAsync(new List<AppRole>());
        }
    }
}
