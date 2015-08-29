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
        }

        public List<TabItem> tabItems;

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
            this.ShowMessageAsync("Modern Edit Info", "Version 0.1\nCreated by Tom Peregrine", MessageDialogStyle.Affirmative, null);
        }

    }
}
