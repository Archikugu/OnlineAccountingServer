using Microsoft.AspNetCore.Identity;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using OnlineAccountingServer.WebAPI.Configurations;
using OnlineAccountingServer.WebAPI.Middleware;


var builder = WebApplication.CreateBuilder(args);

builder.Services.InstallServices(builder.Configuration,typeof(IServiceInstaller).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionMiddleware();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

using (var scoped = app.Services.CreateScope())
{
    var userManager= scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if (!userManager.Users.Any())
    {
        userManager.CreateAsync(new AppUser
        {
            UserName = "Gokhan",
            Email="engokhangok@gmail.com",
            Id= Guid.NewGuid().ToString(),
            FirstName = "Gokhan",
            LastName="Gok"
        },"Dark.5227").Wait();
    }
}

app.Run();
