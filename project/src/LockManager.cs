using System;
using System.Collections.Concurrent;
using System.Threading;

namespace project
{
	public class LockManager
	{
		private class Lock : IDisposable
		{
			private readonly Mutex _mutex = new Mutex();

			public void Dispose()
			{
				_mutex.ReleaseMutex();
				_mutex.Dispose();
			}
		}

		private static readonly ConcurrentDictionary<string, Lock> Locks = new ConcurrentDictionary<string, Lock>();

		public static IDisposable GetLock(string @lock)
		{
			return Locks.GetOrAdd(@lock, _=>new Lock());
		}
	}
}