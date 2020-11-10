using System.IO;
using System.Linq;

namespace HTMLstrip
{
    class InputHandler
    {
        //Method to verify if is a .html file and if it it exists and returns true or false
        public bool ValidateInput(string input)
        {
            return (File.Exists(input) && input.Split('.').Last().Equals("html"));
        }
    }
}
