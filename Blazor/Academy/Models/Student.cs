using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Student:Human
	{
		[Key]
		[Column("stud_id")]
		public int stud_id { get; set; }

		[Required]
		[ForeignKey("Group")]
		public int? group { get; set; }
	}
}
