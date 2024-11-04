using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace CasesProvider.Api.Data.Entities;

[Table("Users")]
public class User
{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Role { get; set; } = null!;

		[Required]
		[StringLength(50)]
		public string UserName { get; set; } = null!;

		[Required]
		[StringLength(100)]
		[EmailAddress]
		public string Email { get; set; } = null!;

		public ICollection<SupportCase>? CustomerCases { get; set; }
		public ICollection<SupportCase>? OwnedCases { get; set; }
}