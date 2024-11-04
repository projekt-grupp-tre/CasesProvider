using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasesProvider.Api.Data.Entities;

[Table("CaseSubCategories")]
public class CaseSubCategory
{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[Required]
		public Guid ParentCategoryId { get; set; }

		[Required]
		[StringLength(50)]
		public string SubCategoryName { get; set; } = null!;

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		public DateTime? UpdatedAt { get; set; }

		// Navigation properties
		[ForeignKey(nameof(ParentCategoryId))]
		public CaseCategory ParentCategory { get; set; } = null!;
}