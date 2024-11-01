using CasesProvider.Api.Data.Entities;
using CasesProvider.Api.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace CasesProvider.Api.Data.Contexts;

public class ApplicationDbContext : DbContext
{
	// DbSet properties for each entity
	public DbSet<User> Users { get; set; }
	public DbSet<CaseCategory> CaseCategories { get; set; }
	public DbSet<CaseSubCategory> CaseSubCategories { get; set; }
	public DbSet<SupportCase> SupportCases { get; set; }
	public DbSet<CommunicationType> CommunicationTypes { get; set; }
	public DbSet<CaseStatus> CaseStatuses { get; set; }

	// Constructor
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
			base.OnModelCreating(modelBuilder);

			// Configure enum properties to use string values
        modelBuilder.Entity<CaseCategory>()
            .Property(e => e.CategoryName)
            .HasConversion<string>();

        modelBuilder.Entity<CaseStatus>()
            .Property(e => e.StatusName)
            .HasConversion<string>();

        modelBuilder.Entity<CommunicationType>()
            .Property(e => e.Name)
            .HasConversion<string>();

			// Configure relationships
			modelBuilder.Entity<SupportCase>()
					.HasOne(sc => sc.CustomerUser)
					.WithMany(u => u.CustomerCases)
					.HasForeignKey(sc => sc.CustomerUserId)
					.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<SupportCase>()
					.HasOne(sc => sc.CaseOwnerUser)
					.WithMany(u => u.OwnedCases)
					.HasForeignKey(sc => sc.CaseOwnerUserId)
					.OnDelete(DeleteBehavior.Restrict);

			// Seed initial data
			SeedInitialData(modelBuilder);
	}

	private void SeedInitialData(ModelBuilder modelBuilder)
	{
		// Seed CaseStatus
		modelBuilder.Entity<CaseStatus>().HasData(
				new CaseStatus { Id = Guid.NewGuid(), StatusName = CaseStatusTypeEnum.NotOpened },
				new CaseStatus { Id = Guid.NewGuid(), StatusName = CaseStatusTypeEnum.Opened },
				new CaseStatus { Id = Guid.NewGuid(), StatusName = CaseStatusTypeEnum.Closed },
				new CaseStatus { Id = Guid.NewGuid(), StatusName = CaseStatusTypeEnum.Reopened }
		);

		// Seed CommunicationType
		modelBuilder.Entity<CommunicationType>().HasData(
				new CommunicationType { Id = Guid.NewGuid(), Name = CommunicationTypeEnum.Chat },
				new CommunicationType { Id = Guid.NewGuid(), Name = CommunicationTypeEnum.Mail },
				new CommunicationType { Id = Guid.NewGuid(), Name = CommunicationTypeEnum.Voice_Video }
		);

		// Seed Categories
		var orderCategory = new CaseCategory { Id = Guid.NewGuid(), CategoryName = CategoriesTypeEnum.Order, CreatedAt = DateTime.UtcNow };
		var accountCategory = new CaseCategory { Id = Guid.NewGuid(), CategoryName = CategoriesTypeEnum.Account, CreatedAt = DateTime.UtcNow };
		var productCategory = new CaseCategory { Id = Guid.NewGuid(), CategoryName = CategoriesTypeEnum.Product, CreatedAt = DateTime.UtcNow };

		modelBuilder.Entity<CaseCategory>().HasData(orderCategory, accountCategory, productCategory);

		// Seed SubCategories
		modelBuilder.Entity<CaseSubCategory>().HasData(
				// Order subcategories
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = orderCategory.Id, SubCategoryName = "Payment_issues", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = orderCategory.Id, SubCategoryName = "Refund_problems", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = orderCategory.Id, SubCategoryName = "Billing_discrepancies", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = orderCategory.Id, SubCategoryName = "Shipping_issues", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = orderCategory.Id, SubCategoryName = "Order_cancellation", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = orderCategory.Id, SubCategoryName = "Return_ticket", CreatedAt = DateTime.UtcNow },

				// Account subcategories
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = accountCategory.Id, SubCategoryName = "Login", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = accountCategory.Id, SubCategoryName = "Password", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = accountCategory.Id, SubCategoryName = "Verification", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = accountCategory.Id, SubCategoryName = "Profile", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = accountCategory.Id, SubCategoryName = "Security", CreatedAt = DateTime.UtcNow },

				// Product subcategories
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = productCategory.Id, SubCategoryName = "Product_defect", CreatedAt = DateTime.UtcNow },
				new CaseSubCategory { Id = Guid.NewGuid(), ParentCategoryId = productCategory.Id, SubCategoryName = "Stock", CreatedAt = DateTime.UtcNow }
		);
	}
}
