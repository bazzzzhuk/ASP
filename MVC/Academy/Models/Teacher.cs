using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Teacher
	{
		public int Teacher_id { get; set; }
		public string? Last_name { get; set; }
		public string? First_name { get; set; }
		public string? Middle_name { get; set; }
		public DateOnly? BirthDate { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public byte[]? Photo { get; set; }
		public DateOnly? Work_since { get; set; }
		public decimal? Rate { get; set; }
	}
}
