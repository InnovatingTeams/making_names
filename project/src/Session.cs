namespace project.src
{
    internal class Session
    {
        public static Session Current { get; internal set; }
        public User User { get; internal set; }
    }
}