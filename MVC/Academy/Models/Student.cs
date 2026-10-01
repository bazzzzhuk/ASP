using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Student
	{
		[Key]
		public int studID { get; set; }
		public int? group { get; set; }
		//Navigation properties
		public Group? Group { get; set; }
	}
}
