using MediatR;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using OnlineAccountingServer.Persistance.Context;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Persistance.Services.AppServices;
using OnlineAccountingServer.Domain;
using OnlineAccountingServer.Persistance;
using OnlineAccountingServer.Domain.UCOARepositories;
using OnlineAccountingServer.Persistance.Repositories.UCOARepositories;
using OnlineAccountingServer.Application.Services.CompanyServices;
using OnlineAccountingServer.Persistance.Services.CompanyServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<ICompanyService, CompanyService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IUCOACommandRepository, UCOACommandRepository>();
builder.Services.AddScoped<IUCOAQueryRepository, UCOAQueryRepository>();

builder.Services.AddScoped<IUCOAService, UCOAService>();

builder.Services.AddScoped<IContextService, ContextService>();


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(OnlineAccountingServer.Application.AssemblyReference).Assembly));

builder.Services.AddAutoMapper(typeof(OnlineAccountingServer.Persistance.AssemblyReference).Assembly);

builder.Services.AddControllers().AddApplicationPart(typeof(OnlineAccountingServer.Presentation.AssemblyReference).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setup =>
{
    var jwtSecurityScheme = new OpenApiSecurityScheme
    {
        BearerFormat = "JWT",
        Name = "JWT Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

    setup.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecurityScheme, Array.Empty<string>() }
    });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
