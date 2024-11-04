using CasesProvider.Api.Data.Contexts;
using CasesProvider.Api.Data.Enums;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CasesDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/create", () => {
	// Alt 1. Kolla order-databas efter userId med email-adress

	// Alt 2. Kolla users-databas efter userId med email-adress

	// Alt 3. Skapa ny user i users-databas som 'Guest' och använd det userId:t

	// Alltså: 
	// Kolla order-databas efter email-adress => userId?
	// 		Om email inte finns i orderdb => kolla users
	// 	Kolla user-databas => userId?
	// 		Om email inte finns => skapa en Guest och ta userId från den

});

app.Run();

Console.WriteLine(CommunicationTypeEnum.Chat);

