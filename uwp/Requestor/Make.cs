using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Requestor
{
    class Make
    {
        public async Task<string> Request(string URL, string Method = "GET")
        {
            WebRequest Req = WebRequest.Create(URL);
            Req.Method = Method;
            WebResponse Res = await Req.GetResponseAsync();
            Stream dataStream = Res.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string Response = reader.ReadToEnd();
            return Response;
        }
    }
}
