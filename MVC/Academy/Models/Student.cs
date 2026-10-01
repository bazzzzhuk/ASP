using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Student:Human
	{
		[Key]
		[Column("stud_id")]
		[Required]
		public int studID { get; set; }

		[StringLength(50, MinimumLength = 2)]
		//[RegularExpression("^[A-ZА-Я][a-zа-я]+$")]
		[Display(Name = "Фамилия")]
		public string last_name { get; set; }

		[Required]
		[StringLength(50, MinimumLength = 2)]
		[Display(Name = "Имя")]
		public string first_name { get; set; }
		[Display(Name = "Отчество")]
		public string? middle_name { get; set; }
		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "ДР")]
		public DateOnly birth_date { get; set; }

		[EmailAddress()]
		//[Required(AllowEmptyStrings = true)]
		public string? email { get; set; }

		[Phone]
		//[Required(AllowEmptyStrings = true)]
		[Display(Name = "Телефон")]
		public string? phone { get; set; }

		[Column("photo", TypeName = "IMAGE")]
		[Display(Name = "Фото")]
		public byte[]? photo { get; set; }

		//  Calculated properties:

		public string FullName
		{
			get => $"{last_name} {first_name} {middle_name}";
		}
		[Display(Name = "Возраст")]
		public int Age
		{
			get => CalculateAge(birth_date);

		}
		public static int CalculateAge(DateOnly dateOfBirth)
		{
			// Получаем текущую дату в формате DateOnly
			var today = DateOnly.FromDateTime(DateTime.Today);

			// Вычисляем разницу в годах
			int age = today.Year - dateOfBirth.Year;

			// Проверяем, наступил ли день рождения в этом году
			// Если месяц меньше, чем у даты рождения, либо месяц совпадает, но день дня рождения меньше,
			// значит, день рождения ещё не наступил — уменьшаем возраст на 1
			if (today.Month < dateOfBirth.Month || (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
			{
				age--;
			}

			return age;
		}

		[Required]
		[ForeignKey(nameof(Group))]
		public int? group { get; set; }

		//Navigation properties

		[Display(Name = "Группа")]
		public Group? Group { get; set; }
	}
}
