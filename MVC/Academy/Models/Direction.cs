namespace Academy.Models
{
	public class Direction
	{
		public int Direction_id { get; set; }
		public string? direction_name { get; set; }

		public ICollection<Group>? Groups { get; set; }
	}
}
