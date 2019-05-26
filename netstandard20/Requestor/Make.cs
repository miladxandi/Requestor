using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Requestor
{
    public class Make
    {
        private static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// This method returns an string as its response to work on it
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="Method"></param>
        /// <returns name="Response" ></returns>
        public string Request(string URL, string Method = "GET")
        {
            WebRequest Req = WebRequest.Create(URL);
            Req.Method = Method;
            WebResponse Res = Req.GetResponse();
            Stream dataStream = Res.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string Response = reader.ReadToEnd();
            return Response;
        }

        /// <summary>
        /// This method returns an string as its response to work on it
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="Values"></param>
        /// <returns name="Response" ></returns>
        public async Task<string> RequestAsync(string URL, Dictionary<string, string> Values)
        {
            var content = new FormUrlEncodedContent(Values);

            var response = await client.PostAsync(URL, content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString.ToString();
        }
    }
}
