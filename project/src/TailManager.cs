using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.XPath;
using Newtonsoft.Json;

namespace project
{
	public class TailManager
	{
		public void OnUpdate(string code)
		{
			Task<WebResponse> finished;
			var request = HttpWebRequest.Create(new Uri(string.Format("https://rt.faa.gov/{0}/114", code)));
			request.Credentials = new NetworkCredential("username", "password");

			using (LockManager.GetLock("Network"))
			{
				finished = Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null);
			}

			finished.ContinueWith(s =>
			{
				var response = JsonConvert.DeserializeXNode(new StreamReader(s.Result.GetResponseStream()).ReadToEnd());

				var tails = response.XPathSelectElements("Tails").Where(t=>t.Attribute("Af")?.Value == "F" && new[]{"C", "P", "p"}.Contains(t.Attribute("Tc")?.Value)).ToList();

				using (LockManager.GetLock("database"))
				{
					// query for all the tails in the database

					// find the two deltas between the sets

					// Write new tails to the database

					// Remove missing tails from the database

					// Same upates to the cache

				}

				// Kick off background processing on new tails

				// Update UI from two sets of tails.
			});
		}
	}
}