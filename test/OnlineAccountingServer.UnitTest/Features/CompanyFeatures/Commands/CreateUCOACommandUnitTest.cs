using Moq;
using OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA;
using OnlineAccountingServer.Application.Services.CompanyServices;
using OnlineAccountingServer.Domain.CompanyEntities;
using Shouldly;

namespace OnlineAccountingServer.UnitTest.Features.CompanyFeatures.Commands
{
    public sealed class CreateUCOACommandUnitTest
    {
        private readonly Mock<IUCOAService> _ucoaService;

        public CreateUCOACommandUnitTest()
        {
            _ucoaService = new();
        }
        [Fact]
        public async Task UCOAShouldBeNull()
        {
            UniformChartOfAccount uniformChartOfAccount = await _ucoaService.Object.GetByCode("100.01.001");
            uniformChartOfAccount.ShouldBeNull();
        }
        [Fact]
        public async Task CreateUCOACommandResponseShouldNotBeNull()
        {
            var command = new CreateUCOACommand(
                Code: "100.01.001",
                Name: "TL Kasa",
                Type: 'M',
                CompanyId: "4d262f4d-33f6-48f6-adaa-f2a8212d4f24"
                );

            var handler = new CreateUCOACommandHandler(_ucoaService.Object);

            CreateUCOACommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
