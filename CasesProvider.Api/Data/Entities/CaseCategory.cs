using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CasesProvider.Api.Data.Enums;

namespace CasesProvider.Api.Data.Entities;

[Table("CaseCategories")]
public class CaseCategory
{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[Required]
		[StringLength(50)]
		public CategoriesTypeEnum CategoryName { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		public DateTime? UpdatedAt { get; set; }

		// Navigation properties
		public ICollection<SupportCase> SupportCases { get; set; } = null!;
		public ICollection<CaseSubCategory> SubCategories { get; set; } = null!;
}
