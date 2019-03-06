using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Requestor
{
    public class Make
    {

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
    }
}
