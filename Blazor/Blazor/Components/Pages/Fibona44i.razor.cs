using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Fibona44i
	{
		private List<string> List_of_Fibona44i { get; set; } = new List<string>() { };
		int end_fibona44i = 0;
		void Fibona44i_f()
		{
			List_of_Fibona44i.Clear();
			BigInteger temp_value;
			BigInteger fibona44i_1 = 0;
			BigInteger fibona44i_2 = 1;
			List_of_Fibona44i.Add(fibona44i_1.ToString());

			while (end_fibona44i >= fibona44i_2)
			{
				List_of_Fibona44i.Add(fibona44i_2.ToString());
				temp_value = fibona44i_2;
				fibona44i_2 += fibona44i_1;
				fibona44i_1 = temp_value;
			}
		}
	}
}
