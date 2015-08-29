using System;
using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernEdit.FileManagement
{
    public static class FileUtils
    {
        public static string TextFileFilter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

        public static MEFile OpenFile()
        {
            string content = "";
            // Create OpenFileDialog 
            OpenFileDialog dlg = new OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".txt";
            dlg.Filter = TextFileFilter;

            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                content = File.ReadAllText(dlg.FileName);
                string FileName = Path.GetFileNameWithoutExtension(dlg.SafeFileName);
                string Extension = Path.GetExtension(dlg.SafeFileName);
                return new MEFile(FileName, Extension, content, dlg.FileName);
            }
            else
            {
                return MEFile.ERROR_ME_FILE;
            }

            throw new NotImplementedException();
        }
    }
}
