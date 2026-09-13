using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Teacher
	{
		[Required]
		[Key]
		[Column(TypeName = "SMALLINT")]
		public int Teacher_id { get; set; }
		[Required]
		public string? Last_name { get; set; }

		[Required]
		public string? First_name { get; set; }

		public string? Middle_name { get; set; }

		[Required]
		[Column("birth_date")]
		public DateOnly? BirthDate { get; set; }

		public string? Email { get; set; }
		public string? Phone { get; set; }

		[Column("photo", TypeName = "IMAGE")]
		public byte[]? Photo { get; set; }
		public DateOnly? Work_since { get; set; }

		[Column(TypeName = "SMALLMONEY")]
		public decimal? Rate { get; set; }
	}
}
