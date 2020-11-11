using System.IO;
using System.Text.RegularExpressions;

namespace HTMLstrip
{
    class HTMLhandler
    {
        //Method to strip HTML from the a html file
        public string StripHTML(string filename)
        {
            string fileContent = ReadHTML(filename);
            return RemoveHTML(fileContent);   
        }


        //Method to read the .html file
        private string ReadHTML(string filename)
        {
            return File.ReadAllText(filename);
        }


        //Method to remove HTML tags and multiple blank spaces
        private string RemoveHTML(string content)
        {
            string output;

            //removes HTML tags
            output = Regex.Replace(content, "<[^>]*>", string.Empty);

            //removes multiple blank lines
            output = Regex.Replace(output, @"^\s*$\n", string.Empty, RegexOptions.Multiline);

            return output;
        }
    }
}
