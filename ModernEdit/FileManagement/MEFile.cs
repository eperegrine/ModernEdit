using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernEdit.FileManagement
{
    public class MEFile
    {
        public static readonly MEFile ERROR_ME_FILE = new MEFile("ERROR", "ERROR", "ERROR", "ERROR");

        public string Name;
        public string Extension;
        public string Content;
        public string CompletePath;

        public string NameAndExtension {   get { return Name + Extension; } }

        public MEFile (string name, string extension, string content, string completePath)
        {
            Name = name;
            Extension = extension;
            Content = content;
            CompletePath = completePath;
        }

        public bool HasBeenSaved ()
        {
            return (this.CompletePath != null && this.CompletePath != ERROR_ME_FILE.CompletePath);
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
