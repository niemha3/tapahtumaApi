using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static TapahtumaApi.Program;
using System.Linq;

namespace TapahtumaApi
{
	public class Eventit
	{
		public static async Task LauranMetodi2() //Hakee kaikki ruotsinkieliset tapahtumat ajalta 1.6.2022-30.8.2022
		{
			const string url = "http://open-api.myhelsinki.fi/v1/events/";
			string urlParams = "";

			Eventlist eventsSwedish = await ApiHelper.RunAsync<Eventlist>(url, urlParams);

			DateTime d1 = new DateTime(2022, 06, 01);
			DateTime d2 = new DateTime(2022, 08, 30);

			
			var tapahtumatRuotsi = from i in eventsSwedish.data where i.event_dates.starting_day >= d1 && i.event_dates.ending_day <= d2 select i;
			var tapahtumatRuotsi2 = from i in tapahtumatRuotsi select i.name.sv;
			var tapahtumatRuotsi3 = from i in tapahtumatRuotsi2 where i != null select i;
			//var tapahtumatRuotsi4 = from i in tapahtumatRuotsi3 where i.Contains(i)select i.FirstOrDefault();



			Console.WriteLine("Ruotsinkieliset tapahtumat ajalla 1.6.2022-30.8.2022: " + "\n");

			foreach (var tapahtumat in tapahtumatRuotsi3.Distinct())
			{
				
				Console.WriteLine(tapahtumat);
				


				Console.WriteLine("*********************************************************");

				/*if ()
				{
					
				}*/
			}
		}
	}
}
