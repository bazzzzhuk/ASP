using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Discipline
	{
		public int discipline_id { get; set; }
		public string? discipline_name { get; set; }
		public int number_of_lessons { get; set; }
	}
}
