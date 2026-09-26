using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace Academy.Models
{
	[PrimaryKey("teacher", "discipline")]
	public class TeachersDisciplinesRelation
	{
		[JsonIgnore]
		[Column("teacher", TypeName = "SMALLINT")]
		[ForeignKey(nameof(Teacher))]
		public int teacher { get; set; }

		[JsonIgnore]
		[Column("discipline", TypeName = "SMALLINT")]
		[ForeignKey(nameof(Discipline))]
		public int discipline { get; set; }

		//navigation properties:
		[JsonIgnore]
		public Teacher Teacher { get; set; } = null!;
		[JsonIgnore]
		public Discipline Discipline { get; set; } = null!;
	}
}
