namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerator generator = new CharsGenerator();
            generator.GenerateFiles(1, 1);

            generator = new ByteGenerator();
            generator.GenerateFiles(1, 1);

            System.Console.WriteLine("!");
            System.Console.ReadLine();
        }
    }
}
