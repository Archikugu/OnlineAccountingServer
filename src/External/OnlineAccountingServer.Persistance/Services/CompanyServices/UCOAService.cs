using AutoMapper;
using OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA;
using OnlineAccountingServer.Application.Services.CompanyServices;
using OnlineAccountingServer.Domain;
using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.UCOARepositories;
using OnlineAccountingServer.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Persistance.Services.CompanyServices
{
    public sealed class UCOAService : IUCOAService
    {
        private readonly IUCOACommandRepository _commandRepository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public UCOAService(IUCOACommandRepository commandRepository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateUCOAAsync(CreateUCOARequest request)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);

            UniformChartOfAccount uniformChartOfAccount = _mapper.Map<UniformChartOfAccount>(request);
            uniformChartOfAccount.Id = Guid.NewGuid().ToString();

            await _commandRepository.AddAsync(uniformChartOfAccount);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
