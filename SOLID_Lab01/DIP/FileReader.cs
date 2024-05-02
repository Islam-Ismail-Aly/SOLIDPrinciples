using SOLID_Lab01.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Lab01.DIP
{
    public class FileReader : IFileReader
    {
        public string ReadFile(string filePath)
        {
            // Code to read file content
            return "File content";
        }
    }
}
