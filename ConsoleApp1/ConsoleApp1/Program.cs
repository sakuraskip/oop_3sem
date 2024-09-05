namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];
            try
            {
                str[4] = "anything";
                Console.WriteLine("It's OK");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}

