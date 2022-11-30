namespace Lexercise5.GARAGE
{
    internal class UI
    {
        internal string GetInput()
        {
          return  Console.ReadLine()!;
        }

        internal void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}