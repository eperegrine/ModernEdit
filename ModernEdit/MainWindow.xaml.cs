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
