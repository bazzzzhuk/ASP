using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
	public class Instructor
	{
		public string ID { get; set; }
		[Required]
		[StringLength(50)]
		[Display(Name ="Фамилия")]
		public string LastName { get; set; }
		[Required,StringLength(50)]
		[Display(Name ="Имя")]
		public string FirstName { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
		[Display(Name =	"Дата трудоустройства")]
		public DateTime HireDate { get; set; }

		//calc properties:
		[Display(Name ="Инструктор")]
		public string FullName
		{
			get=>$"{LastName} {FirstName}";
		}

		//TODO:Nav properties:
	}
}
