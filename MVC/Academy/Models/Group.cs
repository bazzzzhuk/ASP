using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Group
	{
		[Required]
		[Key]
		[Column("group_id")]
		public int groupID { get; set; }
		public string? group_name { get; set; }

		[ForeignKey(nameof(Direction))]
		[Column(TypeName = "TINYINT")]
		public int? direction { get; set; }

		[Column(TypeName = "TINYINT")]
		public int? weekdays { get; set; }

		public TimeOnly? start_time { get; set; }

		[RangeAttribute(typeof(DateOnly), "1900-12-31", "9999-12-31")]
		public DateOnly? start_date { get; set; }

		// Navigation properties:
		public Direction Direction { get; set; }

		ICollection<Student> Students { get; set; }
	}
}
