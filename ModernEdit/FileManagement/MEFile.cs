using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernEdit.FileManagement
{
    class MEFile
    {
        public string Name = "MEFile";
        public string Extension = ".txt";
        public string Content = "This is an example MEFile";

        public MEFile (string name, string extension, string content)
        {
            Name = name;
            Extension = extension;
            Content = content;
        }
    }
}
