using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Group
	{
		[Required]
		[Key]
		public int group_id { get; set; }
		public string? group_name { get; set; }

		[ForeignKey(nameof(Direction))]
		[Column(TypeName = "TINYINT")]
		public int? direction {  get; set; }

		[Column(TypeName = "TINYINT")]
		public int? weekdays { get; set; }

		[Column(TypeName = "TIME(0)")]
		public TimeOnly? start_time { get; set; }

		[RangeAttribute(typeof(DateOnly), "1900-12-31", "9999-12-31")]
		public DateOnly? start_date { get; set; }

		// Navigation properties:
		public Direction Direction { get; set; }

		ICollection<Student> Students { get; set; }
	}
}