using AutoMapper;
using OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA;
using OnlineAccountingServer.Application.Services.CompanyServices;
using OnlineAccountingServer.Domain;
using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories.UCOARepositories;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.Services.CompanyServices
{
    public sealed class UCOAService : IUCOAService
    {
        private readonly IUCOACommandRepository _commandRepository;
        private readonly IUCOAQueryRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public UCOAService(IUCOACommandRepository commandRepository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper, IUCOAQueryRepository queryRepository)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _queryRepository = queryRepository;
        }

        public async Task CreateUCOAAsync(CreateUCOACommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);

            UniformChartOfAccount uniformChartOfAccount = _mapper.Map<UniformChartOfAccount>(request);
            uniformChartOfAccount.Id = Guid.NewGuid().ToString();

            await _commandRepository.AddAsync(uniformChartOfAccount, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<UniformChartOfAccount> GetByCode(string code)
        {

            return await _queryRepository.GetFirstByExpression(p => p.Code == code);
        }
    }
}
