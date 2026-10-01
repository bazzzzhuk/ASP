using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Direction
	{
		[Key]
		public int DirectionID { get; set; }
		public string? direction_name { get; set; }

		public ICollection<Group>? Groups { get; set; }
	}
}
