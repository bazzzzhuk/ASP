using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Discipline
	{
		[Key]
		public int disciplineID { get; set; }
		public string? discipline_name { get; set; }
		public int number_of_lessons { get; set; }
	}
}
