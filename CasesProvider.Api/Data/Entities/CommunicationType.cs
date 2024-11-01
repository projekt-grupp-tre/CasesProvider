using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CasesProvider.Api.Data.Enums;

namespace CasesProvider.Api.Data.Entities;

[Table("CommunicationTypes")]
public class CommunicationType
{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[Required]
		[StringLength(50)]
		public CommunicationTypeEnum Name { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

		// Navigation properties
		public ICollection<SupportCase> SupportCases { get; set; }
}