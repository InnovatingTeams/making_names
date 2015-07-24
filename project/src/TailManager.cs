using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace project
{
	public class TailManager
	{
		public void OnUpdate(string code)
		{
			Task<string> finished;
			using (LockManager.GetLock("Network"))
			{
				// Prepare to poll service

				// Poll the service
			}

			finished.ContinueWith(s =>
			{
				// Parse the response
				var response = JsonConvert.DeserializeObject(s.Result);

				var tails = response.GetObject(code).GetArray("Tails").Where(t=>t.GetString("Af") == "F" && new[]{"C", "P", "p"}.Contains(t.GetString("Tc"))).ToList();

				using (LockManager.GetLock("database"))
				{
					// query for all the tails in the database

					// find the two deltas between the sets

					// Write new tails to the database

					// Remove missing tails from the database

					// Same upates to the cache

				}

				// Kick off background processing on new tails

				// Notify the UI to redraw itself
			});
		}
	}
}