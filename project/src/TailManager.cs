using System.Threading.Tasks;

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
				var response = JsonConvert.ParseObject(s.Result);

				var tails = response.GetObject(code).GetArray("Tails");

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