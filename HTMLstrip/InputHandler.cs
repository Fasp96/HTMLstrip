using System.IO;
using System.Linq;

namespace HTMLstrip
{
    class InputHandler
    {
        //Method to verify if it's a .html file and if it exists
        public bool ValidateInput(string input)
        {
            return (File.Exists(input) && input.Split('.').Last().Equals("html"));
        }
    }
}
