namespace FormatAndCountOfCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CSReader reader = new CSReader("input.cs", "test.cs");
            reader.Run();
        }
    }
}