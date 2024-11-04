
namespace CasesProvider.Api.Models;

public class CreateSupportCaseModel
{
		public bool? IsAccepted { get; set; } = false;

		public Guid? CustomerUserId { get; set; }

		public Guid CategoryId { get; set; }

		public Guid? CaseOwnerUserId { get; set; }

		public Guid? CaseCoOwnertUserId { get; set; }

		public Guid CaseStatusId { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		public DateTime? AssignedAt { get; set; }

		public DateTime? ClosedAt { get; set; }

		public DateTime? ReopenedAt { get; set; } 

		public Guid CommunicationTypeId { get; set; }

}
