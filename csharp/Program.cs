using System.Runtime.Serialization.Formatters.Binary;

public class Program
{
    public static void Main(string[] args)
    {
        // exit if data file location argument was not provided
        if (args.Length == 0)
        {
            Console.WriteLine("Error: Save data not provided.");
            Environment.Exit(1);
        }

        // Check if the data file exists
        if (!File.Exists(args[0]))
        {
            Console.WriteLine("Error: Provided data file path does not exist.");
            Environment.Exit(1);
        }

        // read the data file
        string data = File.ReadAllText(args[0]);

        // serialize the data
		MemoryStream memoryStream = new MemoryStream();
		new BinaryFormatter().Serialize(memoryStream, data);

        // convert the data to a base64 string
		string base64String = Convert.ToBase64String(memoryStream.ToArray());

        // print the resulting base64 string to the console
        Console.WriteLine(base64String);
    }
}