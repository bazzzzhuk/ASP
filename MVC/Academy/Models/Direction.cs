using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Direction
	{
		[Key]
		[Column("direction_id", TypeName = "TINYINT")]
		public int DirectionID { get; set; }
		public string? direction_name { get; set; }

		public ICollection<Group>? Groups { get; set; }
	}
}
