using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasesProvider.Api.Data.Entities;

[Table("SupportCases")]
public class SupportCase
{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public bool? IsAccepted { get; set; } = false;

		public Guid? CustomerUserId { get; set; }

		[Required]
		public Guid CategoryId { get; set; }

		public Guid? CaseOwnerUserId { get; set; }

		public Guid? CaseCoOwnertUserId { get; set; }

		[Required]
		public Guid CaseStatusId { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		public DateTime? AssignedAt { get; set; }

		public DateTime? ClosedAt { get; set; }

		public DateTime? ReopenedAt { get; set; } 

		[Required]
		public Guid CommunicationTypeId { get; set; }

		// Navigation properties
		[ForeignKey(nameof(CustomerUserId))]
		public User CustomerUser { get; set; } = null!;

		[ForeignKey(nameof(CaseOwnerUserId))]
		public User? CaseOwnerUser { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public CaseCategory Category { get; set; } = null!;

		[ForeignKey(nameof(CaseStatusId))]
		public CaseStatus CaseStatus { get; set; } = null!;

		[ForeignKey(nameof(CommunicationTypeId))]
		public CommunicationType CommunicationType { get; set; } = null!;
}
