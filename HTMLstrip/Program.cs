using System;
using System.IO;
//D:\\Users\\fasp\\OneDrive - Universidade da Madeira\\UMa\\Mestrado\\Engenharia de Software\\4. Projeto\\HTMLstrip\\HTML-exercise.html
namespace HTMLstrip
{
    class Program
    {
        static void Main(string[] args)
        {
            HTMLhandler Htmlhandler = new HTMLhandler();
            string input;
            string result;

            ShowInstructions();

            for (; ; )
            {
                //Input
                Console.Write("\n? ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;

                //Show Results
                result = ShowResults(Htmlhandler, input);

                if (!result.Equals(""))
                {
                    //Show saving
                    ShowSaveFile(input, result);
                }
            }
        }

        private static void ShowInstructions()
        {
            Console.WriteLine(
                "HTMLstrip - version 0.1\n" +
                "** Alows users to extract blocks of text from an HTML file or string. **\n\n" +
                "For example:\n\n" +
                "\t? D:\\Users\\fasp\\Documents\\HTML-exercise.html (file directory)\n"
                );
        }

        private static string ShowResults(HTMLhandler Htmlhandler, string input)
        {
            InputHandler inputHandler = new InputHandler();
            string result;

            if (!inputHandler.ValidateInput(input))
            {
                Console.WriteLine("Not valid input\n");
                return "";
            }

            //Shows the result
            Console.WriteLine("\n\nText extracted from {0}:\n", input);
            result = Htmlhandler.StripHTML(input);
            Console.WriteLine(result);
            return result;
        }

        private static void ShowSaveFile(string input, string result)
        {
            SaveHandler saveHandler = new SaveHandler();

            //Saving Section
            Console.WriteLine("\n\n ***Save the text extracted in a .txt file? (Press Y to save or any key to continue)***");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                if (saveHandler.SaveResult(input, result))
                    Console.WriteLine("File sucessfully saved in the same directory as the submitted file");
                else
                    Console.WriteLine("Something went wrong while saving file");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("The text extracted wasn't saved");
            }
            Console.WriteLine("\nHTMLstrip - version 0.1");
        }

    }
}
