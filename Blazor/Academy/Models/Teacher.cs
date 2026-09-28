using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Academy.Models
{
	public class Teacher:Human
	{
		[Key]
		[Column("teacher_id", TypeName = "SMALLINT")]
		public int teacher_id { get; set; }

		public DateOnly? work_since { get; set; }

		[DataType(DataType.Currency)]
		[Column(TypeName = "SMALLMONEY")]
		public decimal? Rate { get; set; }

		public string? exp {
			get => CalcStrExp(CalculateExp((DateOnly)work_since));
		}

		//Navigation properties:
		[JsonIgnore]
		public ICollection<TeachersDisciplinesRelation> DisciplinesRelations { get; set; } = default!;
		public static int CalculateExp(DateOnly work_since)
		{
			DateOnly endDate = DateOnly.FromDateTime(DateTime.Today);
			int monthsExp = (endDate.Year - work_since.Year) * 12 + (endDate.Month - work_since.Month);
			// Если день endDate раньше, чем startDate, уменьшаем на 1 месяц
			if (endDate.Day < work_since.Day)
			{
				monthsExp--;
			}
			if (monthsExp < 0)
				monthsExp = 0;
			return monthsExp;
		}
		public string CalcStrExp(int month_exp)
		{
			string exp = string.Empty;
			if (month_exp / 12 != 0) exp = GetAgeString(month_exp / 12);
			if (month_exp % 12 != 0) exp += GetMonthString(month_exp % 12);
			return exp;
		}
		public string GetAgeString(int year_exp)
		{
			int lastTwo = year_exp % 100;
			if (lastTwo >= 11 && lastTwo <= 19)return $"{year_exp} лет ";
			int lastDigit = lastTwo % 10;
			return lastDigit switch
			{
				1 => $"{year_exp} год ",
				2 => $"{year_exp} года ",
				3 => $"{year_exp} года ",
				4 => $"{year_exp} года ",
				_ => $"{year_exp} лет "
			};
		}
		public string GetMonthString(int months_exp)
		{
			int lastTwo = months_exp % 100;
			if (lastTwo >= 11 && lastTwo <= 19)return $"{months_exp} месяцев";
			int lastDigit = lastTwo % 10;
			return lastDigit switch
			{
				1 => $"{months_exp} месяц",
				2 => $"{months_exp} месяца",
				3 => $"{months_exp} месяца",
				4 => $"{months_exp} месяца",
				_ => $"{months_exp} месяцев"
			};
		}
	}
}
