using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace project.src
{
    public static class WebRequestExtensions
    {
        public static WebRequest SetData(this WebRequest request, string data)
        {
            using (var stream = request.GetRequestStream())
            {
                var content = Encoding.UTF8.GetBytes(data);
                stream.Write(content, 0, content.Length);
            }
            return request;
        }

        public static Task<WebResponse> SendAsync(this WebRequest request)
        {
            return Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null);
        }
    }
}