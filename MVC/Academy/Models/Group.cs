using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Group
	{
		public int group_id { get; set; }
		public string? group_name { get; set; }
		public int? direction { get; set; }
		public int? weekdays { get; set; }
		public TimeOnly? start_time { get; set; }
		public DateOnly? start_date { get; set; }
		// Navigation properties:
		public Direction? Direction { get; set; }
		ICollection<Student>? Students { get; set; }
	}
}
