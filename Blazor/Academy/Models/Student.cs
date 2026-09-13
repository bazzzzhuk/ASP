using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Student
	{
		[Key]
		[Required]
		[Column("stud_id")]

		public int stud_id { get; set; }

		[Required]
		public string last_name { get; set; }

		[Required]
		public string first_name { get; set; }

		public string? middle_name { get; set; }

		[Required]
		[Column("birth_date")]
		public DateOnly? BirthDate { get; set; }

		public string? email { get; set; }
		public string? phone { get; set; }

		[Column("photo", TypeName = "IMAGE")]
		public byte[]? Photo { get; set; }

		[ForeignKey("Group")]
		public int? group { get; set; }
	}
}
