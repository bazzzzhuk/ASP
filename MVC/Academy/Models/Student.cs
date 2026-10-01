using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Student
	{
		public int stud_id { get; set; }
		public int? group { get; set; }
		//Navigation properties
		public Group? Group { get; set; }
	}
}
