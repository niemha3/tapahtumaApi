using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static TapahtumaApi.Program;
using System.Linq;

namespace TapahtumaApi
{

    class Jere
    {
        public static async Task JerenMetodi()
        {
            const string url = "http://open-api.myhelsinki.fi/v1/places/" ;
            string urlParams = "";

            Class1.Datum tapahtuma = await ApiHelper.RunAsync<Class1.Datum>(url, urlParams);


        }
    }
}
