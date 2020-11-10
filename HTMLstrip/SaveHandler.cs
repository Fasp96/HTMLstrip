using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLstrip
{
    class SaveHandler
    {
        //Method to save result in a .txt file
        public bool SaveResult(string directory, string result)
        {
            System.IO.File.WriteAllText(directory.Substring(0, directory.LastIndexOf(".") + 1) + "txt", result);
            return true;
        }
    }
}
