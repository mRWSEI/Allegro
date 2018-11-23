using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace AllegroOffers
{
    class crapClass
    {
        /*
       
        static string clientSecret = "S6qc1CP0EkMKRTZptn25UPACm33cPoEoTVSJMUvhi0lBjioTRZ3CnrITgvS4M6PM";
        public static string clientId = "aed37b6ec66e41cfab5c2ce667cba86b";

        public static string Authorization()
        {
            ////System.Diagnostics.Process.Start(
            //string url = "https://allegro.pl/auth/oauth/authorize?response_type=code&client_id=" + clientId + "&redirect_uri=http://localhost:8000";
            //System.Diagnostics.Process.Start(url);
            ///*var request = (HttpWebRequest)HttpWebRequest.Create(url);
            //request.Method = "GET";
            //request.AllowAutoRedirect = false;
            //request.ContentType = "application/x-www-form-urlencoded";
            //using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //{
            //    var location = response.GetResponseHeader("Location");
            //    return response.ToString();
            //}
            
            return "";
        }

        public static string GetTokenA()
        {
            //curl - XPOST--basic client_id:secret https://allegro.pl/auth/oauth/token'
            string code = "Pf2I97t6BTVNXkdepf2CdHSVSwuYQywq";
            string url = @"https://allegro.pl/auth/oauth/token?grant_type=client_credentials&redirect_uri=http://localhost:8000";
            System.Diagnostics.Process.Start(url);
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"basic {clientId}:{clientSecret}");
            return client.Execute(request).Content; //the Content (body) of the response

        }

        public static string GetToken()
        {
            string code = "tAIHGBRxv6SswsB7Qg8BhX5cisFlb5bx";
            string url = @"https://allegro.pl/auth/oauth/token";
            //System.Diagnostics.Process.Start(url);
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", $"basic {clientId}:{clientSecret}");
            //request.AddHeader("XPOST", $"basic {clientId}:{clientSecret}");
            request.AddHeader("data", $"grant_type=client_credentials&client_id={clientId}&client_secret={clientSecret}");

            return client.Execute(request).Content; //the Content (body) of the response

        }

        public static string Auth()
        {
            //curl - XPOST--basic client_id:secret https://allegro.pl/auth/oauth/token'
            string url = @"https://allegro.pl/auth/oauth/token?grant_type=client_credentials&redirect_uri=http://localhost:8000";
            System.Diagnostics.Process.Start(url);
            string code = "Pf2I97t6BTVNXkdepf2CdHSVSwuYQywq";
            string url2 = @"https://allegro.pl/auth/oauth/token?grant_type=client_credentials&redirect_uri=http://localhost:8000";
            System.Diagnostics.Process.Start(url2);
            var client = new RestClient(url2);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Basic {clientId}:{clientSecret}");
            return client.Execute(request).Content; //the Content (body) of the response
        }
    */
    }
}
