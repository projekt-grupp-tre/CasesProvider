using CasesProvider.Api.Data.Contexts;
using CasesProvider.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CasesProvider.Api.Services;

public class EmailService(CasesDbContext context)
{
	private CasesDbContext _context = context;

	public async Task CreateNewCaseAsync(CreateSupportCaseModel model)
	{

	}
}