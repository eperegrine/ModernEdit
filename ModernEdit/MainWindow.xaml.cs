using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

using ModernEdit.FileManagement;

namespace ModernEdit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        MyInterTabClient InterTabClient = new MyInterTabClient();
        public MainWindow()
        {
            InitializeComponent();
            currentFile = new MEFile("Example", ".txt", "Hello, World", null);
        }

        public List<TabItem> tabItems;
        MEFile currentFile;

        public void PopulateTabs ()
        {
            tabItems.Clear();
            foreach (TabItem t in TabablzControl.Items)
            {
                tabItems.Add(t);
            }
        }

        public void SetTabContent(int TabIndex, string Header, string content)
        {
            FileTab.Header = Header;
            EditBox.Text = content;
        }

        //Save File
        public void CanSaveFile(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true; //Do work in future to check for any changes
        }

        public void SaveFile (object sender, ExecutedRoutedEventArgs e)
        {
            currentFile.Content = EditBox.Text;
            FileUtils.SaveFile(ref currentFile);
        }

        //Save File As

            //Can check is the same as save file for now

        public void SaveFileAs (object sender, ExecutedRoutedEventArgs e)
        {
            currentFile.Content = EditBox.Text;
            FileUtils.SaveFileAs(ref currentFile);
        }

        //Open File
        public void CanOpenFile(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void OpenFile(object sender, ExecutedRoutedEventArgs e)
        {
            MEFile f = FileUtils.OpenFile();
            if (f != MEFile.ERROR_ME_FILE)
            {
                SetTabContent(0, f.Name + f.Extension, f.Content);
                currentFile = f;
            }
        }

        //Show Info Command
        public void CanShowInfo (object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void ShowInfo (object sender, ExecutedRoutedEventArgs e) { ShowInfo(); }
        
        public void ShowInfo ()
        {
            this.ShowMessageAsync("Modern Edit Info", "Beta Release 1.0\n\nCreated by Tom Peregrine", MessageDialogStyle.Affirmative, null);
        }

    }
}
