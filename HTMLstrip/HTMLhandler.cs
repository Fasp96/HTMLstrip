using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HTMLstrip
{
    class HTMLhandler
    {

        public string StripHTML(string filename)
        {
            if(!ValidateFilename(filename)) return "Not valid filename";

            else
            {
                string fileContent = ReadHTML(filename);
                return RemoveHTML(fileContent);
            }
            
        }

        //Method to verify if is a .html file and if it it exists and returns true or false
        private bool ValidateFilename(string filename)
        {
            return (File.Exists(filename) && filename.Split('.').Last().Equals("html"));
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

            //get rid of HTML tags
            output = Regex.Replace(content, "<[^>]*>", string.Empty);

            //get rid of multiple blank lines
            output = Regex.Replace(output, @"^\s*$\n", string.Empty, RegexOptions.Multiline);

            return output;
        }

        //Method to save result in a .txt file
        public bool SaveResult (string directory, string result)
        {
            System.IO.File.WriteAllText(directory.Substring(0, directory.LastIndexOf(".")+1)+"txt", result);

            return true;
        }
    }
}
