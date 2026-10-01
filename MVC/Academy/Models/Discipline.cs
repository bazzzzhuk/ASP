using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Discipline
	{
		[Key]
		[Column("discipline_id", TypeName = "SMALLINT")]
		public int disciplineID { get; set; }

		[Required]
		public string? discipline_name { get; set; }

		[Required]
		[Column(TypeName = "TINYINT")]
		public int number_of_lessons { get; set; }
	}
}
