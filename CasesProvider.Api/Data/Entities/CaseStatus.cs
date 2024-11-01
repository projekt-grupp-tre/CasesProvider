using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CasesProvider.Api.Data.Enums;

namespace CasesProvider.Api.Data.Entities;

[Table("CaseStatus")]
public class CaseStatus
{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[StringLength(50)]
		public CaseStatusTypeEnum StatusName { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		// Navigation properties
		public ICollection<SupportCase> SupportCases { get; set; }
}