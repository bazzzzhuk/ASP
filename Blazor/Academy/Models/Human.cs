using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Human
	{
		[Required]
		[StringLength(50, MinimumLength = 2)]
		[RegularExpression("^[A-ZА-Я][a-zа-я]+$")]
		public string last_name { get; set; }

		[Required]
		[StringLength(50, MinimumLength = 2)]
		public string first_name { get; set; }

		public string? middle_name { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateOnly birth_date { get; set; }

		[EmailAddress]
		public string? email { get; set; }

		[Phone]
		public string? phone { get; set; }

		[Column("photo", TypeName = "IMAGE")]
		public byte[]? photo { get; set; }

		//  Calculated properties:

		public string FullName
		{
			get => $"{last_name} {first_name} {middle_name}";
		}
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
	}
}
