namespace Blazor.Components.Pages
{
	public partial class Power
	{
		public int num_in = 1;
		int num_power = 1;
		double rezult = 0;
		void Power_calc()
		{
			rezult = Math.Pow(num_in, num_power);
		}
	}
}
