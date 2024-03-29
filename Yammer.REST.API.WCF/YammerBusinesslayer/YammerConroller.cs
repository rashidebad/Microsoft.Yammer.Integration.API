using MCKD_YammerWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace MCKD_YammerWCF.YammerBusinesslayer
{
    [Serializable]
    [DataContract]
    public class CheckoutDetailsRequest
    {
        [DataMember]
        public string userName;
        [DataMember]
        public string password;
        [DataMember]
        public string checkoutId;
        [DataMember]
        public string language;
    }

    public class YammerConroller
    {
        private string clientId = "lo8yefdderjiere3";
        private string developerToken = "734897348943nfdnjfdfd34";
        public string GetOAuth2Token()
        {
            /*
            //Do the Yammer OAuth2 request and pass ClientID
            //https://developer.yammer.com/docs/oauth-2

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => { return true; };

            //var checkoutDetailsResponse = new CheckoutDetailsResponse();
            var CheckoutDetailsResponse = new Object();
            WebRequestHandler handler = new WebRequestHandler()
            {
                AllowAutoRedirect = false,
                UseProxy = false,
                ClientCertificateOptions = ClientCertificateOption.Automatic
            };
            using (HttpClient client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri("https://developer.yammer.com/docs/oauth-2");
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var serializer = new JavaScriptSerializer();
                var httpContent = new StringContent(serializer.Serialize(checkoutDetailsRequest), Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = client.GetAsync("details/", httpContent).Result)
                {
                    response.EnsureSuccessStatusCode();
                    Task<string> responseTask = response.Content.ReadAsStringAsync();
                    responseTask.Wait();
                    checkoutDetailsResponse = serializer.Deserialize<CheckoutDetailsResponse>(responseTask.Result);

                }
            }
            return checkoutDetailsResponse;
            */
            return null;
        }


        public GroupMessagesRespone GetRecentAnnouncements()
        {
            GroupMessagesRespone groupMessagesRespone = new GroupMessagesRespone();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => { return true; };
            var CheckoutDetailsResponse = new Object();
            WebRequestHandler handler = new WebRequestHandler()
            {
                AllowAutoRedirect = false,
                UseProxy = false,
                ClientCertificateOptions = ClientCertificateOption.Automatic
            };
            using (HttpClient client = new HttpClient(handler))
            {

                string apiURL = "https://www.yammer.com/api/v1/messages/in_group/29716217856.json?access_token=lOkBqRdETfYnXIHO40kIA&threaded=true&limit=1";
                client.BaseAddress = new Uri(apiURL);
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization =new AuthenticationHeaderValue("Bearer", "9jfdelk0327782690-8943");
                var serializer = new JavaScriptSerializer();
                //var httpContent = new StringContent(serializer.Serialize(), Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = client.GetAsync(apiURL).Result)
                {
                    response.EnsureSuccessStatusCode();
                    Task<string> responseTask = response.Content.ReadAsStringAsync();
                    responseTask.Wait();
                   var groupMessagesRespone1 = serializer.Deserialize<GroupMessagesRespone>(responseTask.Result);

                }
            }
            return groupMessagesRespone;
        }

    }
}