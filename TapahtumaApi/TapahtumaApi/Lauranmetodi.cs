using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static TapahtumaApi.Program;
using System.Linq;

namespace TapahtumaApi
{
	public class Laura
	{
		public static async Task LauranMetodi() //Hakee kaikki tämän päivän tapahtumat
		{

			const string url = "http://open-api.myhelsinki.fi/v1/events/";
			string urlParams = "";

			Eventlist eventsNow = await ApiHelper.RunAsync<Eventlist>(url, urlParams);

			//var tapahtumatNyt = eventsNow.data.Where(date.event_dates.starting_day || date.event_dates.ending_day == DateTime.Now);
			var tapahtumatKohta = from i in eventsNow.data where i.event_dates.starting_day >= DateTime.Now && i.event_dates.ending_day < DateTime.Now.AddDays(1) select i;

			foreach (var tapahtumat in tapahtumatKohta)
			{
				Console.WriteLine(tapahtumat.name.fi + "\n");
				Console.WriteLine(tapahtumat.description.body.Replace("<br>", "")
					.Replace("<p>", "").Replace("<span>", "").Replace("<br />", "")
					.Replace("</span>", "").Replace("</p>", "").Replace("&nbsp;", "" + "\n"));
				Console.WriteLine(tapahtumat.event_dates.starting_day + "-" + tapahtumat.event_dates.ending_day + "\n");

				Console.WriteLine("*********************************************************");

				if (eventsNow == null)
				{
					Console.WriteLine("Tänään ei ole tapahtumia");
				}

			}




			/*static async Task LauranMetodi2() //Hakee kaikki kiinankieliset tapahtumat ajalta 1.6.2022-30.8.2022
			{
				const string url = "http://open-api.myhelsinki.fi/v1/events/";
				string urlParams = "?language-filter=zh";

				Eventlist eventsChinese = await ApiHelper.RunAsync<Eventlist>(url, urlParams);

				DateTime d1 = new DateTime(2022, 06, 01);
				DateTime d2 = new DateTime(2022, 08, 30);

				var tapahtumatKiina = from i in eventsChinese.data where i.event_dates.starting_day >= d1 && i.event_dates.ending_day <= d2 select i;

				foreach (var tapahtumat in tapahtumatKiina)
				{
					Console.WriteLine("Kiinankieliset tapahtumat ajalla 1.6.2022-30.8.2022: " + "\n");
					Console.WriteLine(tapahtumat.name.zh + "\n");
					Console.WriteLine(tapahtumat.description.intro + "\n");


					Console.WriteLine("*********************************************************");

					if (eventsChinese == null)
					{
						Console.WriteLine("Kiinankielisiä tapahtumia ei löydy");
					}



				}



			}*/


		}
	}
}
