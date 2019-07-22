using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.Application.Services;
using DNTFrameworkCore.EFCore.Application;
using DNTFrameworkCore.EFCore.Context;
using DNTFrameworkCore.Eventing;
using DNTFrameworkCore.Functional;
using DNTFrameworkCore.TestWebApp.Application.Academy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;



namespace DNTFrameworkCore.TestWebApp.Application.Academy
{
    public interface IAcademyService : ICrudService<int, AcademyModel>
    {
    }
    public class AcademyService : CrudService<Domain.Academy.Academy, int, AcademyModel>, IAcademyService
    {
        private readonly ILogger<AcademyService> _logger;
        private readonly IMapper _mapper;
        public AcademyService(IUnitOfWork uow, IEventBus bus, IMapper mapper, ILogger<AcademyService> logger) : base(uow, bus)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        protected override IQueryable<AcademyModel> BuildReadQuery(FilteredPagedQueryModel model)
        {
            return EntitySet.AsNoTracking()
    .Select(b => new AcademyModel
    {
        Id = b.Id,
        RowVersion = b.RowVersion,
        AcademyName = b.AcademyName,
        Address = b.Address,
        Description = b.Description,
        Phone = b.Phone,
        User = b.User,
        UserId = b.UserId
    });
        }

        protected override void MapToEntity(AcademyModel model, Domain.Academy.Academy entity)
        {
            _mapper.Map(model, entity);
        }



        protected override AcademyModel MapToModel(Domain.Academy.Academy entity)
        {
            return _mapper.Map<AcademyModel>(entity);
        }

        protected override Task AfterFindAsync(IReadOnlyList<AcademyModel> models)
        {
            _logger.LogInformation(nameof(AfterFindAsync));

            return Task.CompletedTask;
        }

        protected override Task AfterMappingAsync(IReadOnlyList<AcademyModel> models, IReadOnlyList<Domain.Academy.Academy> Academy)
        {
            _logger.LogInformation(nameof(AfterMappingAsync));

            return Task.CompletedTask;
        }


        protected override Task<Result> BeforeCreateAsync(IReadOnlyList<AcademyModel> models)
        {
            _logger.LogInformation(nameof(BeforeCreateAsync));

            return Task.FromResult(Ok());
        }


        protected override Task<Result> AfterCreateAsync(IReadOnlyList<AcademyModel> models)
        {
            _logger.LogInformation(nameof(AfterCreateAsync));

            return Task.FromResult(Ok());
        }


        protected override Task<Result> BeforeEditAsync(
    IReadOnlyList<ModifiedModel<AcademyModel>> models, IReadOnlyList<Domain.Academy.Academy> blogs)
        {
            _logger.LogInformation(nameof(BeforeEditAsync));

            return Task.FromResult(Ok());
        }


        protected override Task<Result> AfterEditAsync(
    IReadOnlyList<ModifiedModel<AcademyModel>> models, IReadOnlyList<Domain.Academy.Academy> blogs)
        {
            _logger.LogInformation(nameof(AfterEditAsync));

            return Task.FromResult(Ok());
        }


        protected override Task<Result> BeforeDeleteAsync(IReadOnlyList<AcademyModel> models)
        {
            _logger.LogInformation(nameof(BeforeDeleteAsync));

            return Task.FromResult(Ok());
        }

        protected override Task<Result> AfterDeleteAsync(IReadOnlyList<AcademyModel> models)
        {
            _logger.LogInformation(nameof(AfterDeleteAsync));

            return Task.FromResult(Ok());
        }




    }

}

