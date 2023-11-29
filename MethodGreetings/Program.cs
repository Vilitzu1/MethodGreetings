namespace MethodGreetings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Heidi";
            string friend2 = "Juha";
            string friend3 = "Niina";

            GreetFriends(friend1);
            GreetFriends(friend2);
            GreetFriends(friend3);
        }
        public static void GreetFriends(string friendName) 
        { 
            Console.WriteLine("Hi " + friendName + ", my friend!");
        }
    }
}
