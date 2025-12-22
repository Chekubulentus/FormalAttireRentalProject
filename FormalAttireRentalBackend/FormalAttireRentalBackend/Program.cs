using FormalAttireRentalBackend.Application.Common.Mappings;
using FormalAttireRentalBackend.Domain.Interfaces;
using FormalAttireRentalBackend.Infrastracture.DataContext;
using FormalAttireRentalBackend.Infrastracture.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database Context
builder.Services.AddDbContext<AttireRentalContext>(c => c.UseNpgsql(
    builder.Configuration.GetConnectionString("FormalAttireRentalDB")));

//MediatR
builder.Services.AddMediatR(c =>
{
    c.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

//AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

#region Services 
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
#endregion

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
