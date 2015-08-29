using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernEdit.FileManagement
{
    class MEFile
    {
        public static readonly MEFile ERROR_ME_FILE = new MEFile("ERROR", "ERROR", "ERROR", "ERROR");

        public string Name = "MEFile";
        public string Extension = ".txt";
        public string Content = "This is an example MEFile";
        public string CompletePath = @"C:\ModernEdit\Test.txt";

        public MEFile (string name, string extension, string content, string completePath)
        {
            Name = name;
            Extension = extension;
            Content = content;
            CompletePath = completePath;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            MEFile b = obj as MEFile;

            if (b == null)
            {
                return false;
            }
            else
            {
                return (Name == b.Name && Extension == b.Extension &&
                    Content == b.Content && CompletePath == b.CompletePath);
            }
        }
    }
}
