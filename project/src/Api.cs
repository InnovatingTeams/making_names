using System;
using System.Net;

namespace project.src
{
    internal class Api
    {
        public static WebRequest Put(string endpoint)
        {
            var request = WebRequest.Create(new Uri("https://api.example.com/" + endpoint));
            request.Credentials = new NetworkCredential("username", "password");
            request.Method = "PUT";
            return request;
        }
    }
}