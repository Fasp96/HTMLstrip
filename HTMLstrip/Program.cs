using System;
//D:\\Users\\fasp\\OneDrive - Universidade da Madeira\\UMa\\Mestrado\\Engenharia de Software\\4. Projeto\\HTMLstrip\\HTML-exercise.html
namespace HTMLstrip
{
    class Program
    {
        private const string instructionsMessage = 
            "** Alows users to extract blocks of text from an HTML file or string. **\n\n" +
            "For example:\n\n" +
            "\t? D:\\Users\\fasp\\Documents\\HTML-exercise.html (file directory)\n\n" +
            "\t? \"<h1>Hello World!!</h1>\" (simple string)\n\n";

        private const string savingMessage = 
            "\n\n ***Save the text extracted in a .txt file? (Press Y to save or any key to continue)***";

        static void Main(string[] args)
        {
            HTMLhandler Htmlhandler = new HTMLhandler();

            Console.WriteLine("HTMLstrip - version 0.1");
            Console.WriteLine(instructionsMessage);

            for (; ; )
            {
                //Input
                Console.Write("? ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;

                //Shows the result
                Console.WriteLine("\n\nText extracted from {0}:\n", input);
                string result = Htmlhandler.StripHTML(input);
                Console.WriteLine(result);

                //Saving Section
                Console.WriteLine(savingMessage);
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    Console.Clear();

                    if (Htmlhandler.SaveResult(input, result))
                        Console.WriteLine("File sucessfully saved in the same directory as the submitted file\n\n");
                    else
                        Console.WriteLine("Something went wrong while saving file\n\n");

            }
        }
    }
}
