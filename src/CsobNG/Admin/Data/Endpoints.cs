namespace Admin.Data
{
	public class Endpoints
	{
		public static Dictionary<string, string> HealthEndpoints =
			new Dictionary<string, string>()
			{
				{"ClientAPI", "http://localhost:5208" },
				{"LoanRequestAPI", "http://localhost:5174" },
				{"EmailsAPI", "http://localhost:5032" },
				{"ClientBFF" , "http://localhost:5025"},
			};
	}
}
